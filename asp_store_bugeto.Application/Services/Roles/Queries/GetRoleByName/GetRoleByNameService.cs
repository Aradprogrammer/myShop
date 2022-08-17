using asp_store_bugeto.Application.Intefaces.Contexts;
using asp_store_bugeto.Application.Services.Users.Queries.GetRoles;
using asp_store_bugeto.Common.Dto;
using System.Linq;

namespace asp_store_bugeto.Application.Services.Roles.GetRoleByName
{
    public class GetRoleByNameService : IGetRoleByNameService
    {
        private readonly IDataBaseContext _context;
        public GetRoleByNameService(IDataBaseContext context)
        {
            _context = context;
        }
        public ResultDto<RolesDto> Execut(string RoleName)
        {
            var result = _context.Roles.First(x => x.Name == RoleName);
            if (result == null)
            {
                return new ResultDto<RolesDto>() { IsSuccess = false, Message = "نقش مورد نظر پیدا نشد.", Data = new RolesDto() { Id = 0, Name = "" } };
            }
            else
            {
                return new ResultDto<RolesDto>() { IsSuccess = true, Message = "نقش مورد نظر با موفقیت پیدا شد..", Data = new RolesDto() { Id = result.Id, Name = result.Name } };
            }
        }
    }

}
