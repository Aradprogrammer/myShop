using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using asp_store_bugeto.Application.Intefaces.FacadPattern;

namespace EndPoint.Site.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class EmailController : Controller
    {
        private readonly IEmailFacad _EmailFacad;
        
        public EmailController(IEmailFacad EmailFacad)
        {
            _EmailFacad = EmailFacad;
        }
        [HttpGet]
        public IActionResult Index(string serchkey, int page = 1)
        {
            var result = _EmailFacad.GetEmails.Execute(new() { Page = page, SearchKey = serchkey });
            ViewBag.SenderEmail = new SelectList(_EmailFacad.GetSenderEmail.Execute(new() { Page = 1, PageSize = 1000, SearchKey = "" }).Data.Senders, "Id", "Addres");
            return View(result.Data);

        }
        [HttpPost]
        public IActionResult EditeEmail(long Email_Id, string Email_Text, string Email_Titel, long Email_Sender)
        {
            return Json(_EmailFacad.EditeEmail.Execute(new() { EmailId = Email_Id, EmailText = Email_Text, EmailTitel = Email_Titel, SenderId = Email_Sender }));
        }
        [HttpPost]
        public IActionResult AddSenderEmail(string Email, string Password)
        {
            return Json(_EmailFacad.AddSenderEmail.Execute(new() { Address = Email, Password = Password }));
        }
        public IActionResult DeleteSenderEmail(long Id)
        {
            return Json(_EmailFacad.DeleteEmailSender.Execute(Id));
        }
        [HttpPost]
        public IActionResult EditSenderEmail(string Id, string Email, string Password)
        {
            return Json(_EmailFacad.EditSenderEmail.Execute(new() { Id = long.Parse(Id), Email = Email, Password = Password }));
        }
        [HttpGet]
        public IActionResult SenderEmailsList(string serchkey, int page = 1)
        {
            var result = _EmailFacad.GetSenderEmail.Execute(new() { Page = page, PageSize = 10, SearchKey = serchkey });
            return View(result.Data);
        }
    }
}
