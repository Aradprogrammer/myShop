using asp_store_bugeto.Application.Intefaces.FacadPattern;
using asp_store_bugeto.Application.Services.Products.Commands.AddNewProduct;
using asp_store_bugeto.Application.Services.Products.Commands.EditProduct;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;

namespace EndPoint.Site.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductsController : Controller
    {
        private readonly IProductFacad _productfacad;
        public ProductsController(IProductFacad productFacad)
        {
            _productfacad = productFacad;
        }
        public IActionResult Index(string search = "", int page = 1)
        {
            return View(_productfacad.GetProductsForAdmin.Execute(new() { Page = page, PageSize = 20, Search = search }).Data);
        }
        [HttpGet]
        public IActionResult AddNewProduct()
        {
            ViewBag.Categoreis = new SelectList(_productfacad.GetAllCategories.Execute().Data, "Id", "Name");
            return View();
        }
        [HttpPost]
        public IActionResult AddNewProduct(AddProductRequestDto req)
        {
            List<IFormFile> Image = new();
            if (Request.Form.Files.Count > 0)
            {
                for (int i = 0; Request.Form.Files.Count > i; i++)
                {
                    var file = Request.Form.Files[i];
                    Image.Add(file);
                }
            }
            req.ProductImages = Image;
            return Json(_productfacad.AddNewProduct.Execute(req));
        }
        public IActionResult ProductDetails(long Id)
        {
            return View(_productfacad.GetProductForAdmin.Execute(Id).Data);
        }
        public IActionResult DeleteProduct(long ProductId)
        {
            return Json(_productfacad.RemoveProduct.Execute(ProductId));
        }
        public IActionResult DeleteFeaturs(long FeaturId)
        {
            return Json(_productfacad.RemoveFeatur.Execute(FeaturId));
        }
        public IActionResult ChageDisplaye(long ProductId)
        {
            return Json(_productfacad.changeDisplaye.Execute(ProductId));
        }
        public IActionResult DeleteImage(long ImageId)
        {
            return Json(_productfacad.RemoveImage.Execute(ImageId));
        }
        [HttpPost]
        public IActionResult EditProduct(EditProductRequestDto req)
        {
            List<IFormFile> Image = new();
            if (Request.Form.Files.Count > 0)
            {
                for (int i = 0; Request.Form.Files.Count > i; i++)
                {
                    var file = Request.Form.Files[i];
                    Image.Add(file);
                }
            }
            req.Images = Image;
            return Json(_productfacad.EditProduct.Execute(req));
        }
        [HttpGet]
        public IActionResult EditProduct(long Id)
        {
            var model = _productfacad.GetProductForAdmin.Execute(Id).Data;
            var categories = _productfacad.GetAllCategories.Execute().Data;
            ViewBag.Categoreis = new SelectList(categories, "Id", "Name", model.CategoryId);
            return View(model);
        }
    }
}
