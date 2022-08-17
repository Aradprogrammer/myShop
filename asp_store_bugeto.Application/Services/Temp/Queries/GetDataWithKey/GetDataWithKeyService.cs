using asp_store_bugeto.Application.Intefaces.Contexts;
using asp_store_bugeto.Common.Dto;
using System.Linq;

namespace asp_store_bugeto.Application.Services.Temp.Queries.GetDataWithKey
{
    public class GetDataWithKeyService : IGetDataWithKeyService
    {
        private readonly IDataBaseContext _context;
        public GetDataWithKeyService(IDataBaseContext context)
        {
            _context = context;
        }
        public ResultDto<ResultTempDto> Execute(string Key)
        {
            var result = _context.Temps.Where(p => p.Key == Key).FirstOrDefault();
            if (result == null)
            {
                return new ResultDto<ResultTempDto>() { IsSuccess = false, Message = "اطلاعات وجود ندارد." };
            }
            else
            {
                return new ResultDto<ResultTempDto>() { IsSuccess = true, Message = "اطلاعات پیدا شد.", Data = new() { Key = Key, Description = result.Description, Value = result.Value } };
            }
        }
    }
}
