using System;
using System.Collections.Generic;
using System.Text;
using Chemical_Inventory_Management_System.Models.Enums;

namespace Chemical_Inventory_Management_System.Models
{
    public class Chemical
    {
        public int Id { get; set; }
        public string? Name { get; set;  }   
        public string? Storage {  get; set; } 
        //public String? HazardLevel { get; set; }
        public HazardLevel leve { get; set; }
        //public string StorageLoccation { get; set; }
        public StorageLoccation location { get; set; }    
    }
}
