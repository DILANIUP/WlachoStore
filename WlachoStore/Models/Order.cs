using WlachoStore.Enums;

namespace WlachoStore.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public DateTime Date { get; set; }
        public Orderstatus Status { get; set; }
        public decimal Total { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public List<OrderItem> OrderItems { get; set; }
        public Transaction Transaction { get; set; }
        public Invoice Invoice { get; set; }
    }
}