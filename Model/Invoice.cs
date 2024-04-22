using Newtonsoft.Json;

namespace RichTextEditorMailMerge.Model
{
    public class Invoice
    {
        public string? InvoiceNumber { get; set; }
        public string? IssueDate { get; set; }
        public string? DueDate { get; set; }

        public UserDetails? CompanyDetails { get; set; }
        public UserDetails? CustomerDetails { get; set; }

    }
    public class UserDetails
    {
        public string? Name { get; set; }
        public string? Address { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
    }
}
