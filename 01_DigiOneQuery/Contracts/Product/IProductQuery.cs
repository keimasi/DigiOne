using System.Collections.Generic;

namespace _01_DigiOneQuery.Contracts.Product
{
    public interface IProductQuery
    {
        List<ProductQueryModel> Search(string value);
    }
}
