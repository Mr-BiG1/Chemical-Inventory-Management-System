using System;
using System.Collections.Generic;
using System.Text;
using Chemical_Inventory_Management_System.Models.Enums;

namespace Chemical_Inventory_Management_System.Models
{
    // main
    public class Chemical
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;   // cant be optional 
        public string? Storage {  get; set; } 
        //public String? HazardLevel { get; set; }
        public HazardLevel Level { get; set; }
        //public string StorageLoccation { get; set; }
        public StorageLoccation Location { get; set; }    

        // setting up the relation
        public List<Batch> Batches { get; set; } = new();
    }
}
