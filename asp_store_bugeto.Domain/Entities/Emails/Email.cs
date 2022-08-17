namespace asp_store_bugeto.Domain.Entities.Emails
{
    public class Email
    {
        public long Id { get; set; }
        public string Text { get; set; }
        public string Titel { get; set; }
        public string Subject { get; set; }
        public string? URL { get; set; }
        public virtual SenderEmail SenderEmail { get; set; }
        public long? SenderEmailId { get; set; }
    }
}
