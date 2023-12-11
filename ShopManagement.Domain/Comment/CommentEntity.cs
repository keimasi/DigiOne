using _0_Framwork.Domain;
using ShopManagement.Domain.Product;

namespace ShopManagement.Domain.Comment
{
    public class CommentEntity : EntityBace
    {
        public string Name { get; private set; }
        public string Email { get; private set; }
        public string Message { get; private set; }
        public bool CommentStatus { get; private set; }
        public int ProductId { get; private set; }
        public ProductEntity Product { get; private set; }

        public CommentEntity(string name, string email, string message, int productId)
        {
            Name = name;
            Email = email;
            Message = message;
            ProductId = productId;
        }

        public void Confirm()
        {
            CommentStatus = true;
        }

        public void Cancel()
        {
            CommentStatus = false;
        }
    }
}
