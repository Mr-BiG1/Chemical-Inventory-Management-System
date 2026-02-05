using System;
using System.Collections.Generic;
using System.Text;

namespace Chemical_Inventory_Management_System.Models
{
    public class Batch
    {
        public int BatchId { get; set; }
        public int chemicalId { get; set; }

        // by adding a ? makes it nullable 
        public string? SupplierName { get; set; }
        public int Quintity { get; set; }

        // setting up time related datas

        public DateTimeOffset ManufactureDate { get; set; }
        public DateTimeOffset ExpiryDate { get; set; }
        public DateTimeOffset ReceivedDate { get; set; }
    }
}
