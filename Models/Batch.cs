using System;
using System.Collections.Generic;
using System.Text;

namespace Chemical_Inventory_Management_System.Models
{
    public class Batch
    {
        // child
        public int Id { get; set; }

        // Foreign Key
        public int ChemicalId { get; set; }
        // setting up refrence 
        public Chemical? Chemical { get; set; }
        // by adding a ? makes it nullable 
        public string? SupplierName { get; set; }
        public int Quantity { get; set; }

        // setting up time related datas

        public DateTimeOffset ManufactureDate { get; set; }
        public DateTimeOffset ExpiryDate { get; set; }
        public DateTimeOffset ReceivedDate { get; set; }
    }
}
