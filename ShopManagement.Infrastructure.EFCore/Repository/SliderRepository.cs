using System.Collections.Generic;
using System.Linq;
using _0_Framwork.Application;
using _0_Framwork.Infrastructure;
using ShopManagement.Application.Contracts.Slider;
using ShopManagement.Domain.Slider;

namespace ShopManagement.Infrastructure.EFCore.Repository
{
    public class SliderRepository:RepositoryBace<int,SliderEntity>, ISliderRepository
    {
        private readonly ShopContext _context;

        public SliderRepository(ShopContext context) : base(context)
        {
            _context = context;
        }

        public EditSlider GetDetails(int id)
        {
            return _context.Sliders.Select(x => new EditSlider
            {
                PictureAlt = x.PictureAlt,
                PictureTitle = x.PictureTitle,
                Link = x.Link,
                Id = x.Id,
                Description = x.Description,
            }).FirstOrDefault(x => x.Id == id);
        }

        public List<SliderViewModel> GetList()
        {
            return _context.Sliders.Select(x=>new SliderViewModel
            {
                Description = x.Description,
                CreateDate = x.CreateDate.ToFarsi(),
                IsRemove = x.IsRemove,
                Id = x.Id,
                Link = x.Link,
                Picture = x.Picture,
            }).ToList();
        }
    }
}
