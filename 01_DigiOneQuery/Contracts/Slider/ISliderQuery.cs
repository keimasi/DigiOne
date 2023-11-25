using System.Collections.Generic;

namespace _01_DigiOneQuery.Contracts.Slider
{
    public interface ISliderQuery
    {
        List<SliderQueryModel> GetAll();
    }
}
