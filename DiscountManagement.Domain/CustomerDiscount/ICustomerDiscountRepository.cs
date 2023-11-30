using System.Collections.Generic;
using _0_Framwork.Domain;
using DiscountManagement.Application.Contracts.CustomerDiscount;

namespace DiscountManagement.Domain.CustomerDiscount
{
    public interface ICustomerDiscountRepository:IRepository<int,CustomerDiscountEntity>
    {
        EditCustomerDiscount GetDetails(int id);
        List<CustomerDiscountViewModel> GetCustomerDiscounts();
    }
}
