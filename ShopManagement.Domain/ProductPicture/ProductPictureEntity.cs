using _0_Framwork.Domain;
using ShopManagement.Domain.Product;

namespace ShopManagement.Domain.ProductPicture
{
    public class ProductPictureEntity : EntityBace
    {
        public string Picture { get; private set; }
        public string PictureAlt { get; private set; }
        public string PictureTitle { get; private set; }
        public bool IsRemove { get; private set; }
        public int ProductId { get; private set; }
        public ProductEntity Product { get; private set; }

        public ProductPictureEntity(string picture, string pictureAlt, string pictureTitle, int productId)
        {
            Picture = picture;
            PictureAlt = pictureAlt;
            PictureTitle = pictureTitle;
            ProductId = productId;
            IsRemove = false;
        }

        public void Edit(string picture, string pictureAlt, string pictureTitle, int productId)
        {
            if(!string.IsNullOrWhiteSpace(picture))
                Picture = picture;

            PictureAlt = pictureAlt;
            PictureTitle = pictureTitle;
            ProductId = productId;
        }

        public void Remove()
        {
            IsRemove = true;
        }

        public void Restore()
        {
            IsRemove = false;
        }
    }
}
