using asp_store_bugeto.Application.Intefaces.Contexts;
using asp_store_bugeto.Common.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asp_store_bugeto.Application.Services.HomePage.Queries.GetPicByLocation
{
    public interface IGetPicByLocation
    {
        public ResultDto<List<PicByLocationDto>> Execute(string Location);
    }

    public class PicByLocationDto
    {
        public string Src { get; set; }
        public string Link { get; set; }
        public string Loction { get; set; }
    }

    public class GetPicByLocation : IGetPicByLocation
    {
        private readonly IDataBaseContext _context;
        public GetPicByLocation(IDataBaseContext context)
        {
            _context = context;
        }

        public ResultDto<List<PicByLocationDto>> Execute(string Location)
        {
            if (!string.IsNullOrEmpty(Location))
            {
                var pics = _context.PicsAndLinks.Where(x => x.Location == Location).Select(p => new PicByLocationDto() { Link = p.Link, Loction = p.Location, Src = p.Src }).ToList();
                if (pics != null && pics.Count > 0)
                    return new() { Data = pics, IsSuccess = true, Message = "عملیات با موفقیت انجام شد." };

                else
                    return new() { IsSuccess = false, Message = "تصویری برای این مکان یافت نشد." };
            }
            else
            {
                return new() { IsSuccess = false, Message = "عملیات نا موفق (موقعیت خالی)." };
            }
        }
    }
}
