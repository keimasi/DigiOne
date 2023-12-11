using System.Collections.Generic;
using _0_Framwork.Application;

namespace ShopManagement.Application.Contracts.Comment
{
    public interface ICommentApplication
    {
        OperationResult Add(AddComment command);
        OperationResult Confirm(int id);
        OperationResult Cancel(int id);
        List<CommentViewModel> GetComments();
    }
}