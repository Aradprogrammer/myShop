using asp_store_bugeto.Application.Intefaces.Contexts;
using asp_store_bugeto.Common;
using asp_store_bugeto.Common.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asp_store_bugeto.Application.Services.HomePage.Queries.GetAllPic
{
    public interface IGetAllPicService
    {
        public ResultDto<ResultPicsDto> Execute(RequestGetAllPicsHome req);
    }
    public class ResultPicsDto
    {
        public int PageSize { get; set; }
        public int CurrentPage { get; set; }
        public int RowCount { get; set; }
        public List<PicHomeDto> Pics { get; set; }

    }
    public class PicHomeDto
    {
        public long Id { get; set; }
        public string Src { get; set; }
        public string Location { get; set; }
        public string Link { get; set; }
    }
    public class RequestGetAllPicsHome
    {
        public string Search { get; set; } = "";
        public int Page { get; set; } = 1;
        public int PageSize { get; set; } = 20;
    }
    public class GetAllPicService : IGetAllPicService
    {
        private IDataBaseContext _context;
        public GetAllPicService(IDataBaseContext context)
        {
            _context = context;
        }
        public ResultDto<ResultPicsDto> Execute(RequestGetAllPicsHome req)
        {
            var result = _context.PicsAndLinks.AsQueryable();
            if (!string.IsNullOrEmpty(req.Search))
            {
                result = result.Where(p => p.Link.Contains(req.Search) || p.Src.Contains(req.Search)).AsQueryable();
            }
            int rows;
            var all = result.ToPaged(req.Page, req.PageSize, out rows).Select(p => new PicHomeDto() { Id = p.Id, Link = p.Link, Location = p.Location, Src = p.Src }).ToList();
            return new() { Data = new() { CurrentPage = req.Page, PageSize = req.PageSize, Pics = all, RowCount = rows }, IsSuccess = true, Message = "" };
        }
    }
}
