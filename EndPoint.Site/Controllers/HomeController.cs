using asp_store_bugeto.Application.Intefaces.FacadPattern;
using EndPoint.Site.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using EndPoint.Site.Models.ViewModel;
using asp_store_bugeto.Common.HomePageLocations;
using System.Linq;
using System.Threading.Tasks;

namespace EndPoint.Site.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IHomePageFacadPattern _homePageFacad;

        public HomeController(ILogger<HomeController> logger, IHomePageFacadPattern homePageFacad)
        {
            _logger = logger;
            _homePageFacad = homePageFacad;
        }

        public IActionResult Index()
        {

            var model = new HomeIndexViewModel()
            {
                TopSlider = _homePageFacad.GetPicByLocation.Execute(Location.GetName(Location.TopSlider)).Data,
                TopOffer = _homePageFacad.GetPicByLocation.Execute(Location.GetName(Location.TopOffer)).Data,
                DowenOffer = _homePageFacad.GetPicByLocation.Execute(Location.GetName(Location.DowenOffer)).Data,
                MiddleOffer = _homePageFacad.GetPicByLocation.Execute(Location.GetName(Location.MiddleOffer)).Data,
                BigPicOffer = _homePageFacad.GetPicByLocation.Execute(Location.GetName(Location.BigPicOffer)).Data.First(),
                BigPicOffer2 = _homePageFacad.GetPicByLocation.Execute(Location.GetName(Location.BigPicOffer2)).Data.First(),
                Slider1 = _homePageFacad.GetSliderByLocatin.Execut(CategorySliderLocation.GetName(CategorySliderLocation.Slider1)).Data,
                Slider2 = _homePageFacad.GetSliderByLocatin.Execut(CategorySliderLocation.GetName(CategorySliderLocation.Slider2)).Data,
                Slider3 = _homePageFacad.GetSliderByLocatin.Execut(CategorySliderLocation.GetName(CategorySliderLocation.Slider3)).Data,
                Slider4 = _homePageFacad.GetSliderByLocatin.Execut(CategorySliderLocation.GetName(CategorySliderLocation.Slider4)).Data
            };
            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
