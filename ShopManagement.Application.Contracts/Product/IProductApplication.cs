using _0_Framwork.Application;
using ShopManagement.Application.Contracts.ProductCategory;
using System.Collections.Generic;

namespace ShopManagement.Application.Contracts.Product
{
    public interface IProductApplication
    {
        OperationResult Create(CreateProduct command);
        OperationResult Edit(EditProduct command);
        OperationResult InStock(int id);
        OperationResult NotInStock(int id);
        EditProduct GetDetails(int id);
        List<ProductViewModel> GetProducts();
    }
}
