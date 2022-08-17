using asp_store_bugeto.Application.Services.Common.Queries.GetCategoriesChild;
using asp_store_bugeto.Application.Services.Common.Queries.GetCategoriesParent;
using asp_store_bugeto.Application.Services.Common.Queries.GetMenuItems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asp_store_bugeto.Application.Intefaces.FacadPattern
{
    public interface ICommonFacad
    {
        public IGetMenuItemsService GetMenuItems { get; }
        public IGetCategoriesParent GetCategoriesParent { get; }
        public IGetCategoriesChildService GetCategoriesChilds { get; }
    }
}
