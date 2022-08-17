using asp_store_bugeto.Application.Intefaces.Contexts;
using asp_store_bugeto.Common.Dto;
using System;
using FluentValidation;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using asp_store_bugeto.Domain.Entities.Products;

namespace asp_store_bugeto.Application.Services.Products.Commands.AddNewCategory
{
    public interface IAddNewCategoryService
    {
        public ResultDto Execute(RequestAddNewCategoryDto req);
    }
    public class RequestAddNewCategoryDto
    {
        public long? ParentId { get; set; }
        public string Name { get; set; }
    }
    public class RequestAddNewCategoryDtoValidation : AbstractValidator<RequestAddNewCategoryDto>
    {
        public RequestAddNewCategoryDtoValidation()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("لطفا نام را وارد کنید.");
        }
    }
    public class AddNewCategoryService : IAddNewCategoryService
    {
        private readonly IDataBaseContext _context;
        public AddNewCategoryService(IDataBaseContext context)
        {
            _context = context;

        }

        public ResultDto Execute(RequestAddNewCategoryDto req)
        {
            var validation = new RequestAddNewCategoryDtoValidation();
            var valid = validation.Validate(req);
            if (valid.IsValid)
            {
                var category = new Category()
                {
                    Name = req.Name,
                    ParentCategory = getParentCategory(req.ParentId)
                };
                _context.Categories.Add(category);
                _context.SaveChanges();
                return new() { IsSuccess = true, Message = "عملیات با موفقیت انحام شد." };
            }
            else
            {
                return new() { IsSuccess = false, Message = valid.Errors[0].ToString() };
            }
        }

        private Category getParentCategory(long? parentId)
        {
            return _context.Categories.Find(parentId);
        }
    }
}
