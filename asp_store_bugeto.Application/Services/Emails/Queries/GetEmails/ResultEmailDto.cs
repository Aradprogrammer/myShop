using System.Collections.Generic;

namespace asp_store_bugeto.Application.Services.Emails.Queries.GetEmails
{
    public class ResultEmailDto
    {
        public List<EmailsDto> DataList { get; set; }
        public int RowCount { get; set; }

    }
}
