using System.Collections.Generic;
using _0_Framwork.Application;

namespace DiscountManagement.Application.Contracts.CustomerDiscount
{
    public interface ICustomerDiscountApplication
    {
        OperationResult Create(CreateCustomerDiscount command);
        OperationResult Edit(EditCustomerDiscount command);
        EditCustomerDiscount GetDetails(int id);
        List<CustomerDiscountViewModel> GetCustomerDiscounts();
    }
}