using asp_store_bugeto.Application.Intefaces.Contexts;
using asp_store_bugeto.Application.Intefaces.FacadPattern;
using asp_store_bugeto.Application.Services.Carts.Commands.AddNewCart;
using asp_store_bugeto.Application.Services.Carts.Commands.RemoveCartItem;
using asp_store_bugeto.Application.Services.Carts.Queries.GetMyCart;
using asp_store_bugeto.Application.Services.Carts.Queries.GetCountItemFromCartByID;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asp_store_bugeto.Application.Services.Carts.FacadPattern
{
    public class CartFacad : ICartFacad
    {
        private readonly IDataBaseContext _context;
        public CartFacad(IDataBaseContext context)
        {
            _context = context;

        }

        private IAddNewCartItemService _AddNewCartItemService;
        public IAddNewCartItemService AddNewCartItemService
        {
            get
            {
                return _AddNewCartItemService = _AddNewCartItemService ?? new AddNewCartItemService(_context);
            }
        }

        private IRemoveCartItem _removeCartItem;
        public IRemoveCartItem RemoveCartItem
        {
            get
            {
                return _removeCartItem = _removeCartItem ?? new RemoveCartItem(_context);
            }
        }

        private IGetMyCartService _getMyCartService;
        public IGetMyCartService GetMyCart
        {
            get
            {
                return _getMyCartService = _getMyCartService ?? new GetMyCartService(_context);
            }
        }
        private IGetCountItemFromCartByID _getCountItemFromCartByID;
        public IGetCountItemFromCartByID GetCountItemFromCartByID
        {
            get
            {
                return _getCountItemFromCartByID = _getCountItemFromCartByID ?? new GetCountItemFromCartByID(_context);
            }
        }
    }
}
