using System.Collections.Generic;
using _0_Framwork.Domain;
using ShopManagement.Application.Contracts.Comment;

namespace ShopManagement.Domain.Comment
{
    public interface ICommentRepository : IRepository<int, CommentEntity>
    {
        List<CommentViewModel> GetComments();
    }
}
