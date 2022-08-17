using asp_store_bugeto.Common.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using asp_store_bugeto.Common.HomePageLocations;

namespace asp_store_bugeto.Application.Services.HomePage.Queries.GetLocations
{
    public interface IGetLocationService
    {
        public ResultDto<List<string>> Execute();
    }
    public class GetLocationsService : IGetLocationService
    {
        public ResultDto<List<string>> Execute()
        {
            List<string> locations = new List<string>();
            foreach (var item in Enum.GetNames(typeof(Location)))
            {
                locations.Add(item);
            }
            return new() { Data = locations, IsSuccess = true, Message = "" };
        }
    }
}
