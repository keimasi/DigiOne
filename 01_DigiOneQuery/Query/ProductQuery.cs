using System;
using System.Collections.Generic;
using System.Linq;
using _0_Framwork.Application;
using _01_DigiOneQuery.Contracts.Product;
using DiscountManagement.Infrastructure.EFCore;
using InventoryManagement.Infrastructure.EFCore;
using Microsoft.EntityFrameworkCore;
using ShopManagement.Infrastructure.EFCore;

namespace _01_DigiOneQuery.Query
{
    public class ProductQuery : IProductQuery
    {
        private readonly ShopContext _shopContext;
        private readonly InventoryContext _inventoryContext;
        private readonly DiscountContext _discountContext;

        public ProductQuery(InventoryContext inventoryContext, DiscountContext discountContext, ShopContext shopContext)
        {
            _inventoryContext = inventoryContext;
            _discountContext = discountContext;
            _shopContext = shopContext;
        }

        public List<ProductQueryModel> Search(string value)
        {
            var inventory = _inventoryContext.Inventory.Select(x => new { x.UnitPrice, x.ProductId }).ToList();
            var discounts = _discountContext.CustomerDiscounts
                .Where(x => x.StartDate < DateTime.Now && x.EndDate > DateTime.Now)
                .Select(x => new { x.DiscountRate, x.ProductId, x.EndDate }).ToList();

            var query = _shopContext.Products
                .Select(x => new ProductQueryModel
                {
                    Id = x.Id,
                    Name = x.Name,
                    Picture = x.Picture,
                    PictureAlt = x.PictureAlt,
                    PictureTitle = x.PictureTitle,
                    Slug = x.Slug,
                }).AsNoTracking();

            if (!string.IsNullOrWhiteSpace(value))
                query = query.Where(x => x.Name.Contains(value));

            var products = query.OrderByDescending(x => x.Id).ToList();

            foreach (var item in products)
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
            return products;
        }

        public ProductQueryModel GetProduct(string slug)
        {
            var inventory = _inventoryContext.Inventory.Select(x => new { x.UnitPrice, x.ProductId, x.InStock }).ToList();

            var discounts = _discountContext.CustomerDiscounts
                .Where(x => x.StartDate < DateTime.Now && x.EndDate > DateTime.Now)
                .Select(x => new { x.DiscountRate, x.ProductId, x.EndDate }).ToList();

            var product = _shopContext.Products
                .Include(x => x.Category)
                .Select(x => new ProductQueryModel
                {
                    Id = x.Id,
                    Name = x.Name,
                    Category = x.Category.Name,
                    CategorySlug = x.Category.Slug,
                    Picture = x.Picture,
                    PictureAlt = x.PictureAlt,
                    PictureTitle = x.PictureTitle,
                    Slug = x.Slug,
                    ShortDescription = x.ShortDescription,
                    Description = x.Description,
                    Keywords = x.Keywords,
                    MetaDescription = x.MetaDescription,
                }).AsNoTracking().FirstOrDefault(x => x.Slug == slug);

            if (product == null)
                return new ProductQueryModel();

            var productInventory = inventory.FirstOrDefault(x => x.ProductId == product.Id);
            if (productInventory != null)
            {
                product.IsInStock = productInventory.InStock;

                var price = productInventory.UnitPrice;
                product.Price = price.ToMoney();

                var productDiscount = discounts.FirstOrDefault(x => x.ProductId == product.Id);
                if (productDiscount != null)
                {
                    int discountRate = productDiscount.DiscountRate;
                    product.DiscountRate = discountRate;

                    product.DiscountExpireDate = productDiscount.EndDate.ToDiscountFormat();
                    product.HasDiscount = discountRate > 0;
                    var discountAmount = Math.Round((price * discountRate) / 100);
                    product.PriceAfterDiscount = (price - discountAmount).ToMoney();
                }
            }

            return product;
        }
    }
}
