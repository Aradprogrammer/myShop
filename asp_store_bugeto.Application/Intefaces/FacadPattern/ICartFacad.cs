using asp_store_bugeto.Application.Services.Carts.Commands.AddNewCart;
using asp_store_bugeto.Application.Services.Carts.Commands.RemoveCartItem;
using asp_store_bugeto.Application.Services.Carts.Queries.GetCountItemFromCartByID;
using asp_store_bugeto.Application.Services.Carts.Queries.GetMyCart;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asp_store_bugeto.Application.Intefaces.FacadPattern
{
    public interface ICartFacad
    {
        public IAddNewCartItemService AddNewCartItemService{ get; }
        public IRemoveCartItem RemoveCartItem{ get; }
        public IGetMyCartService GetMyCart{ get; }
        public IGetCountItemFromCartByID GetCountItemFromCartByID { get; }
    }
}
