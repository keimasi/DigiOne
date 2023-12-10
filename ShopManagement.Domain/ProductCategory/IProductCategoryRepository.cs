using ShopManagement.Application.Contracts.ProductCategory;
using _0_Framwork.Domain;

namespace ShopManagement.Domain.ProductCategory
{
    public interface IProductCategoryRepository : IRepository<int,ProductCategoryEntity>
    {
        EditProductCategory GetDetails(int id);
        string GetCategorySlugBy(int id);
    }
}
