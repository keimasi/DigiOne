using System.Collections.Generic;
using _0_Framwork.Domain;
using ShopManagement.Application.Contracts.ProductPicture;

namespace ShopManagement.Domain.ProductPicture
{
    public interface IProductPictureRepository : IRepository<int, ProductPictureEntity>
    {
        EditProductPicture GetDetails(int id);
        List<ProductPictureViewModel> GetProductPictures();
        ProductPictureEntity GetWithProductANDCategory(int id);
    }
}
