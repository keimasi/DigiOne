using _01_DigiOneQuery.Contracts.Order;
using Microsoft.AspNetCore.Mvc;

namespace ServiceHost.ViewComponents
{
    public class BestSellingProductsViewComponent : ViewComponent
    {
        private readonly IOrderQuery _orderQuery;

        public BestSellingProductsViewComponent(IOrderQuery orderQuery)
        {
            _orderQuery = orderQuery;
        }

        public IViewComponentResult Invoke()
        {
            var bestSellingProducts = _orderQuery.GetBestSellingProducts();
            return View(bestSellingProducts);
        }
    }
}
