using asp_store_bugeto.Application.Intefaces.FacadPattern;
using asp_store_bugeto.Application.Services.Products.Queries.GetProducts;
using EndPoint.Site.Models.ViewModel;
using Microsoft.AspNetCore.Mvc;
using EndPoint.Site.Utilities;
using System;

namespace EndPoint.Site.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IProductFacad _productFacad;
        private readonly ICartFacad _cartFacad;
        public ProductsController(IProductFacad productFacad, ICartFacad cartFacad)
        {
            _productFacad = productFacad;
            _cartFacad = cartFacad;
        }

        public IActionResult Index(Ordering orderby, int page = 1, string search = "", long? catid = null)
        {
            return View(_productFacad.GetProducts.Execute(new() { Page = page, PageSize = 2, Search = search, CategoryId = catid, Orderby = orderby }).Data);
        }
        public IActionResult DateilProduct(long ID)
        {
            var coocki = new DefauletMethodCoockies();
            return View(new DateilProductViewModel() { ProductDatelis = _productFacad.GetProduct.Execute(ID).Data, ProductCount = _cartFacad.GetCountItemFromCartByID.Execute(ID, Guid.Parse(coocki.TakeBrowserId(HttpContext))).Data });
        }
    }
}
