using System;
using System.Collections.Generic;
using System.Linq;
using _0_Framwork.Application;
using _01_DigiOneQuery.Contracts.Product;
using DiscountManagement.Domain.CustomerDiscount;
using DiscountManagement.Infrastructure.EFCore;
using InventoryManagement.Domain.Inventory;
using InventoryManagement.Infrastructure.EFCore;
using Microsoft.EntityFrameworkCore;
using ShopManagement.Application.Contracts.Order;
using ShopManagement.Domain.Comment;
using ShopManagement.Domain.ProductPicture;
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
            var products = GetProductsQuery(value).OrderByDescending(x => x.Id).ToList();
            LoadProductData(products);
            return products;
        }

        public ProductQueryModel GetProduct(string slug)
        {
            var product = GetProductsQuery().FirstOrDefault(x => x.Slug == slug);
            if (product == null)
                return new ProductQueryModel();

            LoadProductData(new List<ProductQueryModel> { product });
            return product;
        }

        public List<CartItem> CheckInventoryStatus(List<CartItem> cartItems)
        {
            var inventory = GetInventories();
            foreach (var item in cartItems.Where(q => inventory.Any(x => x.ProductId == q.Id && x.InStock)))
            {
                var itemInventory = inventory.Find(x => x.ProductId == item.Id);
                if (itemInventory != null)
                    item.IsInStock = itemInventory.CalculationCurrentCount() >= item.Count;
            }
            return cartItems;
        }

        public List<ProductQueryModel> GetAmazingProducts()
        {
            var amazingProducts = new List<ProductQueryModel>();
            var activeDiscounts = GetActiveDiscounts().Where(x => x.DiscountRate > 40);

            foreach (var discount in activeDiscounts)
            {
                var product = GetProductsQuery().FirstOrDefault(x => x.Id == discount.ProductId);
                if (product != null)
                {
                    LoadProductData(new List<ProductQueryModel> { product });
                    amazingProducts.Add(product);
                }
            }
            return amazingProducts;
        }

        private IQueryable<ProductQueryModel> GetProductsQuery(string value = null)
        {
            var query = _shopContext.Products
                .Select(x => new ProductQueryModel
                {
                    Id = x.Id,
                    Name = x.Name,
                    Picture = x.Picture,
                    PictureAlt = x.PictureAlt,
                    PictureTitle = x.PictureTitle,
                    Slug = x.Slug,
                    Category = x.Category.Name,
                    CategorySlug = x.Category.Slug,
                    ShortDescription = x.ShortDescription,
                    Description = x.Description,
                    Keywords = x.Keywords,
                    MetaDescription = x.MetaDescription,
                    Pictures = MapProductPictures(x.ProductPicture),
                    Comments = MapComments(x.Comments)
                }).AsNoTracking();

            if (!string.IsNullOrWhiteSpace(value))
                query = query.Where(x => x.Name.Contains(value));

            return query;
        }

        private static List<CommentQueryModel> MapComments(List<CommentEntity> comments)
        {
            return comments.Where(x => x.CommentStatus).Select(x => new CommentQueryModel
            {
                Name = x.Name,
                CreateDate = x.CreateDate.ToFarsi(),
                Message = x.Message,
            }).ToList();
        }

        private static List<ProductPictureQueryModel> MapProductPictures(List<ProductPictureEntity> productPictures)
        {
            return productPictures.Select(x => new ProductPictureQueryModel
            {
                Picture = x.Picture,
                PictureAlt = x.PictureAlt,
                PictureTitle = x.PictureTitle,
                ProductId = x.ProductId,
                IsRemove = x.IsRemove
            }).Where(x => !x.IsRemove).ToList();
        }

        private List<InventoryEntity> GetInventories()
        {
            return _inventoryContext.Inventory.ToList();
        }

        private List<CustomerDiscountEntity> GetActiveDiscounts()
        {
            return _discountContext.CustomerDiscounts
                .Where(x => x.StartDate < DateTime.Now && x.EndDate > DateTime.Now)
                .ToList();
        }

        private void LoadProductData(List<ProductQueryModel> products)
        {
            var inventory = GetInventories();
            var discounts = GetActiveDiscounts();

            foreach (var product in products)
            {
                var productInventory = inventory.FirstOrDefault(x => x.ProductId == product.Id);
                if (productInventory != null)
                {
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
            }
        }
    }
}
