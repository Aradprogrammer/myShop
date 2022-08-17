using asp_store_bugeto.Application.Intefaces.FacadPattern;
using Microsoft.AspNetCore.Mvc;

namespace EndPoint.Site.ViewComponents
{
    public class GetMenuForMobil : ViewComponent
    {
        private ICommonFacad _CommonFacad;
        public GetMenuForMobil(ICommonFacad commonFacad)
        {
            _CommonFacad = commonFacad;
        }
        public IViewComponentResult Invoke()
        {
            var items = _CommonFacad.GetMenuItems.Execute().Data;
            return View(viewName: "GetMenuForMobil", model: items);
        }
    }
}
