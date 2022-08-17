using asp_store_bugeto.Application.Services.HomePage.Commands.AddPicHome;
using asp_store_bugeto.Application.Services.HomePage.Commands.RemovePicHome;
using asp_store_bugeto.Application.Services.HomePage.Commands.SetCategoryForSliderr;
using asp_store_bugeto.Application.Services.HomePage.Commands.UnSetCategoryForSlider;
using asp_store_bugeto.Application.Services.HomePage.Queries.GetAllPic;
using asp_store_bugeto.Application.Services.HomePage.Queries.GetAllSlider;
using asp_store_bugeto.Application.Services.HomePage.Queries.GetLocations;
using asp_store_bugeto.Application.Services.HomePage.Queries.GetPicByLocation;
using asp_store_bugeto.Application.Services.HomePage.Queries.GetSliderByLocation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asp_store_bugeto.Application.Intefaces.FacadPattern
{
    public interface IHomePageFacadPattern
    {
        public IAddPicHomeService AddPicHome { get; }
        public IGetLocationService GetLocation { get; }
        public IGetPicByLocation GetPicByLocation { get; }
        public IRemovePicHomeService RemovePicHomePage { get; }
        public IGetAllPicService GetAllPic { get; }
        public ISetCategoryForSliderService SetCategoryForSlider { get; }
        public IUnSetCategoryForSliderService UnSetCategoryForSlider { get; }
        public IGetAllSliderService GetAllSlider { get; }
        public IGetSliderByLocatinService GetSliderByLocatin { get; }
    }
}
