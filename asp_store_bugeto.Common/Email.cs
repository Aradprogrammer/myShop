using asp_store_bugeto.Common.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace asp_store_bugeto.Common
{
    public class Email
    {
        public ResultDto Send(string From, string FromPassword, string DisplayName, string to, string subject, string body)
        {
            MailMessage Mail = new() { From = new MailAddress(From, DisplayName), Subject = subject, Body = body, IsBodyHtml = true };
            Mail.To.Add(to);
            Mail.IsBodyHtml = true;
            Mail.BodyEncoding = UTF8Encoding.UTF8;
            Mail.DeliveryNotificationOptions = DeliveryNotificationOptions.OnSuccess;
            SmtpClient SmtpClient = new();
            SmtpClient.EnableSsl = true;
            SmtpClient.Port = 587;
            SmtpClient.Host = "smtp.gmail.com";
            SmtpClient.Timeout = 60000;
            SmtpClient.UseDefaultCredentials = false;
            SmtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
            SmtpClient.Credentials = new NetworkCredential(From, FromPassword);
            try
            {
                SmtpClient.Send(Mail);
                return new ResultDto() { IsSuccess = true, Message = "ایمیل با موفقیت ارسال شد." };
            }
            catch (Exception ex)
            {
                return new ResultDto() { IsSuccess = false , Message = ex.Message };    
            }
        }
    }
}
