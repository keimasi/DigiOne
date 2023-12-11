using System.Collections.Generic;
using _0_Framwork.Domain;
using ShopManagement.Domain.Comment;
using ShopManagement.Domain.ProductCategory;
using ShopManagement.Domain.ProductPicture;

namespace ShopManagement.Domain.Product
{
    public class ProductEntity : EntityBace
    {
        public string Name { get; private set; }
        public string Code { get; private set; }
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
        public List<ProductPictureEntity> ProductPicture { get; private set; }
        public List<CommentEntity> Comments { get; private set; }

        public ProductEntity(string name, string code, string shortDescription, string description,
            string picture, string pictureAlt, string pictureTitle, string slug, string keywords,
            string metaDescription, int categoryId)
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
        }

        public void Edit(string name, string code, string shortDescription, string description,
            string picture, string pictureAlt, string pictureTitle, string slug, string keywords,
            string metaDescription, int categoryId)
        {
            Name = name;
            Code = code;
            ShortDescription = shortDescription;
            Description = description;

            if(!string.IsNullOrWhiteSpace(picture))
                Picture = picture;

            PictureAlt = pictureAlt;
            PictureTitle = pictureTitle;
            Slug = slug;
            Keywords = keywords;
            MetaDescription = metaDescription;
            CategoryId = categoryId;
        }
    }
}
