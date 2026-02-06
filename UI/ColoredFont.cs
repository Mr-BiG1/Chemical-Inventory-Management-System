using System;
using System.Collections.Generic;
using System.Text;

namespace Chemical_Inventory_Management_System.UI
{
    public class ColoredFont
    {
        public void ColorFont(ConsoleColor color,string context)
        {
            try 
            {
                var previous = Console.ForegroundColor;
                Console.ForegroundColor = color;
                Console.WriteLine(context);
                Console.ForegroundColor = previous;
            } catch (Exception e) 
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(e); 
            }
        }
    }
}
