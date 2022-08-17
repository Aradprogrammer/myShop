using asp_store_bugeto.Application.Intefaces.Contexts;
using asp_store_bugeto.Application.Intefaces.FacadPattern;
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

namespace asp_store_bugeto.Application.Services.Emails.FacadPattern
{
    public class EmailFacad : IEmailFacad
    {
        private readonly IDataBaseContext _context;
        public EmailFacad(IDataBaseContext context)
        {
            _context = context;
        }
        private AddSenderEmailService _addSenderEmailService;
        public IAddSenderEmailService AddSenderEmail
        {
            get
            {
                return _addSenderEmailService = _addSenderEmailService ?? new AddSenderEmailService(_context);
            }
        }
        private DeleteEmailSenderService _deleteEmailSender;
        public IDeleteEmailSenderService DeleteEmailSender
        {
            get
            {
                return _deleteEmailSender = _deleteEmailSender ?? new DeleteEmailSenderService(_context);
            }
        }
        private EditeEmailService _editeEmailService;
        public IEditeEmailService EditeEmail
        {
            get
            {
                return _editeEmailService = _editeEmailService ?? new EditeEmailService(_context);
            }
        }
        private EditSenderEmailService _editSenderEmailService;
        public IEditSenderEmailService EditSenderEmail
        {
            get
            {
                return _editSenderEmailService = _editSenderEmailService ?? new EditSenderEmailService(_context);
            }
        }

        private SendEmailService _sendEmailService;
        public ISendEmailService SendEmail
        {
            get
            {
                return _sendEmailService = _sendEmailService ?? new SendEmailService(_context);
            }
        }
        private GetEmailsService _getEmailsService;
        public IGetEmailsService GetEmails
        {
            get
            {
                return _getEmailsService = _getEmailsService ?? new GetEmailsService(_context);
            }
        }
        private GetSenderEmailService _getSenderEmail;
        public IGetSenderEmailService GetSenderEmail
        {
            get
            {
                return _getSenderEmail = _getSenderEmail ?? new GetSenderEmailService(_context);
            }
        }
    }
}
