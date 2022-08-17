using asp_store_bugeto.Application.Intefaces.Contexts;
using asp_store_bugeto.Common;
using System.Collections.Generic;
using System.Linq;

namespace asp_store_bugeto.Application.Services.Users.Queries.GetUsers
{
    public class GetUsersService : IGetUsersService
    {
        private readonly IDataBaseContext _context;
        public GetUsersService(IDataBaseContext context)
        {
            _context = context;
        }

        public ReslutGetUserDto Execute(RequestGetUserDto request)
        {
            var users = _context.Users.AsQueryable();
            if (!string.IsNullOrWhiteSpace(request.SearchKey))
            {
                users = users.Where(p => p.FullName.Contains(request.SearchKey) || p.Email.Contains(request.SearchKey));
            }
            int rowscount = 0;
            var userlist = users.ToPaged(request.Page, 20, out rowscount).Select(p => new GetUsersDto
            {
                Id = p.Id,
                Email = p.Email,
                FullName = p.FullName,
                IsActive = p.IsActive,
            }).ToList();
            return new ReslutGetUserDto { Rows = rowscount, Users = userlist };
        }
    }
}
