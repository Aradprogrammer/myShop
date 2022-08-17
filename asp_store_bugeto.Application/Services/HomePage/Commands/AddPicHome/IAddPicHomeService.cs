using asp_store_bugeto.Application.Intefaces.Contexts;
using asp_store_bugeto.Common.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using asp_store_bugeto.Domain.Entities.HomePage;
using Microsoft.AspNetCore.Http;
using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace asp_store_bugeto.Application.Services.HomePage.Commands.AddPicHome
{
    public interface IAddPicHomeService
    {
        public ResultDto Execute(AddPicHomeRequestDto req);
    }

    public class AddPicHomeRequestDto
    {
        public IFormFile Pic { get; set; }
        public string Link { get; set; }
        public string Location { get; set; }
    }
    public class AddPicHomeService : IAddPicHomeService
    {
        public IDataBaseContext _context;
        private readonly IHostingEnvironment _environment;
        public AddPicHomeService(IDataBaseContext context, IHostingEnvironment environment)
        {
            _context = context;
            _environment = environment;
        }

        public ResultDto Execute(AddPicHomeRequestDto req)
        {
            var validation = new ValidationAddPicHomeRequest().Validate(req);
            if (validation.IsValid)
            {
                var imagsrc = UploadFile(req.Pic);
                if (imagsrc.Status)
                {
                    var pic = new PicAndLink() { Link = req.Link, Location = req.Location, Src = imagsrc.FileAddress };
                    _context.PicsAndLinks.Add(pic);
                    _context.SaveChanges();
                    return new() { IsSuccess = true, Message = "عملیات با موفقیت انجام شد." };
                }
                else
                {
                    return new() { IsSuccess = false, Message = "تصویر بارگذاری نشد!" };
                }
            }
            else
            {
                return new() { IsSuccess = false, Message = validation.Errors[0].ErrorMessage };
            }
        }
        public UpLoadDto UploadFile(IFormFile File)
        {


            if (File != null || File.Length > 0)
            {
                var folder = _context.Temps.Where(x => x.Key == "Img_Path_HomePage").Single().Value;
                var UploadRootFolder = Path.Combine(_environment.WebRootPath, folder);
                if (!Directory.Exists(UploadRootFolder))
                {
                    Directory.CreateDirectory(UploadRootFolder);
                }
                string fileName = DateTime.Now.Ticks.ToString() + File.FileName;
                var FilePath = Path.Combine(UploadRootFolder, fileName);
                using (var fs = new FileStream(FilePath, FileMode.Create))
                {
                    File.CopyTo(fs);
                }
                return new() { FileAddress = folder + fileName, Status = true };
            }
            else
            {
                return new() { FileAddress = "", Status = false };
            }



        }

    }

    public class UpLoadDto
    {
        public string FileAddress { get; set; }
        public bool Status { get; set; }
    }

    class ValidationAddPicHomeRequest : AbstractValidator<AddPicHomeRequestDto>
    {
        public ValidationAddPicHomeRequest()
        {
            RuleFor(x => x.Pic).NotEmpty().WithMessage("عکس را انتخاب کنید");
            RuleFor(x => x.Link).NotEmpty().WithMessage("لینک را وارد نمایید!");
            RuleFor(x => x.Location).NotEmpty().WithMessage("مکان قرار گیری را انتخاب کنید!");
        }
    }
}
