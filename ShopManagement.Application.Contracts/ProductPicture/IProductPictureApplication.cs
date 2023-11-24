using System.Collections.Generic;
using _0_Framwork.Application;

namespace ShopManagement.Application.Contracts.ProductPicture
{
    public interface IProductPictureApplication
    {
        OperationResult Create(CreateProductPicture command);
        OperationResult Edit(EditProductPicture command);
        OperationResult Remove(int id);
        OperationResult Restore(int id);
        EditProductPicture GetDetails(int id);
        List<ProductPictureViewModel> GetProductPictures();
    }
}
