using System.Collections.Generic;
using _0_Framwork.Application;
using DiscountManagement.Application.Contracts.ColleagueDiscount;
using DiscountManagement.Domain.ColleagueDiscount;

namespace DiscountManagement.Application
{
    public class ColleagueDiscountApplication : IColleagueDiscountApplication
    {
        private readonly IColleagueDiscountRepository _colleagueDiscountRepository;

        public ColleagueDiscountApplication(IColleagueDiscountRepository colleagueDiscountRepository)
        {
            _colleagueDiscountRepository = colleagueDiscountRepository;
        }

        public OperationResult Create(CreateColleagueDiscount command)
        {
            var operation = new OperationResult();

            var colleagueDiscount = new ColleagueDiscountEntity(command.DiscountRate, command.ProductId);

            _colleagueDiscountRepository.Create(colleagueDiscount);
            _colleagueDiscountRepository.Save();

            return operation.Success();
        }

        public OperationResult Edit(EditColleagueDiscount command)
        {
            var operation = new OperationResult();

            var colleagueDiscount = _colleagueDiscountRepository.Get(command.Id);

            if (colleagueDiscount == null)
                return operation.Failed(ApplicationMessage.RecordNotFound);

            colleagueDiscount.Edit(command.DiscountRate, command.ProductId);

            _colleagueDiscountRepository.Save();
            return operation.Success();
        }

        public OperationResult Remove(int id)
        {
            var operation = new OperationResult();

            var colleagueDiscount = _colleagueDiscountRepository.Get(id);
            if (colleagueDiscount == null)
                return operation.Failed(ApplicationMessage.RecordNotFound);

            colleagueDiscount.Remove();

            _colleagueDiscountRepository.Save();
            return operation.Success();
        }

        public OperationResult Restore(int id)
        {
            var operation = new OperationResult();

            var colleagueDiscount = _colleagueDiscountRepository.Get(id);
            if (colleagueDiscount == null)
                return operation.Failed(ApplicationMessage.RecordNotFound);

            colleagueDiscount.Restore();

            _colleagueDiscountRepository.Save();
            return operation.Success();
        }

        public EditColleagueDiscount GetDetails(int id)
        {
            return _colleagueDiscountRepository.GetDetails(id);
        }

        public List<ColleagueDiscountViewModel> GetColleagueDiscounts()
        {
            return _colleagueDiscountRepository.GetColleagueDiscounts();
        }
    }
}
