using System.Collections.Generic;
using DiscountManagement.Application.Contracts.ColleagueDiscount;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ShopManagement.Application.Contracts.Product;

namespace ServiceHost.Areas.Administrator.Pages.Discounts.ColleagueDiscount
{
    public class IndexModel : PageModel
    {
        public List<ColleagueDiscountViewModel> ColleagueDiscountList;

        private readonly IProductApplication _productApplication;
        private readonly IColleagueDiscountApplication _colleagueDiscountApplication;

        public IndexModel(IProductApplication productApplication, IColleagueDiscountApplication colleagueDiscountApplication)
        {
            _productApplication = productApplication;
            _colleagueDiscountApplication = colleagueDiscountApplication;
        }


        public void OnGet()
        {
            ColleagueDiscountList = _colleagueDiscountApplication.GetColleagueDiscounts();
        }

        public IActionResult OnGetCreate()
        {
            var command = new CreateColleagueDiscount
            {
                Product = _productApplication.GetProducts()
            };
            return Partial("./Create", command);
        }

        public JsonResult OnPostCreate(CreateColleagueDiscount command)
        {
            var result = _colleagueDiscountApplication.Create(command);
            return new JsonResult(result);
        }

        public IActionResult OnGetEdit(int id)
        {
            var colleagueDiscount = _colleagueDiscountApplication.GetDetails(id);
            colleagueDiscount.Product = _productApplication.GetProducts();
            return Partial("Edit", colleagueDiscount);
        }

        public JsonResult OnPostEdit(EditColleagueDiscount command)
        {
            var result = _colleagueDiscountApplication.Edit(command);
            return new JsonResult(result);
        }

        public RedirectToPageResult OnGetRemove(int id)
        {
            var colleagueDiscount = _colleagueDiscountApplication.Remove(id);
            return RedirectToPage("./Index");
        }

        public RedirectToPageResult OnGetRestore(int id)
        {
            var colleagueDiscount = _colleagueDiscountApplication.Restore(id);
            return RedirectToPage("./Index");
        }
    }
}
