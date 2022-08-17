namespace asp_store_bugeto.Application.Services.Emails.Queries.GetSenderEmail
{
    public class RequestSenderDto
    {
        public int Page { get; set; }
        public int PageSize { get; set; }
        public string SearchKey { get; set; }
    }
}
