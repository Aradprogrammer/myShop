using asp_store_bugeto.Application.Intefaces.FacadPattern;
using Microsoft.AspNetCore.Mvc;

namespace EndPoint.Site.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoriesController : Controller
    {
        private readonly IProductFacad _productFacad;
        public CategoriesController(IProductFacad productFacad)
        {
            _productFacad = productFacad;
        }
        public IActionResult Index(long? parentId)
        {
            return View(_productFacad.GetCategoriesService.Execute(parentId).Data);
        }
        [HttpGet]
        public IActionResult AddNewCategory(long? parentId)
        {
            ViewBag.parentId = parentId;
            return View();
        }
        [HttpPost]
        public IActionResult AddNewCategory(long? parentId, string name)
        {
            return Json(_productFacad.AddNewCategoryService.Execute(new() { Name = name, ParentId = parentId }));
        }
        [HttpPost]
        public IActionResult EditCategory(long Id, string Name)
        {
            return Json(_productFacad.EditCategory.Execute(Id, Name));
        }
        public IActionResult DeleteCategory(long Id)
        {
            return Json(_productFacad.RemoveCategory.Execute(Id));
        }
    }
}
