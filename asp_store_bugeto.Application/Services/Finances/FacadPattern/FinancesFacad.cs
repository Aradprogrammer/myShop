using asp_store_bugeto.Application.Intefaces.Contexts;
using asp_store_bugeto.Application.Intefaces.FacadPattern;
using asp_store_bugeto.Application.Services.Finances.Commands.AddRequestPay;
using asp_store_bugeto.Application.Services.Finances.Queries.GetRequestPayForVerify;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asp_store_bugeto.Application.Services.Finances.FacadPattern
{
    public class FinancesFacad : IFinancesFacad
    {
        private readonly IDataBaseContext _context;
        public FinancesFacad(IDataBaseContext context)
        {
            _context = context;
        }
        private AddRequestPayService AddRequestPayService;
        public IAddRequestPayService AddRequestPay
        {
            get
            {
                return AddRequestPayService = AddRequestPayService ?? new AddRequestPayService(_context);
            }
        }
        private GetRequestPayForVerify _getRequestPayForVrify;
        public IGetRequestPayForVrify GetRequestPayForVrify
        {
            get
            {
                return _getRequestPayForVrify = _getRequestPayForVrify ?? new GetRequestPayForVerify(_context);
            }
        }
    }
}
