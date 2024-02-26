using System.Collections.Generic;
using System.Linq;
using _0_Framwork.Application;
using _0_Framwork.Infrastructure;
using Microsoft.EntityFrameworkCore;
using ShopManagement.Application.Contracts.ProductPicture;
using ShopManagement.Domain.ProductPicture;

namespace ShopManagement.Infrastructure.EFCore.Repository
{
    public class ProductPictureRepository : RepositoryBace<int, ProductPictureEntity>, IProductPictureRepository
    {
        private readonly ShopContext _context;

        public ProductPictureRepository(ShopContext context) : base(context)
        {
            _context = context;
        }

        public EditProductPicture GetDetails(int id)
        {
            return _context.ProductPictures.Select(x => new EditProductPicture
            {
                Id = x.Id,
                PictureTitle = x.PictureTitle,
                PictureAlt = x.PictureAlt,
                ProductId = x.ProductId,
            }).FirstOrDefault(x => x.Id == id);
        }

        public List<ProductPictureViewModel> GetProductPictures()
        {
            return _context.ProductPictures.Include(x => x.Product).Select(x => new ProductPictureViewModel
            {
                Id = x.Id,
                Product = x.Product.Name,
                Picture = x.Picture,
                CreateDate = x.CreateDate.ToFarsi(),
                IsRemoved = x.IsRemove
            }).ToList();
        }

        public ProductPictureEntity GetWithProductANDCategory(int id)
        {
            return _context.ProductPictures.Include(x => x.Product).ThenInclude(x => x.Category)
                .FirstOrDefault(x => x.Id == id);
        }
    }
}
