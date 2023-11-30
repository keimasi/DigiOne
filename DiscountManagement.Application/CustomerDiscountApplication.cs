using System.Collections.Generic;
using _0_Framwork.Application;
using DiscountManagement.Application.Contracts.CustomerDiscount;
using DiscountManagement.Domain.CustomerDiscount;

namespace DiscountManagement.Application
{
    public class CustomerDiscountApplication : ICustomerDiscountApplication
    {
        private readonly ICustomerDiscountRepository _customerDiscountRepository;

        public CustomerDiscountApplication(ICustomerDiscountRepository customerDiscountRepository)
        {
            _customerDiscountRepository = customerDiscountRepository;
        }

        public OperationResult Create(CreateCustomerDiscount command)
        {
            var operation = new OperationResult();
            var startDate = command.StartDate.ToGeorgianDateTime();
            var endDate = command.EndDate.ToGeorgianDateTime();
            var customerDiscount = new CustomerDiscountEntity(command.DiscountRate, startDate, endDate, command.Description, command.ProductId);
            _customerDiscountRepository.Create(customerDiscount);
            _customerDiscountRepository.Save();
            return operation.Success();
        }

        public OperationResult Edit(EditCustomerDiscount command)
        {
            var operation = new OperationResult();
            var customerDiscount = _customerDiscountRepository.Get(command.Id);
            if (customerDiscount == null)
                return operation.Failed(ApplicationMessage.RecordNotFound);

            var startDate = command.StartDate.ToGeorgianDateTime();
            var endDate = command.EndDate.ToGeorgianDateTime();
            customerDiscount.Edit(command.DiscountRate, startDate, endDate, command.Description, command.ProductId);
            _customerDiscountRepository.Save();
            return operation.Success();
        }

        public EditCustomerDiscount GetDetails(int id)
        {
            return _customerDiscountRepository.GetDetails(id);
        }

        public List<CustomerDiscountViewModel> GetCustomerDiscounts()
        {
            return _customerDiscountRepository.GetCustomerDiscounts();
        }
    }
}
