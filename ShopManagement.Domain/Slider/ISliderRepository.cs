using System.Collections.Generic;
using _0_Framwork.Domain;
using ShopManagement.Application.Contracts.Slider;

namespace ShopManagement.Domain.Slider
{
    public interface ISliderRepository:IRepository<int,SliderEntity>
    {
        EditSlider GetDetails(int id);
        List<SliderViewModel> GetList();
    }
}
