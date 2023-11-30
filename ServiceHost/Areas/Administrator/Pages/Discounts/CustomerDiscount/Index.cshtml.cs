using System.Collections.Generic;
using DiscountManagement.Application.Contracts.CustomerDiscount;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ShopManagement.Application.Contracts.Product;

namespace ServiceHost.Areas.Administrator.Pages.Discounts.CustomerDiscount
{
    public class IndexModel : PageModel
    {
        public List<CustomerDiscountViewModel> CustomerDiscountList;

        private readonly IProductApplication _productApplication;
        private readonly ICustomerDiscountApplication _customerDiscountApplication;

        public IndexModel(IProductApplication productApplication, ICustomerDiscountApplication customerDiscountApplication)
        {
            _productApplication = productApplication;
            _customerDiscountApplication = customerDiscountApplication;
        }

        public void OnGet()
        {
            CustomerDiscountList = _customerDiscountApplication.GetCustomerDiscounts();
        }

        public IActionResult OnGetCreate()
        {
            var command = new CreateCustomerDiscount
            {
                Product = _productApplication.GetProducts()
            };
            return Partial("./Create", command);
        }

        public JsonResult OnPostCreate(CreateCustomerDiscount command)
        {
            var result = _customerDiscountApplication.Create(command);
            return new JsonResult(result);
        }

        public IActionResult OnGetEdit(int id)
        {
            var CustomerDiscount = _customerDiscountApplication.GetDetails(id);
            CustomerDiscount.Product = _productApplication.GetProducts();
            return Partial("Edit", CustomerDiscount);
        }

        public JsonResult OnPostEdit(EditCustomerDiscount command)
        {
            var result = _customerDiscountApplication.Edit(command);
            return new JsonResult(result);
        }
    }
}
