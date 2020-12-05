using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza_Order_Screen.Entities.Abstract
{
     public class PizzaMenu 
    {
        public string MenuName { get; set; }
        public decimal Price { get; set; }
        public override string ToString()
        {
            return MenuName + "Menu";
        }

       
    }
}
