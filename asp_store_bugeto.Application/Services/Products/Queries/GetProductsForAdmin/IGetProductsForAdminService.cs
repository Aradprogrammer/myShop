using asp_store_bugeto.Application.Intefaces.Contexts;
using asp_store_bugeto.Common;
using asp_store_bugeto.Common.Dto;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using asp_store_bugeto.Domain.Entities.Products;

namespace asp_store_bugeto.Application.Services.Products.Queries.GetProductForAdmin
{
    public interface IGetProductsForAdminService
    {
        public ResultDto<ResultProductsForAdmin> Execute(RequestProductsForAdmin req);
    }

    public class RequestProductsForAdmin
    {
        public int PageSize { get; set; }
        public int Page { get; set; }
        public string Search { get; set; }
    }

    public class ResultProductsForAdmin
    {
        public int PageSize { get; set; }
        public int CurrentPage { get; set; }
        public int RowCount { get; set; }
        public List<ProductForAdminDtoForList> Products { get; set; }
    }

    public class ProductForAdminDtoForList
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public string CategoryName { get; set; }
        public string FirstImg { get; set; }
        public int Inventory { get; set; }
        public int Price { get; set; }
        public bool Displayed { get; set; }
    }
    public class GetProductsForAdminService : IGetProductsForAdminService
    {
        private readonly IMapper _mapper;
        private readonly IDataBaseContext _context;
        public GetProductsForAdminService(IDataBaseContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;   
        }

        public ResultDto<ResultProductsForAdmin> Execute(RequestProductsForAdmin req)
        {
            var Products = _context.Products.Include(x => x.Category).ThenInclude(x=>x.ParentCategory).Include(x => x.ProductImages).AsQueryable();
            if (!string.IsNullOrEmpty(req.Search))
            {
                Products = Products.Where(x => x.Name.Contains(req.Search));
            }
            int rowcount = 0;
          
                var productslist = _mapper.Map<List<ProductForAdminDtoForList>> (Products.ToPaged(req.Page, req.PageSize, out rowcount).ToList());
                return new() { Data = new() 
                { Products = productslist, RowCount = rowcount, CurrentPage = req.Page, PageSize = req.PageSize }, IsSuccess = true };
            
        }
    }
}