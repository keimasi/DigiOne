using System.Collections.Generic;
using System.Linq;
using _0_Framwork.Application;
using _0_Framwork.Infrastructure;
using ShopManagement.Application.Contracts.Comment;
using ShopManagement.Domain.Comment;

namespace ShopManagement.Infrastructure.EFCore.Repository
{
    public class CommentRepository : RepositoryBace<int, CommentEntity>, ICommentRepository
    {
        private readonly ShopContext _context;

        public CommentRepository(ShopContext context) : base(context)
        {
            _context = context;
        }

        public List<CommentViewModel> GetComments()
        {
            return _context.Comments.Select(x => new CommentViewModel
            {
                Id = x.Id,
                Name = x.Name,
                Email = x.Email,
                Message = x.Message,
                ProductId = x.ProductId,
                ProductName = x.Product.Name,
                CommentStatus = x.CommentStatus,
                CreateDate = x.CreateDate.ToFarsi(),
            }).ToList();
        }
    }
}
