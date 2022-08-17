using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asp_store_bugeto.Common.HomePageLocations
{
    public class Locations
    {
        public const string TopSlider = "TopSlider";
        public const string TopOffer = "TopOffer";
        public const string BigPicOffer = "BigPicOffer";
        public const string BigPicOffer2 = "BigPicOffer2";
        public const string MiddleOffer = "MiddleOffer";
        public const string DowenOffer = "DowenOffer";
    }
    public enum Location
    {
        TopSlider = 1,
        TopOffer = 2,
        BigPicOffer = 3,
        BigPicOffer2 = 4,
        MiddleOffer = 5,
        DowenOffer = 6
    }
    public enum CategorySliderLocation
    {
        Slider1 = 0,
        Slider2 = 1,
        Slider3 = 2,
        Slider4 = 3,
    }
}
