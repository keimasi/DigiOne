using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using _0_Framwork.Application;
using ShopManagement.Application.Contracts.Product;
using ShopManagement.Domain.Product;

namespace ShopManagement.Application
{
    public class ProductApplication : IProductApplication
    {
        private readonly IProductRepository _productRepository;

        public ProductApplication(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public OperationResult Create(CreateProduct command)
        {
            var operation = new OperationResult();
            if (_productRepository.Exists(x => x.Name == command.Name))
                return operation.Failed(ApplicationMessage.DuplicatedRecord);

            var slug = command.Slug.GenerateSlug();
            var product = new ProductEntity(command.Name, command.Code, command.ShortDescription, command.Description,
                command.Picture, command.PictureAlt, command.PictureTitle, slug,
                command.Keywords, command.MetaDescription, command.CategoryId);

            _productRepository.Create(product);
            _productRepository.Save();

            return operation.Success();
        }

        public OperationResult Edit(EditProduct command)
        {
            var operation = new OperationResult();
            var product = _productRepository.Get(command.Id);

            if (product == null)
                return operation.Failed(ApplicationMessage.RecordNotFound);

            if (_productRepository.Exists(x => x.Name == command.Name && x.Id != command.Id))
                return operation.Failed(ApplicationMessage.DuplicatedRecord);

            var slug = command.Slug.GenerateSlug();
            product.Edit(command.Name, command.Code, command.ShortDescription, command.Description,
                command.Picture, command.PictureAlt, command.PictureTitle, slug,
                command.Keywords, command.MetaDescription, command.CategoryId);

            _productRepository.Save();
            return operation.Success();
        }

        public OperationResult InStock(int id)
        {
            var operation = new OperationResult();
            var product = _productRepository.Get(id);

            if (product == null)
                return operation.Failed(ApplicationMessage.RecordNotFound);

            product.InStock();
            _productRepository.Save();
            return operation.Success();
        }

        public OperationResult NotInStock(int id)
        {
            var operation = new OperationResult();
            var product = _productRepository.Get(id);

            if (product == null)
                return operation.Failed(ApplicationMessage.RecordNotFound);

            product.NotInStock();
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
