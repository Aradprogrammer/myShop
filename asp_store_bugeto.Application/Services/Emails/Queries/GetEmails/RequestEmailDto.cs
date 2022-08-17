namespace asp_store_bugeto.Application.Services.Emails.Queries.GetEmails
{
    public class RequestEmailDto
    {
        public int Page { get; set; } = 1;
        public string SearchKey { get; set; }
    }
}
