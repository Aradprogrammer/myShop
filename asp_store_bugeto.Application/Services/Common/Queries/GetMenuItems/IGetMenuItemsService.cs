using asp_store_bugeto.Application.Intefaces.Contexts;
using asp_store_bugeto.Common.Dto;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asp_store_bugeto.Application.Services.Common.Queries.GetMenuItems
{
    public interface IGetMenuItemsService
    {
        public ResultDto<List<MenuItemDto>> Execute();
    }

    public class MenuItemDto
    {
        public long CategoryID { get; set; }
        public string CategoryName { get; set; }
        public List<MenuItemDto> SubCategories { get; set; }
    }
    public class GetMenuItemsService:IGetMenuItemsService
    {

        private readonly IDataBaseContext _context;
        public GetMenuItemsService(IDataBaseContext context)
        {
            _context = context;
        }

        public ResultDto<List<MenuItemDto>> Execute()
        {
            var Items = _context.Categories
                .Include(p => p.SubCategories)
                .Where(p => p.ParentCategoryId == null)
                .ToList()
                .Select(p => new MenuItemDto()
                {
                    CategoryID = p.Id,
                    CategoryName = p.Name,
                    SubCategories = p.SubCategories.ToList().Select(x => new MenuItemDto() { CategoryID = x.Id, CategoryName = x.Name }).ToList()
                }).ToList();
            return new() { Data = Items, IsSuccess = true };
        }
    }
}
