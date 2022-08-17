using asp_store_bugeto.Application.Services.HomePage.Queries.GetPicByLocation;
using asp_store_bugeto.Application.Services.HomePage.Queries.GetSliderByLocation;
using System.Collections.Generic;

namespace EndPoint.Site.Models.ViewModel
{
    public class HomeIndexViewModel
    {
        public List<PicByLocationDto> TopSlider { get; set; }
        public List<PicByLocationDto> TopOffer { get; set; }
        public PicByLocationDto BigPicOffer { get; set; }
        public PicByLocationDto BigPicOffer2 { get; set; }
        public List<PicByLocationDto> MiddleOffer { get; set; }
        public List<PicByLocationDto> DowenOffer { get; set; }
        public List<ProductForSliderDto> Slider1 { get; set; }
        public List<ProductForSliderDto> Slider2 { get; set; }
        public List<ProductForSliderDto> Slider3 { get; set; }
        public List<ProductForSliderDto> Slider4 { get; set; }
    }
}
