using asp_store_bugeto.Application.Intefaces.Contexts;
using asp_store_bugeto.Common.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asp_store_bugeto.Application.Services.Common.Queries.GetCategoriesChild
{
    public interface IGetCategoriesChildService
    {
        public ResultDto<List<childCategoryDto>> Execute();
    }

    public class childCategoryDto
    {
        public long CatID { get; set; }
        public string Name { get; set; }
    }
    public class GetCategoriesChildService : IGetCategoriesChildService
    {
        private IDataBaseContext _context;
        public GetCategoriesChildService(IDataBaseContext context)
        {
            _context = context;
        }

        public ResultDto<List<childCategoryDto>> Execute()
        {
            var cat = _context.Categories.Where(p => p.ParentCategory != null).Select(p => new childCategoryDto() { CatID = p.Id, Name = p.Name }).ToList();
            return new() { Data = cat, IsSuccess = true, Message = "" };
        }
    }
}
