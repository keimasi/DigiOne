using System;
using System.Collections.Generic;
using System.Linq;
using _0_Framwork.Application;
using AccountManagement.Application.Contracts.Account;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ReportManagement.Application.Contracts.SiteVisit;
using ShopManagement.Application.Contracts.Order;
using ShopManagement.Application.Contracts.Product;

namespace ServiceHost.Areas.Administrator.Pages
{
    public class IndexModel : PageModel
    {
        public SiteVisitViewModel VisitViewModel;
        public List<Chart> BarChartDataSet { get; set; } = new();

        private readonly IOrderApplication _orderApplication;
        private readonly IProductApplication _productApplication;
        private readonly IAccountApplication _accountApplication;
        private readonly ISiteVisitApplication _siteVisitApplication;

        public IndexModel(IOrderApplication orderApplication, IProductApplication productApplication, IAccountApplication accountApplication, ISiteVisitApplication siteVisitApplication)
        {
            _orderApplication = orderApplication;
            _productApplication = productApplication;
            _accountApplication = accountApplication;
            _siteVisitApplication = siteVisitApplication;
        }

        public void OnGet()
        {
            VisitViewModel = _siteVisitApplication.GetVisitStatistics();

            ViewData["totalRevenue"] = _orderApplication.GetTotalSales();
            ViewData["numberOfProducts"] = _productApplication.GetNumberOfProducts();
            ViewData["numberOfUser"] = _accountApplication.GetUserOfNumber();
            ViewData["salesNumber"] = _orderApplication.GetSalesNumber();

            #region BarChart

            var sevenDaysAgoList = Enumerable
                .Range(0, 7)
                .Select(i => DateTime.Now.AddDays(-i).ToFarsi())
                .ToList();

            var orders = _orderApplication
                .GetOrders()
                .Select(x => new { x.CreateDate, x.PayAmount });

            foreach (var item in sevenDaysAgoList)
            {
                var orderData = orders
                    .Where(x => x.CreateDate == item)
                    .Sum(x => x.PayAmount);

                var chartData = new Chart
                {
                    Label = item,
                    Data = new List<double>
                    {
                        orderData
                    }
                };

                BarChartDataSet.Add(chartData);
            }

            #endregion
        }
    }

    public class Chart
    {
        public string Label { get; set; }
        public List<double> Data { get; set; }
    }
}
