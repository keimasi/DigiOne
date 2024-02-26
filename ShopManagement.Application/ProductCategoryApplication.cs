using _0_Framwork.Application;
using ShopManagement.Application.Contracts.ProductCategory;
using ShopManagement.Domain.ProductCategory;
using System.Collections.Generic;
using System.Linq;

namespace ShopManagement.Application
{
    public class ProductCategoryApplication : IProductCategoryApplication
    {
        private readonly IFileUpload _fileUpload;
        private readonly IProductCategoryRepository _productCategoryRepository;

        public ProductCategoryApplication(IProductCategoryRepository productCategoryRepository, IFileUpload fileUpload)
        {
            _productCategoryRepository = productCategoryRepository;
            _fileUpload = fileUpload;
        }

        public OperationResult Create(CreateProductCategory command)
        {
            var operation = new OperationResult();
            if (_productCategoryRepository.Exists(x => x.Name == command.Name))
                return operation.Failed(ApplicationMessage.DuplicatedRecord);

            var slug = command.Slug.GenerateSlug();

            var picturePath = $"{command.Slug}";
            var pictureName = _fileUpload.Upload(command.Picture, picturePath);

            var productCategory = new ProductCategoryEntity(command.Name, command.Description, pictureName,
                command.PictureAlt, command.PictureTitle, command.Keywords, command.MetaDescription, slug);

            _productCategoryRepository.Create(productCategory);
            _productCategoryRepository.Save();
            return operation.Success();
        }

        public OperationResult Edit(EditProductCategory command)
        {
            var operation = new OperationResult();
            var productCategory = _productCategoryRepository.Get(command.Id);

            if (productCategory == null)
                operation.Failed(ApplicationMessage.RecordNotFound);

            var slug = command.Slug.GenerateSlug();

            var picturePath = $"{command.Slug}";
            var pictureName = _fileUpload.Upload(command.Picture, picturePath);

            productCategory.Edit(command.Name, command.Description, pictureName,
                command.PictureAlt, command.PictureTitle, command.Keywords, command.MetaDescription, slug);
            _productCategoryRepository.Save();
            return operation.Success();
        }

        public List<ProductCategoryViewModel> GetProductCategories()
        {
            return _productCategoryRepository.GetAll().Select(x=>new ProductCategoryViewModel
            {
                Id = x.Id,
                Name = x.Name,
                Picture = x.Picture,
                CreateDate = x.CreateDate.ToFarsi(),
                ProductCount = 0
            }).ToList();
        }

        public EditProductCategory GetDetails(int id)
        {
            return _productCategoryRepository.GetDetails(id);
        }
    }
}
