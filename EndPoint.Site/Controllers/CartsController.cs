using Microsoft.AspNetCore.Mvc;
using EndPoint.Site.Utilities;
using asp_store_bugeto.Application.Intefaces.FacadPattern;
using System;

namespace EndPoint.Site.Controllers
{
    public class CartsController : Controller
    {
        private ICartFacad _cartfacad;
        public CartsController(ICartFacad cartfacad)
        {
            _cartfacad = cartfacad;
        }

        public IActionResult Index()
        {
            var userid = ClaimUtilities.GetUserID(HttpContext.User);
            var coocki = new DefauletMethodCoockies();
            var cart = _cartfacad.GetMyCart.Execute(Guid.Parse(coocki.TakeBrowserId(HttpContext)), userid).Data;
            if (cart == null)
                return BadRequest();
            if (cart.CountItem < 1)
                return View("cartempty");
            return View(cart);
        }
        [HttpPost]
        public IActionResult AddToCart(int productCount, long productId)
        {
            var coocki = new DefauletMethodCoockies();
            var browserid = coocki.TakeBrowserId(HttpContext);
            var result = _cartfacad.AddNewCartItemService.Execute(new() { BrowserID = Guid.Parse(browserid), ProductCount = productCount, ProductID = productId });
            return Json(result);
        }
        public IActionResult GetMyCart()
        {
            var userid = ClaimUtilities.GetUserID(HttpContext.User);
            var coocki = new DefauletMethodCoockies();
            return Json(_cartfacad.GetMyCart.Execute(Guid.Parse(coocki.TakeBrowserId(HttpContext)), userid));
        }
        public IActionResult RemoveCartItem(long ProductId, long CartId)
        {
            var coocki = new DefauletMethodCoockies();
            return Json(_cartfacad.RemoveCartItem.Execute(Guid.Parse(coocki.TakeBrowserId(HttpContext)), ProductId, CartId));
        }
    }
}
