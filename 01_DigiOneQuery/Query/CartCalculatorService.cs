using System;
using System.Collections.Generic;
using System.Linq;
using _0_Framwork.Application;
using _01_DigiOneQuery.Contracts.Order;
using DiscountManagement.Infrastructure.EFCore;
using ShopManagement.Application.Contracts.Order;

namespace _01_DigiOneQuery.Query
{
    public class CartCalculatorService : ICartCalculatorService
    {
        private readonly IAuthenticationHelper _authenticationHelper;
        private readonly DiscountContext _discountContext;

        public CartCalculatorService(DiscountContext discountContext, IAuthenticationHelper authenticationHelper)
        {
            _discountContext = discountContext;
            _authenticationHelper = authenticationHelper;
        }

        public Cart ComputingCart(List<CartItem> cartItems)
        {
            var cart = new Cart();

            var colleagueDiscounts = _discountContext.ColleagueDiscounts
                .Where(x => !x.IsRemoved)
                .Select(x => new { x.ProductId, x.DiscountRate })
                .ToList();

            var customerDiscounts = _discountContext.CustomerDiscounts
                .Where(x => x.StartDate < DateTime.Now && x.EndDate > DateTime.Now)
                .Select(x => new { x.ProductId, x.DiscountRate })
                .ToList();

            var currentUserRole = _authenticationHelper.CurrentUserInfo().RoleId;

            foreach (var item in cartItems)
            {
                if (currentUserRole == 4)
                {
                    var colleagueDiscount = colleagueDiscounts.FirstOrDefault(x => x.ProductId == item.Id);
                    if (colleagueDiscount != null)
                        item.DiscountRate = colleagueDiscount.DiscountRate;
                }
                else
                {
                    var customerDiscount = customerDiscounts.FirstOrDefault(x => x.ProductId == item.Id);
                    if (customerDiscount != null)
                        item.DiscountRate = customerDiscount.DiscountRate;
                }

                var calculationDiscountAmount = ((item.TotalItemPrice * item.DiscountRate) / 100);
                item.ItemPayAmount = item.TotalItemPrice - calculationDiscountAmount;
                cart.Add(item);
            }

            return cart;
        }
    }
}
