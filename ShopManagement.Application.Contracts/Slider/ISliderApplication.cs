using System.Collections.Generic;
using _0_Framwork.Application;

namespace ShopManagement.Application.Contracts.Slider
{
    public interface ISliderApplication
    {
        OperationResult Create(CreateSlider command);
        OperationResult Edit(EditSlider command);
        OperationResult Remove(int id);
        OperationResult Restore(int id);
        List<SliderViewModel> GetSliders();
        EditSlider GetDetails(int id);
    }
}