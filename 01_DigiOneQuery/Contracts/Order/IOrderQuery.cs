using System.Collections.Generic;

namespace _01_DigiOneQuery.Contracts.Order
{
    public interface IOrderQuery
    {
        List<BestSellingProductsQueryModel> GetBestSellingProducts();
    }
}
