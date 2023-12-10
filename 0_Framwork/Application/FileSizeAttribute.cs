using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace _0_Framwork.Application
{
    public class FileSizeAttribute : ValidationAttribute, IClientModelValidator
    {
        private readonly long _maxFileSize;

        public FileSizeAttribute(long maxFileSize)
        {
            _maxFileSize = maxFileSize * 1024 * 1024;
        }

        public override bool IsValid(object value)
        {
            if (value is not IFormFile file)
                return true;

            return file.Length <= _maxFileSize;
        }

        public void AddValidation(ClientModelValidationContext context)
        {
            context.Attributes.Add("data-val","true");
            context.Attributes.Add("data-val-maxFileSize",ErrorMessage);
        }
    }
}
