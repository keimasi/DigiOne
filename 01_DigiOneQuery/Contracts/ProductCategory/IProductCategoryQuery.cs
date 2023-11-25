using System.Collections.Generic;

namespace _01_DigiOneQuery.Contracts.ProductCategory
{
    public interface IProductCategoryQuery
    {
        List<ProductCategoryQueryModel> GetAll();
    }
}
