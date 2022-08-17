using asp_store_bugeto.Application.Intefaces.FacadPattern;
using EndPoint.Site.Utilities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace EndPoint.Site.ViewComponents
{
    public class GetMyCart : ViewComponent
    {
        private ICartFacad _cartFacad;
        public GetMyCart(ICartFacad cartFacad)
        {
            _cartFacad = cartFacad;
        }
        public IViewComponentResult Invoke()
        {
            var userid = ClaimUtilities.GetUserID(HttpContext.User);
            var coocki = new DefauletMethodCoockies();
            var id = Guid.Parse(coocki.TakeBrowserId(HttpContext));
            return View(viewName: "GetMyCart", model: _cartFacad.GetMyCart.Execute(id, userid).Data);
        }
    }
}
