using asp_store_bugeto.Application.Intefaces.Contexts;
using asp_store_bugeto.Common.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asp_store_bugeto.Application.Services.Common.Queries.GetCategoriesParent
{
    public interface IGetCategoriesParent
    {
        public ResultDto<List<ParentCategory>> Execute();
    }

    public class ParentCategory
    {
        public long CategoryId { get; set; }
        public string CategoryName { get; set; }

    }
    public class GetCategoriesParent : IGetCategoriesParent
    {
        private readonly IDataBaseContext _context;
        public GetCategoriesParent(IDataBaseContext context)
        {
            _context = context;
        }

        public ResultDto<List<ParentCategory>> Execute()
        {
            var cats = _context.Categories
                .Where(p => p.ParentCategory == null)
                .ToList()
                .Select(p => new ParentCategory() { CategoryId = p.Id, CategoryName = p.Name })
                .ToList();
            return new() { Data = cats, IsSuccess = true, Message = "" };
        }
    }
}
