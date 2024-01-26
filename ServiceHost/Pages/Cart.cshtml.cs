using System;
using System.Collections.Generic;
using System.Linq;
using _0_Framwork.Application;
using _0_Framwork.Application.ZarinPal;
using _01_DigiOneQuery.Contracts.Order;
using _01_DigiOneQuery.Contracts.Product;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Nancy.Json;
using ShopManagement.Application.Contracts.Order;

namespace ServiceHost.Pages
{
    [Authorize]
    public class CartModel : PageModel
    {
        private readonly IProductQuery _productQuery;
        private readonly ICartCalculatorService _cartCalculatorService;
        private readonly ICartService _cartService;
        private readonly IZarinPalFactory _zarinPalFactory;
        private readonly IOrderApplication _orderApplication;

        public const string cookieName = "cart-items";
        public List<CartItem> CartItems;
        public Cart Cart;

        public CartModel(IProductQuery productQuery, ICartCalculatorService cartCalculatorService, ICartService cartService, IZarinPalFactory zarinPalFactory, IOrderApplication orderApplication, IAuthenticationHelper authenticationHelper)
        {
            _productQuery = productQuery;
            _cartCalculatorService = cartCalculatorService;
            _cartService = cartService;
            _zarinPalFactory = zarinPalFactory;
            _orderApplication = orderApplication;
            CartItems = new List<CartItem>();
        }

        public void OnGet()
        {
            var serializer = new JavaScriptSerializer();
            var value = Request.Cookies[cookieName];
            var cartItems = serializer.Deserialize<List<CartItem>>(value);
            foreach (var item in cartItems)
            {
                item.Price = item.Price.Replace("٬", "");
                item.TotalItemPrice = double.Parse(item.Price) * item.Count;
            }

            CartItems = _productQuery.CheckInventoryStatus(cartItems);
            Cart = _cartCalculatorService.ComputingCart(cartItems);
            _cartService.Set(Cart);
        }

        public RedirectToPageResult OnGetRemoveCartItem(int id)
        {
            var serializer = new JavaScriptSerializer();
            var value = Request.Cookies[cookieName];
            Response.Cookies.Delete(cookieName);
            var cartItems = serializer.Deserialize<List<CartItem>>(value);
            var itemToRemove = cartItems.FirstOrDefault(x => x.Id == id);
            cartItems.Remove(itemToRemove);
            var options = new CookieOptions { Expires = DateTime.Now.AddDays(2) };
            Response.Cookies.Append(cookieName, serializer.Serialize(cartItems), options);
            return RedirectToPage("/Cart");
        }

        public IActionResult OnGetPay()
        {
            var cart = _cartService.Get();
            var result = _productQuery.CheckInventoryStatus(cart.Items);

            if (result.Any(x => !x.IsInStock))
                return RedirectToPage("/Cart");

            var orderId = _orderApplication.PlaceOrder(cart);
            var paymentResponse = _zarinPalFactory.CreatePaymentRequest(cart.AmountPaid.ToString(), "", "", "خرید از دیجی وان", orderId);

            return Redirect($"https://{_zarinPalFactory.Prefix}.zarinpal.com/pg/StartPay/{paymentResponse.Authority}");
        }

        public IActionResult OnGetCallBack([FromQuery] string authority, [FromQuery] string status, [FromQuery] int oId)
        {
            var orderAmount = _orderApplication.GetAmountBy(oId);
            var verificationResponse = _zarinPalFactory.CreateVerificationRequest(authority, orderAmount.ToString());
            var result = new PaymentResult();
            if (status == "OK" && verificationResponse.Status >= 100)
            {
                var issueTrackingNum = _orderApplication.PaymentSucceeded(oId, verificationResponse.RefID);
                Response.Cookies.Delete("cart-items");
                result = result.Succeeded("پرداخت با موفقیت انجام شد", issueTrackingNum);
                return RedirectToPage("/PaymentResult", result);
            }
            else
            {
                result = result.Failed("پرداخت با خطا مواجه شده است");
                return RedirectToPage("/PaymentResult", result);
            }
        }
    }
}
