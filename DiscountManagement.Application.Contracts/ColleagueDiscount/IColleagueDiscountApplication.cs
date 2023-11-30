using System.Collections.Generic;
using _0_Framwork.Application;

namespace DiscountManagement.Application.Contracts.ColleagueDiscount
{
    public interface IColleagueDiscountApplication
    {
        OperationResult Create(CreateColleagueDiscount command);
        OperationResult Edit(EditColleagueDiscount command);
        OperationResult Remove(int id);
        OperationResult Restore(int id);
        EditColleagueDiscount GetDetails(int id);
        List<ColleagueDiscountViewModel> GetColleagueDiscounts();
    }
}