using asp_store_bugeto.Common.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace asp_store_bugeto.Application.Services.Temp.Queries.GetDataWithKey
{
    public interface IGetDataWithKeyService
    {
        public ResultDto<ResultTempDto> Execute(string Key);
    }
}
