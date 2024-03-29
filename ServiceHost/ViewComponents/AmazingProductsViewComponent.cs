using _01_DigiOneQuery.Contracts.Product;
using Microsoft.AspNetCore.Mvc;

namespace ServiceHost.ViewComponents
{
    public class AmazingProductsViewComponent : ViewComponent
    {
        private readonly IProductQuery _productQuery;

        public AmazingProductsViewComponent(IProductQuery productQuery)
        {
            _productQuery = productQuery;
        }

        public IViewComponentResult Invoke()
        {
            var amazingProducts = _productQuery.GetAmazingProducts();
            return View(amazingProducts);
        }
    }
}
