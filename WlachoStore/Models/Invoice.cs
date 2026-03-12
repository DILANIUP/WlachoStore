namespace WlachoStore.Models
{
    public class Invoice
    {
        public int InvoiceId { get; set; }
        public DateTime Date { get; set; }
        public decimal Total { get; set; }
        public int InvoiceNumber { get; set; }
        public int OrderId { get; set; }
        public int UserId { get; set; }
        public int PaymentMethodId { get; set; }
        public int TransactionId { get; set; }
        public Order Order { get; set; }
        public User User { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public Transaction Transaction { get; set; }
    }
}