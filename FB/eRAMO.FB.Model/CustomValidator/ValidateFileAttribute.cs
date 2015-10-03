using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace eRAMO.FB.Model.CustomValidator
{
    public class ValidateFileAttribute : ValidationAttribute
    {
        /// <summary>
        /// Write down File Extensions comma separated. 
        /// </summary>
        public string AllowedFileExtensions { get; set; }
        public override bool IsValid(object value)
        {
            int MaxContentLength = 1024 * 1024 * 3; //3 MB
            string[] allowedFileExtensions = AllowedFileExtensions.Trim().Split(',');

            HttpPostedFileBase file = value as HttpPostedFileBase;

            if (file == null)
                return true;
            else if (!allowedFileExtensions.Contains(file.FileName.Substring(file.FileName.LastIndexOf('.') + 1)))
            {
                ErrorMessage = "Please upload file of type: " + string.Join(", ", allowedFileExtensions);
                return false;
            }
            else if (file.ContentLength > MaxContentLength)
            {
                ErrorMessage = String.Format("Your Photo is too large, maximum allowed size is : {0}MB", MaxContentLength / 1024);
                return false;
            }
            else
                return true;
        }
    }
}
