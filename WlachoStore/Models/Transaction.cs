using WlachoStore.Enums;

namespace WlachoStore.Models
{
    public class Transaction
    {
        public int TransactionId { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
        public TransactionStatus Status { get; set; }
        public int PaymentMethodId { get; set; }
        public int OrderId { get; set; }
        public Order Order { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public Invoice Invoice { get; set; }
    }
}