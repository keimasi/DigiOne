using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using _0_Framwork.Infrastructure;
using Microsoft.EntityFrameworkCore;
using ShopManagement.Application.Contracts.Product;
using ShopManagement.Domain.Product;

namespace ShopManagement.Infrastructure.EFCore.Repository
{
    public class ProductRepository : RepositoryBace<int, ProductEntity>, IProductRepository
    {
        private readonly ShopContext _context;

        public ProductRepository(ShopContext context) : base(context)
        {
            _context = context;
        }

        public EditProduct GetDetails(int id)
        {
            return _context.Products.Select(x => new EditProduct
            {
                Name = x.Name,
                Code = x.Code,
                ShortDescription = x.ShortDescription,
                Description = x.Description,
                Picture = x.Picture,
                PictureAlt = x.PictureAlt,
                PictureTitle = x.PictureTitle,
                Slug = x.Slug,
                Keywords = x.Keywords,
                MetaDescription = x.MetaDescription,
                CategoryId = x.CategoryId,
                Id = x.Id
            }).FirstOrDefault(x => x.Id == id);
        }

        public List<ProductViewModel> GetProducts()
        {
            var products = _context.Products
                .Include(p => p.Category)
                .ToList();

            var productViewModels = products.Select(x => new ProductViewModel
            {
                Id = x.Id,
                Name = x.Name,
                Code = x.Code,
                IsInStock = x.IsInStock,
                Picture = x.Picture,
                CategoryName = x.Category.Name,
                CreateDate = x.CreateDate.ToString(CultureInfo.InvariantCulture),
            });

            return productViewModels.ToList();
        }
    }
}
