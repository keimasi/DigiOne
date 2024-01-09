﻿using System;
using System.Collections.Generic;
using System.Linq;
using _01_DigiOneQuery.Contracts.Product;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Nancy.Json;
using Newtonsoft.Json;
using ShopManagement.Application.Contracts.Order;

namespace ServiceHost.Pages
{
    public class CartModel : PageModel
    {
        public const string cookieName = "cart-items";
        private readonly IProductQuery _productQuery;
        public List<CartItem> CartItems;

        public CartModel(IProductQuery productQuery)
        {
            _productQuery = productQuery;
            CartItems=new List<CartItem>();
        }

        public void OnGet()
        {
            string cookieValue = Request.Cookies[cookieName];
            var cartItems = JsonConvert.DeserializeObject<List<CartItem>>(cookieValue);
            foreach (var item in cartItems)
            {
                item.Price = item.Price.Replace("٬", "");
                item.TotalItemPrice = double.Parse(item.Price) * item.Count;
            }

            CartItems = _productQuery.CheckInventoryStatus(cartItems);
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

        public RedirectToPageResult OnGetGotoCheckOut()
        {
            string cookieValue = Request.Cookies[cookieName];
            var cartItems = JsonConvert.DeserializeObject<List<CartItem>>(cookieValue);
            foreach (var item in cartItems)
            {
                item.Price = item.Price.Replace("٬", "");
                item.TotalItemPrice = double.Parse(item.Price) * item.Count;
            }

            CartItems = _productQuery.CheckInventoryStatus(cartItems);

            return RedirectToPage(CartItems.Any(x => !x.IsInStock) ? "/Cart" : "/Checkout");
        }
    }
}
