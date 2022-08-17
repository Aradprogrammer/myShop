using asp_store_bugeto.Application.Intefaces.Contexts;
using asp_store_bugeto.Common.Dto;

namespace asp_store_bugeto.Application.Services.Users.Commands.ChangeUserState
{
    public class ChangeUserStateService : IChangeUserStateService
    {
        private readonly IDataBaseContext _context;
        public ChangeUserStateService(IDataBaseContext context)
        {
            _context = context;
        }
        public ResultDto Execut(long UserId)
        {
            var user = _context.Users.Find(UserId);
            if (user == null)
            {
                return new ResultDto() { IsSuccess = false, Message = "کاربر مورد نظر یافت نشد" };
            }
            else
            {
                if (user.IsRemoved == true)
                {
                    return new ResultDto() { IsSuccess = false, Message = "کاربر مورد نظر یافت نشد" };
                }
                else
                {
                    user.IsActive = !user.IsActive;
                    _context.SaveChanges();
                    return new ResultDto() { IsSuccess = true, Message = " کاربر با موفقیت" + (user.IsActive ? " فعال " : " غیر فعال ") + "شد" };
                }
            }
            
        }
    
        
    }
}
