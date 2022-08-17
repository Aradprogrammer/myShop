using asp_store_bugeto.Application.Intefaces.Contexts;
using asp_store_bugeto.Common.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asp_store_bugeto.Application.Services.Emails.Commands.DeleteSenderEmail
{
    public interface IDeleteEmailSenderService
    {
        public ResultDto Execute(long Id);
    }
    public class DeleteEmailSenderService : IDeleteEmailSenderService
    {
        readonly private IDataBaseContext _context;
        public DeleteEmailSenderService(IDataBaseContext context)
        {
            _context = context;
        }

        public ResultDto Execute(long Id)
        {
            if (Id > 0)
            {
                var emails = _context.Emails.Where(p => p.SenderEmailId == Id).ToList();
                if (emails.Count > 0)
                {
                    return new() { IsSuccess = false, Message = "لطفا ارسال کننده های ایمیل های مرتبط را تغییر دهید ." };
                }
                var sender = _context.SenderEmails.Find(Id);

                sender.Removetime = DateTime.Now;
                sender.IsRemoved = true;
                
                _context.SaveChanges();
                return new() { IsSuccess = true, Message = "عملیات با موفقیت انحام شد." };
            }
            else
            {
                return new() { IsSuccess = false, Message = "ارسال کننده پیدا نشد." };
            }
        }
    }
}
