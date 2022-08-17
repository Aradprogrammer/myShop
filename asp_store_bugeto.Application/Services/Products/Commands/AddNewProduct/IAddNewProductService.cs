
using asp_store_bugeto.Application.Intefaces.Contexts;
using asp_store_bugeto.Common.Dto;
using Microsoft.AspNetCore.Http;
using System;
using FluentValidation;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using asp_store_bugeto.Domain.Entities.Products;

namespace asp_store_bugeto.Application.Services.Products.Commands.AddNewProduct
{
    public interface IAddNewProductService
    {
        public ResultDto Execute(AddProductRequestDto req);
    }

    public class AddProductRequestDto
    {
        public string Name { get; set; }
        public string Brand { get; set; }
        public string Description { get; set; }
        public int Inventory { get; set; }
        public int Price { get; set; }
        public bool Displayed { get; set; }
        public long CategoryID { get; set; }

        public List<IFormFile> ProductImages { get; set; }
        public List<ProductFeaturesDto> ProductFeature { get; set; }
    }

    public class UpLoadDto
    {
        public string FileAddress { get; set; }
        public bool Status { get; set; }
    }

    public class ProductFeaturesDto
    {
        public string DisplayeName { get; set; }
        public string Value { get; set; }
    }
    public class AddNewProductService : IAddNewProductService
    {
        private readonly IDataBaseContext _context;
        private readonly IHostingEnvironment _environment;
        public AddNewProductService(IDataBaseContext context, IHostingEnvironment environment)
        {
            _context = context;
            _environment = environment;
        }
        public ResultDto Execute(AddProductRequestDto req)
        {
            try
            {
                var ReqValidation = new AddProductValidation();
                var valid = ReqValidation.Validate(req);
                if (valid.IsValid)
                {
                    var category = _context.Categories.Find(req.CategoryID);
                    Product products = new()
                    {
                        InsertTime = DateTime.Now,
                        Inventory = req.Inventory,
                        Price = req.Price,
                        Description = req.Description,
                        Name = req.Name,
                        Brand = req.Brand,
                        Displayed = req.Displayed,
                        Category = category
                    };
                    _context.Products.Add(products);
                    if (req.ProductFeature != null)
                    {
                        var FeaturValidaion = new ProductFeaturesValidation();
                        List<ProductFeatures> features = new();
                        foreach (var item in req.ProductFeature)
                        {
                            var validFeatur = FeaturValidaion.Validate(item);
                            if (validFeatur.IsValid)
                                features.Add(new() { InsertTime = DateTime.Now, Name = item.DisplayeName, Value = item.Value, Product = products });


                        }
                        _context.ProductFeatures.AddRange(features);
                    }
                    List<ProductImages> productImages = new();
                    foreach (var item in req.ProductImages)
                    {
                        var UploadResult = UploadFile(item);
                        if (UploadResult.Status)
                            productImages.Add(new() { Product = products, InsertTime = DateTime.Now, Src = UploadResult.FileAddress });
                    }
                    _context.ProductImages.AddRange(productImages);
                    _context.SaveChanges();
                    return new() { IsSuccess = true, Message = "عملیات با موفقیت انجام شد." };
                }
                else
                {
                    return new() { IsSuccess = false, Message = valid.Errors[0].ErrorMessage };
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public UpLoadDto UploadFile(IFormFile File)
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
    }
    public class AddProductValidation : AbstractValidator<AddProductRequestDto>
    {
        public AddProductValidation()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("لطفا نام کالا را وارد کنید.");
            RuleFor(x => x.Brand).NotEmpty().WithMessage("لطفا برند کالا را وارد کنید.");
            RuleFor(x => x.Price).NotEmpty().WithMessage("لطفا قیمت کالا را وارد کنید.");
            RuleFor(x => x.Inventory).NotEmpty().WithMessage("لطفا موجودی کالا را وارد کنید.");
            RuleFor(x => x.CategoryID).NotEmpty().WithMessage("لطفا دسته کالا را وارد کنید.");
            RuleFor(x => x.Description).NotEmpty().WithMessage("لطفا توضیحات کالا را وارد کنید.");

        }
    }
    public class ProductFeaturesValidation : AbstractValidator<ProductFeaturesDto>
    {
        public ProductFeaturesValidation()
        {
            RuleFor(x => x.DisplayeName).NotEmpty().WithMessage("لطفا نام ویژگی را وارد کنید.");
            RuleFor(x => x.Value).NotEmpty().WithMessage("لطفا مقدار ویژگی را وارد کنید.");
        }
    }
}
