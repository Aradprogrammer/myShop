using asp_store_bugeto.Common.Dto;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asp_store_bugeto.Application.Services.Users.Commands.RemoveUser
{
	public interface IRemoveUserService
    {
        ResultDto Execute(long UserId);
    }
}
