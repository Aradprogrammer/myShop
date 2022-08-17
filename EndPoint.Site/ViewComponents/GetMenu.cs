using asp_store_bugeto.Application.Intefaces.FacadPattern;
using Microsoft.AspNetCore.Mvc;

namespace EndPoint.Site.ViewComponents
{
    public class GetMenu : ViewComponent
    {
        private ICommonFacad _CommonFacad;
        public GetMenu(ICommonFacad commonFacad)
        {
            _CommonFacad = commonFacad;
        }
        public IViewComponentResult Invoke()
        {
            var items = _CommonFacad.GetMenuItems.Execute();
            return View(viewName: "GetMenu", model: items.Data);
        }
    }
}
