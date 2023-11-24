using System.Collections.Generic;
using _0_Framwork.Domain;
using ShopManagement.Application.Contracts.Product;

namespace ShopManagement.Domain.Product
{
    public interface IProductRepository : IRepository<int,ProductEntity>
    { 
        EditProduct GetDetails(int id);
        List<ProductViewModel> GetProducts();
    }
}
