using System;
using System.Collections.Generic;
using System.Linq;
using _0_Framwork.Application;
using _01_DigiOneQuery.Contracts.Order;
using DiscountManagement.Infrastructure.EFCore;
using InventoryManagement.Infrastructure.EFCore;
using ShopManagement.Infrastructure.EFCore;

namespace _01_DigiOneQuery.Query
{
    public class OrderQuery : IOrderQuery
    {
        private readonly ShopContext _shopContext;
        private readonly InventoryContext _inventoryContext;
        private readonly DiscountContext _discountContext;

        public OrderQuery(ShopContext shopContext, InventoryContext inventoryContext, DiscountContext discountContext)
        {
            _shopContext = shopContext;
            _inventoryContext = inventoryContext;
            _discountContext = discountContext;
        }

        public List<BestSellingProductsQueryModel> GetBestSellingProducts()
        {
            var productPrices = _inventoryContext.Inventory
                .Select(x => new { x.UnitPrice, x.ProductId })
                .ToList();

            var productDetails = _shopContext.Products
                .Select(x => new { x.Id, x.Name, x.Picture, x.PictureAlt, x.PictureTitle,x.Slug })
                .ToList();

            var activeDiscounts = _discountContext.CustomerDiscounts
                .Where(x => x.StartDate < DateTime.Now && x.EndDate > DateTime.Now)
                .Select(x => new { x.DiscountRate, x.ProductId, x.EndDate })
                .ToList();

            var topSellingProducts = _shopContext.Orders
                .Where(order => !order.IsCanceled)
                .SelectMany(order => order.Items)
                .GroupBy(item => item.ProductId)
                .Select(group => new { ProductId = group.Key, Count = group.Count() })
                .OrderByDescending(item => item.Count)
                .Take(7)
                .ToList();

            var bestSellingProducts = new List<BestSellingProductsQueryModel>();

            foreach (var productCount in topSellingProducts)
            {
                var productPrice = productPrices.FirstOrDefault(x => x.ProductId == productCount.ProductId);
                var productDetail = productDetails.FirstOrDefault(x => x.Id == productCount.ProductId);

                if (productPrice is not null && productDetail is not null)
                {
                    var productDiscount = activeDiscounts.FirstOrDefault(x => x.ProductId == productCount.ProductId);

                    var price = productPrice.UnitPrice;

                    var viewModel = new BestSellingProductsQueryModel
                    {
                        Name = productDetail.Name,
                        Price = price.ToMoney(),
                        Picture = productDetail.Picture,
                        PictureAlt = productDetail.PictureAlt,
                        PictureTitle = productDetail.PictureTitle,
                        Slug = productDetail.Slug
                    };

                    if (productDiscount is not null)
                    {
                        int discountRate = productDiscount.DiscountRate;
                        viewModel.DiscountRate = discountRate;

                        viewModel.HasDiscount = discountRate > 0;
                        var discountAmount = Math.Round((price * discountRate) / 100);
                        viewModel.PriceAfterDiscount = (price - discountAmount).ToMoney();
                    }

                    bestSellingProducts.Add(viewModel);
                }
            }

            return bestSellingProducts;
        }

    }
}