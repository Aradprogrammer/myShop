using asp_store_bugeto.Common.Dto;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace asp_store_bugeto.Application.Services.Temp.Commands.RemoveTempData
{
    public interface IRemoveTempDataService
    {
        public ResultDto Execute(string key);
    }
}
