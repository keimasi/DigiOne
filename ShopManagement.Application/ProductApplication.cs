using System.Collections.Generic;
using _0_Framwork.Application;
using ShopManagement.Application.Contracts.Product;
using ShopManagement.Domain.Product;
using ShopManagement.Domain.ProductCategory;

namespace ShopManagement.Application
{
    public class ProductApplication : IProductApplication
    {
        private readonly IFileUpload _fileUpload;
        private readonly IProductRepository _productRepository;
        private readonly IProductCategoryRepository _productCategoryRepository;

        public ProductApplication(IProductRepository productRepository, IFileUpload fileUpload, IProductCategoryRepository productCategoryRepository)
        {
            _productRepository = productRepository;
            _fileUpload = fileUpload;
            _productCategoryRepository = productCategoryRepository;
        }

        public OperationResult Create(CreateProduct command)
        {
            var operation = new OperationResult();
            if (_productRepository.Exists(x => x.Name == command.Name))
                return operation.Failed(ApplicationMessage.DuplicatedRecord);

            var slug = command.Slug.GenerateSlug();

            var categorySlug = _productCategoryRepository.GetCategorySlugBy(command.CategoryId);
            var picturePath = $"{categorySlug}/{slug}";
            var pictureName = _fileUpload.Upload(command.Picture, picturePath);

            var product = new ProductEntity(command.Name, command.Code, command.ShortDescription, command.Description,
                pictureName, command.PictureAlt, command.PictureTitle, slug,
                command.Keywords, command.MetaDescription, command.CategoryId);

            _productRepository.Create(product);
            _productRepository.Save();

            return operation.Success();
        }

        public OperationResult Edit(EditProduct command)
        {
            var operation = new OperationResult();
            var product = _productRepository.GetProductWithCategoryBy(command.Id);

            if (product == null)
                return operation.Failed(ApplicationMessage.RecordNotFound);

            if (_productRepository.Exists(x => x.Name == command.Name && x.Id != command.Id))
                return operation.Failed(ApplicationMessage.DuplicatedRecord);

            var slug = command.Slug.GenerateSlug();

            var picturePath = $"{product.Category.Slug}/{slug}";
            var pictureName = _fileUpload.Upload(command.Picture, picturePath);

            product.Edit(command.Name, command.Code, command.ShortDescription, command.Description,
                pictureName, command.PictureAlt, command.PictureTitle, slug,
                command.Keywords, command.MetaDescription, command.CategoryId);

            _productRepository.Save();
            return operation.Success();
        }

        public EditProduct GetDetails(int id)
        {
            return _productRepository.GetDetails(id);
        }

        public List<ProductViewModel> GetProducts()
        {
            return _productRepository.GetProducts();
        }
    }
}
