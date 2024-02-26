using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ShopManagement.Application.Contracts.Order;

namespace ServiceHost.Areas.Administrator.Pages.Shop.Order
{
    public class IndexModel : PageModel
    {
        public List<OrderVIewModel> OrderList;

        private readonly IOrderApplication _orderApplication;

        public IndexModel(IOrderApplication orderApplication)
        {
            _orderApplication = orderApplication;
        }

        public void OnGet()
        {
            OrderList = _orderApplication.GetOrders();
        }

        public IActionResult OnGetConfirm(int id)
        {
            _orderApplication.PaymentSucceeded(id, 0);
            return RedirectToPage("./Index");
        }

        public IActionResult OnGetCancel(int id)
        {
            _orderApplication.Cancel(id);
            return RedirectToPage("./Index");
        }

        public IActionResult OnGetItems(int id)
        {
            var item = _orderApplication.GetOrderItems(id);
            return Partial("Items", item);
        }
    }
}
