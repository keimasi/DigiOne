using _0_Framwork.Infrastructure;
using DiscountManagement.Application.Contracts.CustomerDiscount;
using DiscountManagement.Domain.CustomerDiscount;
using System.Collections.Generic;
using System.Linq;
using _0_Framwork.Application;
using ShopManagement.Infrastructure.EFCore;

namespace DiscountManagement.Infrastructure.EFCore.Repository
{
    public class CustomerDiscountRepository : RepositoryBace<int, CustomerDiscountEntity>, ICustomerDiscountRepository
    {
        private readonly DiscountContext _context;
        private readonly ShopContext _shopContext;

        public CustomerDiscountRepository(DiscountContext context, ShopContext shopContext) : base(context)
        {
            _context = context;
            _shopContext = shopContext;
        }

        public List<CustomerDiscountViewModel> GetCustomerDiscounts()
        {
            var products = _shopContext.Products.ToDictionary(x => x.Id, x => x.Name);

            return _context.CustomerDiscounts.Select(x => new CustomerDiscountViewModel
            {
                Id = x.Id,
                DiscountRate = x.DiscountRate,
                StartDate = x.StartDate.ToFarsi(),
                EndDate = x.EndDate.ToFarsi(),
                Description = x.Description,
                Product = products.ContainsKey(x.ProductId) ? products[x.ProductId] : "Unknown Product",
                CreateDate = x.CreateDate.ToFarsi(),
            }).ToList();
        }



        public EditCustomerDiscount GetDetails(int id)
        {
            return _context.CustomerDiscounts.Select(x => new EditCustomerDiscount
            {
                DiscountRate = x.DiscountRate,
                StartDate = x.StartDate.ToString(),
                EndDate = x.EndDate.ToString(),
                Description = x.Description,
                ProductId = x.ProductId,
                Id = x.Id
            }).FirstOrDefault(x => x.Id == id);
        }
    }
}
