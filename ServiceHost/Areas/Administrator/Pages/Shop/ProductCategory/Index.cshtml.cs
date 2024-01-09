using System.Collections.Generic;
using _0_Framwork.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ShopManagement.Application.Contracts.ProductCategory;
using ShopManagement.Infrastructure.Config.Permissions;

namespace ServiceHost.Areas.Administrator.Pages.Shop.ProductCategory
{
    public class IndexModel : PageModel
    {
        public List<ProductCategoryViewModel> ProductCategoryList;

         readonly IProductCategoryApplication _productCategoryApplication;

        public IndexModel(IProductCategoryApplication productCategoryApplication)
        {
            _productCategoryApplication = productCategoryApplication;
        }

        [NeedsPermission(ShopPermissions.ListProductCategory)]
        public void OnGet()
        {
            ProductCategoryList = _productCategoryApplication.GetProductCategories();
        }

        [NeedsPermission(ShopPermissions.CreateProductCategory)]
        public IActionResult OnGetCreate()
        {
            return Partial("./Create", new CreateProductCategory());
        }

        [NeedsPermission(ShopPermissions.CreateProductCategory)]
        public JsonResult OnPostCreate(CreateProductCategory command)
        {
            var result=_productCategoryApplication.Create(command);
            return new JsonResult(result);
        }

        [NeedsPermission(ShopPermissions.EditProductCategory)]
        public IActionResult OnGetEdit(int id)
        {
            var productCategory = _productCategoryApplication.GetDetails(id);
            return Partial("Edit", productCategory);
        }

        [NeedsPermission(ShopPermissions.EditProductCategory)]
        public JsonResult OnPostEdit(EditProductCategory command)
        {
            var result=_productCategoryApplication.Edit(command);
            return new JsonResult(result);
        }
    }
}
