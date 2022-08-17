using System.Collections.Generic;

namespace asp_store_bugeto.Application.Services.Emails.Queries.GetSenderEmail
{
    public class SendersEmailDto
    {
        public int CountRow { get; set; }
        public List<SenderDto> Senders { get; set; }
    }
}
