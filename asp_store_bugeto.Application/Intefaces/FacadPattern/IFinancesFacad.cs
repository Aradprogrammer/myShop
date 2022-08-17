using asp_store_bugeto.Application.Services.Finances.Commands.AddRequestPay;
using asp_store_bugeto.Application.Services.Finances.Queries.GetRequestPayForVerify;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asp_store_bugeto.Application.Intefaces.FacadPattern
{
    public interface IFinancesFacad
    {
        public IAddRequestPayService AddRequestPay { get; }
        public IGetRequestPayForVrify GetRequestPayForVrify { get; }
    }
}
