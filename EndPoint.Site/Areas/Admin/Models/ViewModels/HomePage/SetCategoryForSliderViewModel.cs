using Microsoft.AspNetCore.Mvc.Rendering;

namespace EndPoint.Site.Areas.Admin.Models.ViewModels.HomePage
{
    public class SetCategoryForSliderViewModel
    {
        public SelectList ChildCategory { get; set; }
        public SelectList SliderLocation { get; set; }
    }
}
