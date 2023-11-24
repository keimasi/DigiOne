using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ShopManagement.Application.Contracts.Slider;

namespace ServiceHost.Areas.Administrator.Pages.Shop.slider
{
    public class IndexModel : PageModel
    {
        [TempData]
        public string Message { get; set; }
        public List<SliderViewModel> Sliders;

        private readonly ISliderApplication _sliderApplication;

        public IndexModel(ISliderApplication sliderApplication)
        {
            _sliderApplication = sliderApplication;
        }

        public void OnGet()
        {
            Sliders = _sliderApplication.GetSliders();
        }

        public IActionResult OnGetCreate()
        {
            var command = new CreateSlider();
            return Partial("./Create",command);
        }

        public JsonResult OnPostCreate(CreateSlider command)
        {
            var result = _sliderApplication.Create(command);
            return new JsonResult(result);
        }

        public IActionResult OnGetEdit(int id)
        {
            var slider = _sliderApplication.GetDetails(id);
            return Partial("Edit", slider);
        }

        public JsonResult OnPostEdit(EditSlider command)
        {
            var result = _sliderApplication.Edit(command);
            return new JsonResult(result);
        }

        public RedirectToPageResult OnGetRemove(int id)
        {
            var result = _sliderApplication.Remove(id);
            if (result.IsSuccess)
                return RedirectToPage("./Index");
            Message = result.Message;
            return RedirectToPage("./Index");
        }

        public RedirectToPageResult OnGetRestore(int id)
        {
            var result = _sliderApplication.Restore(id);
            if (result.IsSuccess)
                return RedirectToPage("./Index");
            Message = result.Message;
            return RedirectToPage("./Index");
        }
    }
}
