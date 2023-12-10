using System.Collections.Generic;
using _0_Framwork.Application;
using ShopManagement.Application.Contracts.Slider;
using ShopManagement.Domain.Slider;

namespace ShopManagement.Application
{
    public class SliderApplication : ISliderApplication
    {
        private readonly IFileUpload _fileUpload;
        private readonly ISliderRepository _sliderRepository;

        public SliderApplication(ISliderRepository sliderRepository, IFileUpload fileUpload)
        {
            _sliderRepository = sliderRepository;
            _fileUpload = fileUpload;
        }

        public OperationResult Create(CreateSlider command)
        {
            var operation = new OperationResult();

            var pictureName = _fileUpload.Upload(command.Picture,"Sliders");

            var slider = new SliderEntity(pictureName, command.PictureAlt, command.PictureTitle, command.Link, command.Description);
            _sliderRepository.Create(slider);
            _sliderRepository.Save();
            return operation.Success();
        }

        public OperationResult Edit(EditSlider command)
        {
            var operation = new OperationResult();
            var Slider = _sliderRepository.Get(command.Id);
            if (Slider == null)
                return operation.Failed(ApplicationMessage.RecordNotFound);

            var pictureName = _fileUpload.Upload(command.Picture,"Sliders");

            Slider.Edit(pictureName, command.PictureAlt, command.PictureTitle, command.Link, command.Description);
            _sliderRepository.Save();
            return operation.Success();
        }

        public OperationResult Remove(int id)
        {
            var operation = new OperationResult();
            var Slider = _sliderRepository.Get(id);
            if (Slider == null)
                return operation.Failed(ApplicationMessage.RecordNotFound);

            Slider.Remove();
            _sliderRepository.Save();
            return operation.Success();
        }

        public OperationResult Restore(int id)
        {
            var operation = new OperationResult();
            var Slider = _sliderRepository.Get(id);
            if (Slider == null)
                return operation.Failed(ApplicationMessage.RecordNotFound);

            Slider.Restore();
            _sliderRepository.Save();
            return operation.Success();
        }

        public List<SliderViewModel> GetSliders()
        {
            return _sliderRepository.GetList();
        }

        public EditSlider GetDetails(int id)
        {
            return _sliderRepository.GetDetails(id);
        }
    }
}
