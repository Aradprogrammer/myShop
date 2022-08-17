using asp_store_bugeto.Application.Intefaces.Contexts;
using asp_store_bugeto.Application.Intefaces.FacadPattern;
using asp_store_bugeto.Application.Services.Common.Queries.GetCategoriesChild;
using asp_store_bugeto.Application.Services.Common.Queries.GetCategoriesParent;
using asp_store_bugeto.Application.Services.Common.Queries.GetMenuItems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asp_store_bugeto.Application.Services.Common.FacadPattern
{
    public class CommonFacad : ICommonFacad
    {
        private readonly IDataBaseContext _context;
        public CommonFacad(IDataBaseContext context)
        {
            _context = context;
        }
        private IGetMenuItemsService _getMenuItems;
        public IGetMenuItemsService GetMenuItems
        {
            get { return _getMenuItems = _getMenuItems ?? new GetMenuItemsService(_context); }
        }
        private IGetCategoriesParent _getCategoriesParent;
        public IGetCategoriesParent GetCategoriesParent
        {
            get
            {
                return _getCategoriesParent = _getCategoriesParent ?? new GetCategoriesParent(_context);
            }
        }
        private IGetCategoriesChildService _getCategoriesChilds;
        public IGetCategoriesChildService GetCategoriesChilds
        {
            get
            {
                return _getCategoriesChilds = _getCategoriesChilds ?? new GetCategoriesChildService(_context);
            }
        }
    }
}
