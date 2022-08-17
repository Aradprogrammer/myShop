using asp_store_bugeto.Application.Services.Roles.GetRoleByName;
using asp_store_bugeto.Application.Services.Users.Commands.RegisterUsers;
using asp_store_bugeto.Application.Services.Users.Queries.GetRoles;
using asp_store_bugeto.Application.Services.Users.Queries.LoginUser;
using asp_store_bugeto.Common.Roles;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using System;
using asp_store_bugeto.Application.Services.Users.Commands.EditeUser;
using asp_store_bugeto.Application.Services.Temp.Queries.GetDataWithKey;
using asp_store_bugeto.Application.Services.Users.Queries.GetUserByEmail;
using asp_store_bugeto.Application.Services.Temp.Commands.RemoveTempData;
using asp_store_bugeto.Application.Intefaces.FacadPattern;

namespace EndPoint.Site.Controllers
{
    public class AuthenticationController : Controller
    {
        private readonly IRegisterUsersService _registerUsersService;
        private readonly IGetRoleByNameService _getRoleByNameService;
        private readonly ILoginUserService _loginUserService;
        private readonly IEmailFacad _emailFacad;
        private readonly IEditeUserService _editeUserService;
        private readonly IGetDataWithKeyService _getDataWithKeyService;
        private readonly IGetUserByEmailService _getUserByEmailService;
        private readonly IRemoveTempDataService _removeTempDataService;

        public AuthenticationController(IRegisterUsersService registerUsersService, IGetRoleByNameService getRoleByNameService, ILoginUserService loginUserService, IEmailFacad emailFacad, IEditeUserService editeUserService, IGetDataWithKeyService getDataWithKeyService, IGetUserByEmailService getUserByEmailService, IRemoveTempDataService removeTempDataService)
        {

            _registerUsersService = registerUsersService;
            _getRoleByNameService = getRoleByNameService;
            _loginUserService = loginUserService;
            _emailFacad = emailFacad;
            _editeUserService = editeUserService;
            _getDataWithKeyService = getDataWithKeyService;
            _getUserByEmailService = getUserByEmailService;
            _removeTempDataService = removeTempDataService;
        }
        [HttpGet]
        public IActionResult SingUp()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SingUp(string Fullname, string Email, string Password, string RePassword)
        {
            RequestRegisterUserDto request = new()
            {
                FullName = Fullname,
                Email = Email,
                Password = Password,
                RePassword = RePassword,
                Roles = new List<RolesInRequestRegisterUserDto>()
                {
                    new RolesInRequestRegisterUserDto()
                    {
                        Id =_getRoleByNameService.Execut(nameof(UserRoles.Customer)).Data.Id
                    }
                }
            };
            var Result = _registerUsersService.Execute(request);
            if (Result.IsSuccess)
            {

                HttpContext.SignInAsync(
                    new ClaimsPrincipal(
                        new ClaimsIdentity(
                            GetClaim(
                                new LoginDto()
                                {
                                    Email = Email,
                                    FullName = Fullname,
                                    UserId = Result.Data.userId,
                                    Roles = new List<RolesDto>()
                                    {
                                        new RolesDto()
                                        {
                                            Id = _getRoleByNameService.Execut(nameof(UserRoles.Customer)).Data.Id,
                                            Name = nameof(UserRoles.Customer)
                                        }
                                    }
                                }),
                            CookieAuthenticationDefaults.AuthenticationScheme)),
                    new AuthenticationProperties()
                    {
                        AllowRefresh = true,
                        IsPersistent = true
                    }
                    );
            }
            return Json(Result);
        }
        [HttpGet]
        public IActionResult Login() { return View(); }
        [HttpPost]
        public IActionResult Login(string Username, string password, bool remmber)
        {
            var result = _loginUserService.Execut(new RequestLoginDto() { UserName = Username, Password = password });
            if (result.IsSuccess)
            {
                var property = new AuthenticationProperties()
                {
                    AllowRefresh = true,
                    IsPersistent = true,
                    ExpiresUtc = Getexpiresuser(remmber)
                };
                HttpContext.SignInAsync(
                    new ClaimsPrincipal(new ClaimsIdentity(GetClaim(result.Data),
                    CookieAuthenticationDefaults.AuthenticationScheme)),
                    property

                    );
            }
            return Json(result);
        }
        private static DateTime Getexpiresuser(bool remmeber)
        {
            return remmeber ? DateTime.Now.AddDays(5) : DateTime.Now.AddDays(1);
        }
        private static List<Claim> GetClaim(LoginDto request)
        {
            var result = new List<Claim>()
            {
                new Claim(ClaimTypes.NameIdentifier,request.UserId.ToString()),
                new Claim(ClaimTypes.Email,request.Email),
                new Claim(ClaimTypes.Name,request.FullName)
            };
            foreach (var item in request.Roles)
            {
                result.Add(new Claim(ClaimTypes.Role, item.Name));
            }
            return result;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult singout()
        {
            HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index", "Home");
        }
        [HttpGet]
        public IActionResult Forgotpassword()
        {

            return View();
        }
        [HttpPost]
        public IActionResult Forgorpassword(string email)
        {

            return Json(_emailFacad.SendEmail.Execute(email, "بازیابی گذرواژه", HttpContext.Request.Host.ToString()));
        }
        [HttpGet]
        public IActionResult resetpassword(string key)
        {
            var Data = _getDataWithKeyService.Execute(key);
            if (Data.IsSuccess)
                if (Data.Data.Description == "بازیابی گذرواژه")
                {
                    ViewBag.Email = Data.Data.Value;
                    _removeTempDataService.Execute(key);
                    return View();
                }
                else
                {
                    return BadRequest();
                }
            else
                return BadRequest();
        }

        [HttpPost]
        public IActionResult resetpassword(string Email, string NewPassword, string ReNewPassword)
        {
            var User = _getUserByEmailService.Execute(Email);
            if (User == null)
            {
                return BadRequest();
            }
            ;
            return Json(_editeUserService.Execute(User.Data.FullName, User.Data.Id, NewPassword, ReNewPassword));
        }
    }
}
