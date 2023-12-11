using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ShopManagement.Application.Contracts.Comment;

namespace ServiceHost.Areas.Administrator.Pages.Shop.Commnet
{
    public class IndexModel : PageModel
    {
        [TempData]
        public string Message { get; set; }
        public List<CommentViewModel> Comment;

        private readonly ICommentApplication _commentApplication;

        public IndexModel(ICommentApplication commentApplication)
        {
            _commentApplication = commentApplication;
        }

        public void OnGet()
        {
            Comment = _commentApplication.GetComments();
        }

        public RedirectToPageResult OnGetConfirm(int id)
        {
            var result = _commentApplication.Confirm(id);
            if (result.IsSuccess)
                return RedirectToPage("./Index");
            Message = result.Message;
            return RedirectToPage("./Index");
        }

        public RedirectToPageResult OnGetCancel(int id)
        {
            var result = _commentApplication.Cancel(id);
            if (result.IsSuccess)
                return RedirectToPage("./Index");
            Message = result.Message;
            return RedirectToPage("./Index");
        }
    }
}
