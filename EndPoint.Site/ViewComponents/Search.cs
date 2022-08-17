using asp_store_bugeto.Application.Intefaces.FacadPattern;
using Microsoft.AspNetCore.Mvc;

namespace EndPoint.Site.ViewComponents
{
    public class Search:ViewComponent
    {
        private ICommonFacad _commonFacad;
        public Search(ICommonFacad commonFacad)
        {
            _commonFacad = commonFacad;
        }
        public IViewComponentResult Invoke()
        {

            return View(viewName:"Search",model:_commonFacad.GetCategoriesParent.Execute().Data);
        }
    }
}
