using asp_store_bugeto.Application.Intefaces.Contexts;
using asp_store_bugeto.Common.Dto;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System;
using FluentValidation;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using asp_store_bugeto.Domain.Entities.Products;

namespace asp_store_bugeto.Application.Services.Products.Commands.EditProduct
{
    public interface IEditProductService
    {
        public ResultDto Execute(EditProductRequestDto req);
    }

    public class EditProductRequestDto
    {
        public long ID { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public long CategoryID { get; set; }
        public int Price { get; set; }
        public int Inventory { get; set; }
        public string Description { get; set; }
        public bool Displayed { get; set; }
        public List<IFormFile> Images { get; set; }
        public List<EditFeaturDto> Featurs { get; set; }
    }
    internal class UpLoadDto
    {
        public string FileAddress { get; set; }
        public bool Status { get; set; }
    }
    public class EditFeaturDto
    {
        public string Name { get; set; }
        public string Value { get; set; }
    }
    public class EditProductValidation : AbstractValidator<EditProductRequestDto>
    {
        public EditProductValidation()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("لطفا نام کالا را وارد کنید.");
            RuleFor(x => x.Brand).NotEmpty().WithMessage("لطفا برند کالا را وارد کنید.");
            RuleFor(x => x.Price).NotEmpty().WithMessage("لطفا قیمت کالا را وارد کنید.");
            RuleFor(x => x.Inventory).NotEmpty().WithMessage("لطفا موجودی کالا را وارد کنید.");
            RuleFor(x => x.CategoryID).NotEmpty().WithMessage("لطفا دسته کالا را وارد کنید.");
            RuleFor(x => x.Description).NotEmpty().WithMessage("لطفا توضیحات کالا را وارد کنید.");

        }
    }

    public class EditProduct_FeaturesValidation : AbstractValidator<EditFeaturDto>
    {
        public EditProduct_FeaturesValidation()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("لطفا نام ویژگی را وارد کنید.");
            RuleFor(x => x.Value).NotEmpty().WithMessage("لطفا مقدار ویژگی را وارد کنید.");
        }
    }
    public class EditProductService : IEditProductService
    {
        private readonly IDataBaseContext _context;
        private readonly IHostingEnvironment _environment;
        public EditProductService(IDataBaseContext context, IHostingEnvironment environment)
        {
            _context = context;
            _environment = environment;
        }
        private UpLoadDto UploadFile(IFormFile File)
        {
            if (File != null || File.Length > 0)
            {
                var folder = _context.Temps.Where(x => x.Key == "Img_Path_Product").Single().Value;
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
        public ResultDto Execute(EditProductRequestDto req)
        {
            var validationreq = new EditProductValidation();
            var validation = validationreq.Validate(req);
            if (validation.IsValid)
            {
                var category = _context.Categories.Find(req.CategoryID);
                var product = _context.Products.Where(x => x.Id == req.ID).SingleOrDefault();
                if (product != null)
                {
                    product.Name = req.Name;
                    product.Brand = req.Brand;
                    product.Category = category;
                    product.Price = req.Price;
                    product.Inventory = req.Inventory;
                    product.Description = req.Description;
                    product.Displayed = req.Displayed;
                    _context.SaveChanges();

                    if (req.Images.Count > 0)
                    {
                        List<ProductImages> images = new();
                        foreach (var item in req.Images)
                        {
                            var img = UploadFile(item);
                            images.Add(new() { InsertTime = DateTime.Now, Product = product, Src = img.FileAddress });
                        }
                        _context.ProductImages.AddRange(images);
                        _context.SaveChanges();
                    }
                    if (req.Featurs != null && req.Featurs.Count>0)
                    {
                        List<ProductFeatures> features = new();
                        var validationFeaturs = new EditProduct_FeaturesValidation();
                        foreach (var item in req.Featurs)
                        {
                            var validationf = validationFeaturs.Validate(item);
                            if (validationf.IsValid)
                                features.Add(new() { InsertTime = DateTime.Now, Name = item.Name, Product = product, Value = item.Value });
                        }
                        _context.ProductFeatures.AddRange(features);
                        _context.SaveChanges();
                    }
                    return new() { IsSuccess = true ,Message="عملیات با موفقیت انجام شد"};
                }
                else
                {
                    return new() { IsSuccess = false, Message = "کالا پیدا نشد!" };
                }


            }
            else
            {
                return new() { IsSuccess = false, Message = validation.Errors[0].ErrorMessage };
            }

        }
    }
}
