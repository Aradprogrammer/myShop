using asp_store_bugeto.Application.Intefaces.Contexts;
using asp_store_bugeto.Common.Dto;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asp_store_bugeto.Application.Services.Products.Queries.GetAllCategories
{
    public interface IGetAllCategoriesService
    {
        public ResultDto<List<AllCategoriesDto>> Execute();
    }

    public class AllCategoriesDto
    {
        public long Id { get; set; }
        public string Name { get; set; }
    }
    public class GetAllCategoriesService : IGetAllCategoriesService
    {
        private readonly IDataBaseContext _context;
        public GetAllCategoriesService(IDataBaseContext context)
        {
            _context = context;
        }

        public ResultDto<List<AllCategoriesDto>> Execute()
        {
            try
            {
                var categories = _context.Categories
                    .Include(x => x.ParentCategory)
                    .Where(x => x.ParentCategory != null)
                    .Select(x => new AllCategoriesDto() 
                    { 
                        Id = x.Id,
                        Name = $"{x.ParentCategory.Name} - {x.Name}" 
                    })
                    .ToList();
                return new() { Data = categories, IsSuccess = true, Message = "" };
            }
            catch (Exception ex)
            {
                return new() { IsSuccess = false, Message = ex.Message };
            }
        }
    }
}
