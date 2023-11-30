using System.Collections.Generic;
using _0_Framwork.Domain;
using DiscountManagement.Application.Contracts.ColleagueDiscount;

namespace DiscountManagement.Domain.ColleagueDiscount
{
    public interface IColleagueDiscountRepository : IRepository<int, ColleagueDiscountEntity>
    {
        EditColleagueDiscount GetDetails(int id);
        List<ColleagueDiscountViewModel> GetColleagueDiscounts();
    }
}
