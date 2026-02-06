using System;
using System.Collections.Generic;
using System.Text;

namespace Chemical_Inventory_Management_System.UI
{
    public  class Menu
    {
        public void MenuOptions() { 
        {
            ColoredFont styledFont = new ColoredFont();
            // setting up the color 
            Console.ForegroundColor = ConsoleColor.Green;
            styledFont.ColorFont(ConsoleColor.Green, "Chemical inventory Management System");
            
            styledFont.ColorFont(ConsoleColor.Blue, "1. Search Chemical");
            Console.WriteLine();
            styledFont.ColorFont(ConsoleColor.Blue, "2. Add New Chemical");
            Console.WriteLine();
            styledFont.ColorFont(ConsoleColor.Blue, "3. Restock Chemical");
            Console.WriteLine();
            styledFont.ColorFont(ConsoleColor.Blue, "4. Edit Chemical");
            Console.WriteLine();
            styledFont.ColorFont(ConsoleColor.Blue, "5. View Expiry Alerts");
            Console.WriteLine();
            styledFont.ColorFont(ConsoleColor.Blue, "6. View Low Stock");
            Console.WriteLine();
            styledFont.ColorFont(ConsoleColor.Blue, "7. Exit");
        }
    }
}
