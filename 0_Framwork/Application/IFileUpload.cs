using Microsoft.AspNetCore.Http;

namespace _0_Framwork.Application
{
    public interface IFileUpload
    {
        string Upload(IFormFile file, string path);
    }
}
