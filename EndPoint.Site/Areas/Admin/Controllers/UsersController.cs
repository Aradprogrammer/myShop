using asp_store_bugeto.Application.Services.Users.Commands.ChangeUserState;
using asp_store_bugeto.Application.Services.Users.Commands.EditeUser;
using asp_store_bugeto.Application.Services.Users.Commands.RegisterUsers;
using asp_store_bugeto.Application.Services.Users.Commands.RemoveUser;
using asp_store_bugeto.Application.Services.Users.Queries.GetRoles;
using asp_store_bugeto.Application.Services.Users.Queries.GetUsers;
using asp_store_bugeto.Common.Dto;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;

namespace EndPoint.Site.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class UsersController : Controller
    {
        private readonly IGetUsersService _getUsersService;
        private readonly IGetRolesService _getRolesService;
        private readonly IRegisterUsersService _registerUsersService;
        private readonly IRemoveUserService _removeUserService;
        private readonly IChangeUserStateService _changeUserStateService;
        private readonly IEditeUserService _editeUserService;


        public UsersController(IGetUsersService getUsersService, IGetRolesService getRolesService, IRegisterUsersService registerUsersService, IRemoveUserService removeUserService, IChangeUserStateService changeUserStateService, IEditeUserService editeUserService)
        {
            _getUsersService = getUsersService;
            _getRolesService = getRolesService;
            _registerUsersService = registerUsersService;
            _removeUserService = removeUserService;
            _changeUserStateService = changeUserStateService;
            _editeUserService = editeUserService;
        }

        public IActionResult Index(string serchkey, int page = 1)
        {
            return View(_getUsersService.Execute(
                new RequestGetUserDto
                {
                    Page = page,
                    SearchKey = serchkey
                }));
        }
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Roles = new SelectList(_getRolesService.Execute().Data, "Id", "Name");
            return View();
        }
        [HttpPost]
        public IActionResult Create(string Fullname, string Email, string Password, string RePassword, long[] Roles)
        {

            List<RolesInRequestRegisterUserDto> rolesinregister = new();
            if (Roles.Length > 0)
            {
                foreach (var item in Roles)
                {
                    rolesinregister.Add(new RolesInRequestRegisterUserDto() { Id = item });
                }
            }
            RequestRegisterUserDto request = new()
            {
                FullName = Fullname,
                Email = Email,
                Password = Password,
                RePassword = RePassword,
                Roles = rolesinregister
            };
            var Result = _registerUsersService.Execute(request);
            return Json(Result);
        }
        [HttpPost]
        public IActionResult Delete(long UserId)
        {

            var result = _removeUserService.Execute(UserId);
            return Json(result);
        }
        [HttpPost]
        public IActionResult ChangeState(long userId)
        {

            return Json(_changeUserStateService.Execut(userId));

        }
        [HttpPost]
        public IActionResult EditeUser(long userid, string fullname)
        {

            return Json(_editeUserService.Execute(FullName: fullname, UserId: userid));
        }

    }
}

