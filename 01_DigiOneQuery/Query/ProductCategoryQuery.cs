using System;
using System.Collections.Generic;
using System.Linq;
using _0_Framwork.Application;
using _01_DigiOneQuery.Contracts.Product;
using _01_DigiOneQuery.Contracts.ProductCategory;
using DiscountManagement.Infrastructure.EFCore;
using InventoryManagement.Infrastructure.EFCore;
using Microsoft.EntityFrameworkCore;
using ShopManagement.Domain.Product;
using ShopManagement.Infrastructure.EFCore;

namespace _01_DigiOneQuery.Query
{
    public class ProductCategoryQuery : IProductCategoryQuery
    {
        private readonly ShopContext _shopContext;
        private readonly InventoryContext _inventoryContext;
        private readonly DiscountContext _discountContext;

        public ProductCategoryQuery(ShopContext shopContext, InventoryContext inventoryContext, DiscountContext discountContext)
        {
            _shopContext = shopContext;
            _inventoryContext = inventoryContext;
            _discountContext = discountContext;
        }

        public List<ProductCategoryQueryModel> GetAll()
        {
            return _shopContext.productCategories.Select(x => new ProductCategoryQueryModel
            {
                Name = x.Name,
                Picture = x.Picture,
                PictureAlt = x.PictureAlt,
                PictureTitle = x.PictureTitle,
                Slug = x.Slug
            }).ToList();
        }

        public ProductCategoryQueryModel GetProductCategorywidthProductsBy(string slug)
        {
            var inventory = _inventoryContext.Inventory.Select(x => new { x.UnitPrice, x.ProductId }).ToList();
            var discounts = _discountContext.CustomerDiscounts
                    .Where(x => x.StartDate < DateTime.Now && x.EndDate > DateTime.Now)
                    .Select(x=>new{x.DiscountRate,x.ProductId,x.EndDate}).ToList();

            var productCategories = _shopContext.productCategories
                .Include(x => x.Products)
                .Select(x => new ProductCategoryQueryModel
                {
                    Name = x.Name,
                    Picture = x.Picture,
                    PictureAlt = x.PictureAlt,
                    PictureTitle = x.PictureTitle,
                    Slug = x.Slug,
                    Products = MapProducts(x.Products),
                    MetaDescription = x.MetaDescription,
                    Keywords = x.Keywords
                }).FirstOrDefault(x => x.Slug == slug);

            foreach (var item in productCategories.Products)
            {
                var productInventory = inventory.FirstOrDefault(x => x.ProductId == item.Id);
                if (productInventory != null)
                {
                    var price = productInventory.UnitPrice;
                    item.Price = price.ToMoney();

                    var productDiscount = discounts.FirstOrDefault(x => x.ProductId == item.Id);
                    if (productDiscount != null)
                    {
                        int discountRate = productDiscount.DiscountRate;
                        item.DiscountRate = discountRate;

                        item.DiscountExpireDate = productDiscount.EndDate.ToDiscountFormat();
                        item.HasDiscount = discountRate > 0;
                        var discountAmount = Math.Round((price * discountRate) / 100);
                        item.PriceAfterDiscount = (price - discountAmount).ToMoney();
                    }
                }
            }
            return productCategories;
        }

        private static List<ProductQueryModel> MapProducts(List<ProductEntity> Products)
        {
            return Products.Select(x => new ProductQueryModel
            {
                Id = x.Id,
                Name = x.Name,
                Picture = x.Picture,
                PictureAlt = x.PictureAlt,
                PictureTitle = x.PictureTitle,
                Slug = x.Slug,
            }).ToList();
        }
    }
}
