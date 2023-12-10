using System.Collections.Generic;
using _0_Framwork.Application;
using ShopManagement.Application.Contracts.ProductPicture;
using ShopManagement.Domain.Product;
using ShopManagement.Domain.ProductPicture;

namespace ShopManagement.Application
{
    public class ProductPictureApplication : IProductPictureApplication
    {
        private readonly IFileUpload _fileUpload;
        private readonly IProductRepository _productRepository;
        private readonly IProductPictureRepository _productPictureRepository;

        public ProductPictureApplication(IProductPictureRepository productPictureRepository, IProductRepository productRepository, IFileUpload fileUpload)
        {
            _productPictureRepository = productPictureRepository;
            _productRepository = productRepository;
            _fileUpload = fileUpload;
        }

        public OperationResult Create(CreateProductPicture command)
        {
            var operation = new OperationResult();

            var product = _productRepository.GetProductWithCategoryBy(command.ProductId);

            var picturePath = $"{product.Category.Slug}/{product.Slug}";
            var pictureName = _fileUpload.Upload(command.Picture, picturePath);

            var productPicture = new ProductPictureEntity(pictureName, command.PictureAlt, command.PictureTitle, command.ProductId);
            _productPictureRepository.Create(productPicture);
            _productPictureRepository.Save();
            return operation.Success();
        }

        public OperationResult Edit(EditProductPicture command)
        {
            var operation = new OperationResult();
            var productPicture = _productPictureRepository.GetWithProductANDCategory(command.Id);
            if (productPicture == null)
                return operation.Failed(ApplicationMessage.RecordNotFound);

            var picturePath = $"{productPicture.Product.Category.Slug}/{productPicture.Product.Slug}";
            var pictureName = _fileUpload.Upload(command.Picture, picturePath);

            productPicture.Edit(pictureName, command.PictureAlt, command.PictureTitle, command.ProductId);
            _productPictureRepository.Save();
            return operation.Success();
        }

        public OperationResult Remove(int id)
        {
            var operation = new OperationResult();
            var productPicture = _productPictureRepository.Get(id);
            if (productPicture == null)
                return operation.Failed(ApplicationMessage.RecordNotFound);

            productPicture.Remove();
            _productPictureRepository.Save();
            return operation.Success();
        }

        public OperationResult Restore(int id)
        {
            var operation = new OperationResult();
            var productPicture = _productPictureRepository.Get(id);
            if (productPicture == null)
                return operation.Failed(ApplicationMessage.RecordNotFound);

            productPicture.Restore();
            _productPictureRepository.Save();
            return operation.Success();
        }

        public EditProductPicture GetDetails(int id)
        {
            return _productPictureRepository.GetDetails(id);
        }

        public List<ProductPictureViewModel> GetProductPictures()
        {
            return _productPictureRepository.GetProductPictures();
        }
    }
}
