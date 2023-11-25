using System.Collections.Generic;
using System.Linq;
using _01_DigiOneQuery.Contracts.Slider;
using ShopManagement.Infrastructure.EFCore;

namespace _01_DigiOneQuery.Query
{
    public class SliderQuery:ISliderQuery
    {
        private readonly ShopContext _shopContext;

        public SliderQuery(ShopContext shopContext)
        {
            _shopContext = shopContext;
        }

        public List<SliderQueryModel> GetAll()
        {
            return _shopContext.Sliders.Where(x => x.IsRemove == false).Select(x => new SliderQueryModel
            {
                Picture = x.Picture,
                PictureAlt = x.PictureAlt,
                PictureTitle = x.PictureTitle,
                Link = x.Link,
            }).ToList();
        }
    }
}
