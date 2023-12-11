using System.Collections.Generic;
using _0_Framwork.Application;
using ShopManagement.Application.Contracts.Comment;
using ShopManagement.Domain.Comment;

namespace ShopManagement.Application
{
    public class CommentApplication:ICommentApplication
    {
        private readonly ICommentRepository _commentRepository;

        public CommentApplication(ICommentRepository commentRepository)
        {
            _commentRepository = commentRepository;
        }

        public OperationResult Add(AddComment command)
        {
            var operation=new OperationResult();

            var comment = new CommentEntity(command.Name, command.Email, command.Message, command.ProductId);

            _commentRepository.Create(comment);
            _commentRepository.Save();
            return operation.Success();
        }

        public OperationResult Confirm(int id)
        {
            var operation=new OperationResult();
            var comment = _commentRepository.Get(id);
            if (comment == null)
                return operation.Failed(ApplicationMessage.RecordNotFound);

            comment.Confirm();
            _commentRepository.Save();
            return operation.Success();
        }

        public OperationResult Cancel(int id)
        {
            var operation=new OperationResult();
            var comment = _commentRepository.Get(id);
            if (comment == null)
                return operation.Failed(ApplicationMessage.RecordNotFound);

            comment.Cancel();
            _commentRepository.Save();
            return operation.Success();
        }

        public List<CommentViewModel> GetComments()
        {
            return _commentRepository.GetComments();
        }
    }
}
