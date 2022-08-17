using asp_store_bugeto.Application.Intefaces.Contexts;
using asp_store_bugeto.Common;
using asp_store_bugeto.Common.Dto;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System;
using AutoMapper;
using System.Collections.Generic;

namespace asp_store_bugeto.Application.Services.Products.Queries.GetProducts
{
    public class GetProductsService : IGetProductsService
    {
        private readonly IDataBaseContext _context;
        private readonly IMapper _mapper;
        public GetProductsService(IDataBaseContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public ResultDto<ResultGetProductDto> Execute(RequestGetProduct req)
        {
            var Products = _context.Products.Include(x => x.Category).ThenInclude(x => x.ParentCategory).Include(x => x.ProductImages).Where(x => x.Displayed == true).AsQueryable();
            if (!string.IsNullOrEmpty(req.Search))
            {
                Products = Products.Where(x => x.Name.Contains(req.Search)).AsQueryable();
            }
            if (req.CategoryId != null)
            {
                Products = Products.Where(p => p.CategoryID == req.CategoryId || p.Category.ParentCategoryId == req.CategoryId).AsQueryable();
            }
            switch (req.Orderby)
            {
                case Ordering.NotOrder:
                    Products = Products.OrderByDescending(p => p.Id).AsQueryable();
                    break;
                case Ordering.MostVisited:
                    Products = Products.OrderByDescending(p => p.VisitCount).AsQueryable();
                    break;
                case Ordering.Bestselling:
                    break;
                case Ordering.MostPopular:
                    Products = Products.OrderByDescending(p => p.PopularCount).AsQueryable();
                    break;
                case Ordering.theNewest:
                    Products = Products.OrderByDescending(p => p.Id).AsQueryable();
                    break;
                case Ordering.Cheapest:
                    Products = Products.OrderBy(p => p.Price).AsQueryable();
                    break;
                case Ordering.theMostExpensive:
                    Products = Products.OrderByDescending(p => p.Price).AsQueryable();
                    break;
                default:
                    Products = Products.OrderByDescending(p => p.Id).AsQueryable();
                    break;
            }
            int rowcount = 0;
            var productslist = _mapper.Map<List<ProductDtoForList>>(Products.ToPaged(req.Page, req.PageSize, out rowcount).ToList());
            return new() { Data = new() { Products = productslist, RowCount = rowcount, CurrentPage = req.Page, PageSize = req.PageSize }, IsSuccess = true };
        }
    }
}