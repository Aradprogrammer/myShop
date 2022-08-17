using asp_store_bugeto.Application.Intefaces.Contexts;
using asp_store_bugeto.Common.Dto;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asp_store_bugeto.Application.Services.Products.Queries.GetCategores
{
    public interface IGetCategoriesService
    {
        public ResultDto<List<CategoryDto>> Execute(long? ParentId);

    }

    public class CategoryDto
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public bool HasChild { get; set; }
        public ParentCategoryDto Parent { get; set; }
    }

    public class ParentCategoryDto
    {
        public long Id { get; set; }
        public string Name { get; set; }

    }
    public class GetCategoriesService : IGetCategoriesService
    {
        private readonly IDataBaseContext _context;
        public GetCategoriesService(IDataBaseContext context)
        {
            _context = context;

        }

        public ResultDto<List<CategoryDto>> Execute(long? ParentId)
        {
            var Categories = _context.Categories
                .Include(p => p.ParentCategory)
                .Include(p => p.SubCategories)
                .Where(p => p.ParentCategoryId == ParentId)
                .ToList()
                .Select(p => new CategoryDto()
                {
                    Id = p.Id,
                    Name = p.Name,
                    HasChild = p.SubCategories.Count > 0 ? true : false,
                    Parent = p.ParentCategoryId != null ? new ParentCategoryDto()
                    {
                        Id = p.ParentCategory.Id,
                        Name = p.ParentCategory.Name
                    } : null
                }).ToList();
            return new() { Data = Categories, IsSuccess = true, Message = "عمللیات با موفقیت انجام شد." };
        }
    }
}
