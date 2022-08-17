using asp_store_bugeto.Application.Services.Emails.Commands.AddSenderEmail;
using asp_store_bugeto.Application.Services.Emails.Commands.DeleteSenderEmail;
using asp_store_bugeto.Application.Services.Emails.Commands.EditeEmail;
using asp_store_bugeto.Application.Services.Emails.Commands.EditSenderEmail;
using asp_store_bugeto.Application.Services.Emails.Commands.SendEmail;
using asp_store_bugeto.Application.Services.Emails.Queries.GetEmails;
using asp_store_bugeto.Application.Services.Emails.Queries.GetSenderEmail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asp_store_bugeto.Application.Intefaces.FacadPattern
{
    public interface IEmailFacad
    {
        public IAddSenderEmailService AddSenderEmail { get; }
        public IDeleteEmailSenderService DeleteEmailSender { get; }
        public IEditeEmailService EditeEmail { get; }
        public IEditSenderEmailService EditSenderEmail { get; }
        public ISendEmailService SendEmail { get; }
        public IGetEmailsService GetEmails { get; }
        public IGetSenderEmailService GetSenderEmail { get; }
    }
}
