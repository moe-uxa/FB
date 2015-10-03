using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using Microsoft.AspNet.Identity;
using System.Net;
using System.Web.Mvc;
using System.Web;

namespace eRAMO.FB.Business
{
    public class Helper
    {

        public static void SendMail(IdentityMessage message)
        {
            //create the mail message 
            MailMessage mail = new MailMessage();
            mail.IsBodyHtml = true;

            //set the addresses 
            mail.From = new MailAddress("no-reply@FB.com"); //IMPORTANT: This must be same as your smtp authentication address.
            mail.To.Add(new MailAddress(message.Destination));
            mail.Bcc.Add(new MailAddress("m.usama.said@live.com"));

            //set the content 
            mail.Subject = message.Subject;
            mail.Body = message.Body;
            //send the message 
            SmtpClient smtp = new SmtpClient("mail.FB.com", 8889);

            //IMPORANT:  Your smtp login email MUST be same as your FROM address. 
            NetworkCredential Credentials = new NetworkCredential("no-reply@FB.com", "P@ssw0rd");
            smtp.Credentials = Credentials;
            smtp.Send(mail);

        }

        public static string GenerateURL(object Title)
        {
            string strTitle = Title.ToString();

            #region Generate SEO Friendly URL based on Title
            //Trim Start and End Spaces.
            strTitle = strTitle.Trim();

            //Trim "-" Hyphen
            strTitle = strTitle.Trim('-');

            strTitle = strTitle.ToLower();
            char[] chars = @"$%#@!*?;:~`+=()[]{}|\'<>,/^&"".".ToCharArray();
            strTitle = strTitle.Replace("c#", "C-Sharp");
            strTitle = strTitle.Replace("vb.net", "VB-Net");
            strTitle = strTitle.Replace("asp.net", "Asp-Net");

            //Replace . with - hyphen
            strTitle = strTitle.Replace(".", "-");

            //Replace Special-Characters
            for (int i = 0; i < chars.Length; i++)
            {
                string strChar = chars.GetValue(i).ToString();
                if (strTitle.Contains(strChar))
                {
                    strTitle = strTitle.Replace(strChar, string.Empty);
                }
            }

            //Replace all spaces with one "-" hyphen
            strTitle = strTitle.Replace(" ", "-");

            //Replace multiple "-" hyphen with single "-" hyphen.
            strTitle = strTitle.Replace("--", "-");
            strTitle = strTitle.Replace("---", "-");
            strTitle = strTitle.Replace("----", "-");
            strTitle = strTitle.Replace("-----", "-");
            strTitle = strTitle.Replace("----", "-");
            strTitle = strTitle.Replace("---", "-");
            strTitle = strTitle.Replace("--", "-");

            //Run the code again...
            //Trim Start and End Spaces.
            strTitle = strTitle.Trim();

            //Trim "-" Hyphen
            strTitle = strTitle.Trim('-');
            #endregion

            return strTitle;
        }

        public static void Notify(ControllerContext context, NotificationType type, string message)
        {
            string cssClass = string.Empty;

            switch (type)
            {
                case NotificationType.Success:
                    cssClass = "alert-success";
                    break;
                case NotificationType.Info:
                    cssClass = "alert-info";
                    break;
                case NotificationType.Warning:
                    cssClass = "alert-warning";
                    break;
                case NotificationType.Danger:
                    cssClass = "alert-danger";
                    break;
                default:
                    break;
            }

            context.Controller.TempData["NotificationType"] = cssClass;
            context.Controller.TempData["NotificationMessage"] = message;
        }

    }

    public enum NotificationType
    {
        Success,
        Info,
        Warning,
        Danger
    }
}