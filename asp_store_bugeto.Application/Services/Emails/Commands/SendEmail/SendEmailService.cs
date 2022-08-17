using asp_store_bugeto.Application.Intefaces.Contexts;
using asp_store_bugeto.Common.Dto;
using asp_store_bugeto.Common;
using Microsoft.AspNetCore.Mvc.Routing;
using System;
using System.Linq;

namespace asp_store_bugeto.Application.Services.Emails.Commands.SendEmail
{
    public class SendEmailService : ISendEmailService
    {
        private readonly IDataBaseContext _context;
        public SendEmailService(IDataBaseContext context)
        {
            _context = context;
        }

        private ResultUserApprovalsDto UserApprovals(string email)
        {
            var user = _context.Users.Where(p => p.Email == email).FirstOrDefault();
            if (user == null)
            {
                return new ResultUserApprovalsDto() { UserExistence = false, UserIsActive = false };
            }
            return new ResultUserApprovalsDto()
            {
                UserExistence = true,
                UserIsActive = user.IsActive,
                user = user
            };
        }
        private bool Sending_email(string HostName, string Email, string subject, string content = "")
        {
            var email = _context.Emails.Where(p => p.Subject == subject).FirstOrDefault();
            var sender = _context.SenderEmails.Where(p => p.Id == email.SenderEmailId).FirstOrDefault();
            if (sender != null)
            {
                string body = "";
                var token = Guid.NewGuid().ToString();
                string Link = "https://" + HostName + "/" + email.URL + "?key=" + token;
                try
                {
                    body = EmailTextAnalyzer.Analyz(email.Text, new() { Email = Email, FullName = "" }, Link, content);
                    var emailsend = new Email();
                    var result = emailsend.Send(sender.AddressEmail, sender.Password, email.Titel, Email, email.Subject, body);
                    if (result.IsSuccess)
                    {
                        _context.Temps.Add(new() { InsertTime = DateTime.Now, Key = token, Value = Email, Description = subject });
                        _context.SentEmails.Add(new() { SendingTime = DateTime.Now, Subject = subject, UserEmail = Email });
                        _context.SaveChanges();
                        return true;
                    }
                    else
                    {
                        throw new Exception(result.Message);
                    }
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public ResultDto Execute(string Email, string subject, string host, string content = "")
        {
            var approvals = UserApprovals(Email);
            if (approvals.UserExistence)
            {

                if (approvals.UserIsActive)
                {
                    if (subject.Contains("تایید ایمیل"))
                    {
                        return new() { IsSuccess = false, Message = "این ایمیل قبلا استفاده شده." };
                    }
                    if (string.IsNullOrEmpty(content))
                    {
                        if (Sending_email(host, Email, subject))
                        {
                            return new() { IsSuccess = true, Message = "ایمیل ارسال شد." };

                        }
                        else
                        {
                            return new() { IsSuccess = false, Message = "ایمیل ارسال نشد." };
                        }
                    }
                    else
                    {
                        if (Sending_email(host, Email, subject, content))
                        {
                            return new() { IsSuccess = true, Message = "ایمیل ارسال شد." };

                        }
                        else
                        {
                            return new() { IsSuccess = false, Message = "ایمیل ارسال نشد." };
                        }
                    }
                }
                else
                {
                    if (subject.Contains("تایید ایمیل"))
                    {
                        if (Sending_email(host, Email, subject))
                        {
                            return new() { IsSuccess = true, Message = "ایمیل ارسال شد." };

                        }
                        else
                        {
                            return new() { IsSuccess = false, Message = "ایمیل ارسال نشد." };
                        }
                    }
                    else
                    {
                        return new() { IsSuccess = false, Message = "حساب شما تایید نشده است یا به دلایلی غیر فعال شده است." };
                    }
                }
            }
            else
            {
                return new ResultDto()
                {
                    IsSuccess = false,
                    Message = "ایمیل ارسال شد."
                };
            }
        }
    }
}
