using asp_store_bugeto.Application.Intefaces.Contexts;
using asp_store_bugeto.Application.Intefaces.FacadPattern;
using asp_store_bugeto.Application.Services.HomePage.Commands.AddPicHome;
using asp_store_bugeto.Application.Services.HomePage.Commands.RemovePicHome;
using asp_store_bugeto.Application.Services.HomePage.Commands.SetCategoryForSliderr;
using asp_store_bugeto.Application.Services.HomePage.Commands.UnSetCategoryForSlider;
using asp_store_bugeto.Application.Services.HomePage.Queries.GetAllPic;
using asp_store_bugeto.Application.Services.HomePage.Queries.GetAllSlider;
using asp_store_bugeto.Application.Services.HomePage.Queries.GetLocations;
using asp_store_bugeto.Application.Services.HomePage.Queries.GetPicByLocation;
using asp_store_bugeto.Application.Services.HomePage.Queries.GetSliderByLocation;
using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asp_store_bugeto.Application.Services.HomePage.FacadPattern
{
    public class HomePageFacadPattern : IHomePageFacadPattern
    {
        private readonly IDataBaseContext _context;
        private readonly IHostingEnvironment _environment;
        public HomePageFacadPattern(IDataBaseContext context, IHostingEnvironment environment)
        {
            _context = context;
            _environment = environment;
        }
        private IAddPicHomeService _addPicHome;
        public IAddPicHomeService AddPicHome
        {
            get
            {
                return _addPicHome = _addPicHome ?? new AddPicHomeService(_context, _environment);
            }
        }
        private IGetLocationService _GetLocation;
        public IGetLocationService GetLocation
        {
            get
            {
                return _GetLocation = _GetLocation ?? new GetLocationsService();
            }
        }
        private IGetPicByLocation _getPicByLocation;
        public IGetPicByLocation GetPicByLocation
        {
            get
            {
                return _getPicByLocation = _getPicByLocation ?? new GetPicByLocation(_context);
            }
        }
        private IRemovePicHomeService _RemovePicHomePage;
        public IRemovePicHomeService RemovePicHomePage
        {
            get
            {
                return _RemovePicHomePage = _RemovePicHomePage ?? new RemovePicHomeService(_context);
            }
        }
        private IGetAllPicService _GetAllPic;
        public IGetAllPicService GetAllPic
        {
            get
            {
                return _GetAllPic = _GetAllPic ?? new GetAllPicService(_context);
            }
        }
        private ISetCategoryForSliderService _SetCategoryForSlider;
        public ISetCategoryForSliderService SetCategoryForSlider
        {
            get
            {
                return _SetCategoryForSlider = _SetCategoryForSlider ?? new SetCategoryForSliderService(_context);
            }
        }
        private IUnSetCategoryForSliderService _UnSetCategoryForSlider;
        public IUnSetCategoryForSliderService UnSetCategoryForSlider
        {
            get
            {
                return _UnSetCategoryForSlider = _UnSetCategoryForSlider ?? new UnSetCategoryForSliderService(_context);
            }
        }
        private IGetAllSliderService _GetAllSlider;
        public IGetAllSliderService GetAllSlider
        {
            get
            {
                return _GetAllSlider = _GetAllSlider ?? new GetAllSliderService(_context);
            }
        }
        private IGetSliderByLocatinService _GetSliderByLocatin;
        public IGetSliderByLocatinService GetSliderByLocatin
        {
            get
            {
                return _GetSliderByLocatin = _GetSliderByLocatin ?? new GetSliderByLocationService(_context);
            }
        }
    }
}
