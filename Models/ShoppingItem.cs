using System;
using System.Collections.Generic;
using System.Text;
using Chemical_Inventory_Management_System.Models.Enums;

namespace Chemical_Inventory_Management_System.Models
{
    public class ShoppingItem
    {
        public int ShippingId { get; set; } 
        public string? ChemicalName {  get; set; }
        public string? RequestedBy { get; set; }
        public DateTimeOffset RequestedDate { get; set; }
        public PriorityLevel Priority { get; set; }

        public OrderStatus Status { get; set; }
    }
}
