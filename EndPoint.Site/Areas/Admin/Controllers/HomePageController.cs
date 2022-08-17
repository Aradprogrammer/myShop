using asp_store_bugeto.Application.Intefaces.FacadPattern;
using asp_store_bugeto.Common.HomePageLocations;
using EndPoint.Site.Areas.Admin.Models.ViewModels.HomePage;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EndPoint.Site.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomePageController : Controller
    {
        private IHomePageFacadPattern _homePageFacad;
        private ICommonFacad _CommonFacad;
        public HomePageController(IHomePageFacadPattern homePageFacad, ICommonFacad commonFacad)
        {
            _homePageFacad = homePageFacad;
            _CommonFacad = commonFacad;
        }
        [HttpGet]
        public IActionResult Index(int page = 1, string search = "", int pagesize = 20)
        {
            var model = _homePageFacad.GetAllPic.Execute(new() { Page = page, PageSize = pagesize, Search = search }).Data;
            return View(model);
        }
        [HttpPost]
        public IActionResult RemovePic(long PicId)
        {
            return Json(_homePageFacad.RemovePicHomePage.Execute(PicId));
        }
        [HttpGet]
        public IActionResult AddPicForHomePage()
        {
            var items = _homePageFacad.GetLocation.Execute().Data;
            SelectList select = new(items.Select(p => new
            {
                Text = p,
                Value = p
            }).ToList(), "Value", "Text");
            var model = new AddPicForHomePageViewModel()
            {
                Locations = select
            };
            return View(model);
        }
        [HttpPost]
        public IActionResult AddPicForHomePage(string PicLink, IFormFile PicForLink, string Location)
        {
            return Json(_homePageFacad.AddPicHome.Execute(new() { Link = PicLink, Location = Location, Pic = PicForLink }));
        }
        [HttpGet]
        public IActionResult SetCategoryForSlider()
        {
            var list = Enum.GetNames(typeof(CategorySliderLocation)).Select(p => new { Name = p, val = p }).ToList();
            var model = new SetCategoryForSliderViewModel()
            {
                ChildCategory = new SelectList(_CommonFacad.GetCategoriesChilds.Execute().Data, "CatID", "Name"),
                SliderLocation = new SelectList(list, "Name", "val")
            };
            return View(model);
        }
        [HttpPost]
        public IActionResult SetCategoryForSlider(int CountItem, string Location, long CatId)
        {
            return Json(_homePageFacad.SetCategoryForSlider.Execute(new() { CategoryId = CatId, CountItem = CountItem, Location = Location }));
        }
        public IActionResult SliderList()
        {
            var model = _homePageFacad.GetAllSlider.Execute().Data;
            return View(model);
        }
        [HttpPost]
        public IActionResult UnSetCategory(long ID)
        {
            return Json(_homePageFacad.UnSetCategoryForSlider.Execute(ID));
        }
    }
}
