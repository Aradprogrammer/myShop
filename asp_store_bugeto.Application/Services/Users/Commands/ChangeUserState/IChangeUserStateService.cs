using asp_store_bugeto.Domain;
using asp_store_bugeto.Common.Dto;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asp_store_bugeto.Application.Services.Users.Commands.ChangeUserState
{
    public interface IChangeUserStateService
    {
        ResultDto Execut(long UserId);
    }
}
