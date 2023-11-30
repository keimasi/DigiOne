using System.Collections.Generic;
using System.Linq;
using _0_Framwork.Application;
using _0_Framwork.Infrastructure;
using DiscountManagement.Application.Contracts.ColleagueDiscount;
using DiscountManagement.Domain.ColleagueDiscount;
using ShopManagement.Infrastructure.EFCore;

namespace DiscountManagement.Infrastructure.EFCore.Repository
{
    public class ColleagueDiscountRepository:RepositoryBace<int,ColleagueDiscountEntity>,IColleagueDiscountRepository
    {
        private readonly DiscountContext _context;
        private readonly ShopContext _shopContext;

        public ColleagueDiscountRepository(DiscountContext context, ShopContext shopContext) : base(context)
        {
            _context = context;
            _shopContext = shopContext;
        }

        public EditColleagueDiscount GetDetails(int id)
        {
            return _context.ColleagueDiscounts.Select(x=>new EditColleagueDiscount
            {
                DiscountRate = x.DiscountRate,
                ProductId = x.ProductId,
                Id = x.Id,
            }).FirstOrDefault(x => x.Id == id);
        }

        public List<ColleagueDiscountViewModel> GetColleagueDiscounts()
        {
            var products = _shopContext.Products.ToDictionary(x => x.Id, x => x.Name);

            return _context.ColleagueDiscounts.Select(x => new ColleagueDiscountViewModel
            {
                product = products.ContainsKey(x.ProductId) ? products[x.ProductId] : "Unknown Product",
                CreateDate = x.CreateDate.ToFarsi(),
                DiscountRate = x.DiscountRate,
                Id = x.Id,
                IsRemoved = x.IsRemoved
            }).ToList();
        }
    }
}
