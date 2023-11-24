using _0_Framwork.Domain;
using ShopManagement.Domain.ProductCategory;

namespace ShopManagement.Domain.Product
{
    public class ProductEntity : EntityBace
    {
        public string Name { get; private set; }
        public string Code { get; private set; }
        public double UnitPrice { get; private set; }
        public bool IsInStock { get; private set; }
        public string ShortDescription { get; private set; }
        public string Description { get; private set; }
        public string Picture { get; private set; }
        public string PictureAlt { get; private set; }
        public string PictureTitle { get; private set; }
        public string Slug { get; private set; }
        public string Keywords { get; private set; }
        public string MetaDescription { get; private set; }
        public int CategoryId { get; private set; }
        public ProductCategoryEntity Category { get; private set; }

        public ProductEntity(string name, string code, string shortDescription, string description,
            string picture, string pictureAlt, string pictureTitle, string slug, string keywords,
            string metaDescription, int categoryId, double unitPrice)
        {
            Name = name;
            Code = code;
            ShortDescription = shortDescription;
            Description = description;
            Picture = picture;
            PictureAlt = pictureAlt;
            PictureTitle = pictureTitle;
            Slug = slug;
            Keywords = keywords;
            MetaDescription = metaDescription;
            CategoryId = categoryId;
            UnitPrice = unitPrice;
            IsInStock = true;
        }

        public void Edit(string name, string code, string shortDescription, string description,
            string picture, string pictureAlt, string pictureTitle, string slug, string keywords,
            string metaDescription, int categoryId, double unitPrice)
        {
            Name = name;
            Code = code;
            ShortDescription = shortDescription;
            Description = description;
            Picture = picture;
            PictureAlt = pictureAlt;
            PictureTitle = pictureTitle;
            Slug = slug;
            Keywords = keywords;
            MetaDescription = metaDescription;
            UnitPrice = unitPrice;
            CategoryId = categoryId;
        }

        public void InStock()
        {
            IsInStock = true;
        }

        public void NotInStock()
        {
            IsInStock = false;
        }
    }
}
