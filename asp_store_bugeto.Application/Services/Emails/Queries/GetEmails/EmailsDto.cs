namespace asp_store_bugeto.Application.Services.Emails.Queries.GetEmails
{
    public class EmailsDto
    {
        public long Id { get; set; }
        public string Text { get; set; }
        public string Titel { get; set; }
        public string SenderEmailAddress { get; set; }
        public long SenderEmailId { get; set; }
        public string Subject { get; set; }

    }
}
