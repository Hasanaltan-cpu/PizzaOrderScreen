using Pizza_Order_Screen.Entities.Abstract;
using Pizza_Order_Screen.Entities.Concretes;
using Pizza_Order_Screen.Repository;
using System;
using System.Collections.Generic;

using System.Windows.Forms;

namespace Pizza_Order_Screen.Entities.StaticFunction
{
    public static class StaticList //We've created this class by using static list in terms of Object Oriented Programming Rules.


    {
        public static List<Order> orders = new List<Order>();
        public static List<Order> SelectedOrders = new List<Order>();
        public static List<PizzaMenu> menus = new List<PizzaMenu>()  //These 2 lists ares Generic List.
        {
       
        new PizzaMenu { MenuName ="HotPepper",Price=35.25m},
        new PizzaMenu { MenuName = "New York", Price = 35.25m },
        new PizzaMenu { MenuName = "Chicago", Price = 35.25m },
        new PizzaMenu { MenuName = "istanbul", Price = 35.25m },
        };

        public static List<IExtras> extras = new List<IExtras>()
        {
            new IExtras {ExtraName="Onion",Price=1.15m},
            new IExtras {ExtraName="Mushroom",Price=1.75m},
            new IExtras{ExtraName="Cheddar",Price=3.23m},
            new IExtras{ExtraName="Chicken Nut",Price=3.57m},
            new IExtras{ExtraName="Sausage",Price=2.75m},
            new IExtras{ExtraName="Corn",Price=1.75m},
        };

       


    }
}
