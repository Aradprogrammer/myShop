using asp_store_bugeto.Application.Intefaces.FacadPattern;
using Dto.Payment;
using EndPoint.Site.Utilities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using ZarinPal.Class;

namespace EndPoint.Site.Controllers
{
    [Authorize("Customer")]
    public class PayController : Controller
    {
        private readonly IFinancesFacad _FinancesFacad;
        private readonly Payment _payment;
        private readonly Authority _authority;
        private readonly Transactions _transactions;
        public PayController(IFinancesFacad financesFacad)
        {
            _FinancesFacad = financesFacad;
            var expose = new Expose();
            _payment = expose.CreatePayment();
            _authority = expose.CreateAuthority();
            _transactions = expose.CreateTransactions();
        }
        public async Task<IActionResult> Index(long cartid)
        {
            Guid browserid = Guid.Parse(new DefauletMethodCoockies().TakeBrowserId(HttpContext));
            long? userid = ClaimUtilities.GetUserID(User);
            var pay = _FinancesFacad.AddRequestPay.Execute(new() { BrowserId = browserid, UserID = userid.Value, CartID = cartid });
            if (pay.IsSuccess)
            {
                var result = await _payment.Request(new DtoRequest()
                {
                    Mobile = "09121112222",
                    CallbackUrl = "https://" + HttpContext.Request.Host.Value + $"/pay/verify?guid={pay.Data.PayGuid}",
                    Description = $"تسویه حساب سبد خرید به شماره {pay.Data.RequestPayId}",
                    Email = pay.Data.UserEmail,
                    Amount = pay.Data.Amount,
                    MerchantId = "XXXXXXXX-XXXX-XXXX-XXXX-XXXXXXXXXXXX"
                }, ZarinPal.Class.Payment.Mode.sandbox);
                return Redirect($"https://sandbox.zarinpal.com/pg/StartPay/{result.Authority}");
            }
            else
            {
                RedirectToAction("index", "carts");
            }




            return View();
        }
        public async Task<IActionResult> verify(Guid guid, string authority, string status)
        {
            var pay = _FinancesFacad.GetRequestPayForVrify.Execute(guid);
            if (pay.IsSuccess)
            {
                var verification = await _payment.Verification(new DtoVerification
                {
                    Amount = pay.Data.Amount,
                    MerchantId = "XXXXXXXX-XXXX-XXXX-XXXX-XXXXXXXXXXXX",
                    Authority = authority
                }, Payment.Mode.sandbox);
                if (verification.Status == 100)
                {
                    
                }
                else
                {

                }
                return View();
            }
            else
            {
                return View("NotFound_Pay");
            }

        }
    }
}
