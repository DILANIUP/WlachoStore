using System.ComponentModel.DataAnnotations;
using WlachoStore.Enums;

namespace WlachoStore.Models
{
    public class Inventory
    {
        [Key]
        public int MovementId { get; set; }
        public int Quantity { get; set; }
        public InventoryType Type { get; set; }
        public DateTime Date { get; set; }
        public string Reason { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        
    }
}