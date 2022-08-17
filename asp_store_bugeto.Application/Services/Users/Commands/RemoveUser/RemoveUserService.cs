using asp_store_bugeto.Application.Intefaces.Contexts;
using asp_store_bugeto.Common.Dto;
using System;

namespace asp_store_bugeto.Application.Services.Users.Commands.RemoveUser
{
	public class RemoveUserService : IRemoveUserService
    {
        private readonly IDataBaseContext _context;
        public RemoveUserService(IDataBaseContext context)
        {
            _context = context;
        }

        public ResultDto Execute(long UserId)
        {
            var user = _context.Users.Find(UserId);
            if (user == null)
            {
                return new ResultDto() { IsSuccess = false, Message = "کاربر یافت نشد" };
            }
            else
            {
                user.Removetime = DateTime.Now;
                user.IsRemoved = true;
                _context.SaveChanges();
                return new ResultDto() { IsSuccess = true, Message = "کاربر با موفقیت حذف شد" };

            }
        }
    }
}
