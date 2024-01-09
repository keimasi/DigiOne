using System.Collections.Generic;
using _0_Framwork.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ShopManagement.Application.Contracts.Product;
using ShopManagement.Application.Contracts.ProductCategory;
using ShopManagement.Infrastructure.Config.Permissions;

namespace ServiceHost.Areas.Administrator.Pages.Shop.Product
{
    public class IndexModel : PageModel
    {
        [TempData]
        public string Message { get; set; }
        public List<ProductViewModel> ProductList;

        private readonly IProductApplication _productApplication;
        private readonly IProductCategoryApplication _productCategoryApplication;

        public IndexModel(IProductApplication productApplication, IProductCategoryApplication productCategoryApplication)
        {
            _productApplication = productApplication;
            _productCategoryApplication = productCategoryApplication;
        }

        [NeedsPermission(ShopPermissions.ListProduct)]
        public void OnGet()
        {
            ProductList = _productApplication.GetProducts();
        }

        [NeedsPermission(ShopPermissions.CreateProduct)]
        public IActionResult OnGetCreate()
        {
            var command = new CreateProduct
            {
                Category = _productCategoryApplication.GetProductCategories()
            };
            return Partial("./Create", command);
        }

        [NeedsPermission(ShopPermissions.CreateProduct)]

        public JsonResult OnPostCreate(CreateProduct command)
        {
            var result = _productApplication.Create(command);
            return new JsonResult(result);
        }

        [NeedsPermission(ShopPermissions.EditProduct)]
        public IActionResult OnGetEdit(int id)
        {
            var product = _productApplication.GetDetails(id);
            product.Category = _productCategoryApplication.GetProductCategories();
            return Partial("Edit", product);
        }

        [NeedsPermission(ShopPermissions.EditProduct)]
        public JsonResult OnPostEdit(EditProduct command)
        {
            var result = _productApplication.Edit(command);
            return new JsonResult(result);
        }
    }
}
