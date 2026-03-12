using WlachoStore.Enums;

namespace WlachoStore.Models
{
    public class PaymentMethod
    {
        public int PaymentMethodId { get; set; }
        public PaymentType Type { get; set; }
        public PaymentStatus Status { get; set; }
        public List<Transaction> Transactions { get; set; }
        public List<Invoice> Invoices { get; set; }
    }
}