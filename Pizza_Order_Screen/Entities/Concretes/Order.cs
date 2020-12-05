using Pizza_Order_Screen.Entities.Abstract;
using Pizza_Order_Screen.Enums;
using Pizza_Order_Screen.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza_Order_Screen.Entities.Concretes
{
    public class Order:PizzaMenu   //As you see,Parent Class is PizzaMenu.
    {
        public PizzaMenu SelectedMenu { get; set; }
        public Size size { get; set; } /// we benefits from Size enum class by adding this namespace .
       
        public List<IExtras> ExtraToppings { get; set; }
        public int Piece { get; set; }
        public decimal TotalPrice { get; set; }

        
        public void Calculate()
        {
            TotalPrice = 0;
            TotalPrice += SelectedMenu.Price;

            switch (size)
            {
                             
                case Size.Middle:
                    TotalPrice += TotalPrice * 0.30m;///Use m the las of "0.30" because of decimal type.
                    break;
                case Size.Big:
                    TotalPrice += TotalPrice * 0.45m;
                    break;

            }
            foreach (IExtras exToppings in ExtraToppings)
            {
                TotalPrice += exToppings.Price; /// We go around on the extraToppings and plus all price which is selected for extra items.
            }
            TotalPrice *= Piece; // this row works for selected more than 1 pizza.
        }

        

        public override string ToString()
        {
            if (ExtraToppings.Count < 1)
            {
                return string.Format("{0}Menu,{1}xPiece/Pieces,{2} Size,TotalPrice:{3}", SelectedMenu.MenuName, Piece, size.ToString(), TotalPrice.ToString());
                ///We use index logic as 0,1,2,3 on the string builder because of using less memory on the stack field of the RAM.
            }
            else
            {
                string exToppings = null;

                foreach (IExtras item in ExtraToppings)
                {
                    exToppings += item.ExtraName + ",";
                }

                exToppings = exToppings.Trim(',');

                return string.Format("{0} Menu,{1} x Piece,{2} Size, {3} Toppings,TotalPrice:{4}", SelectedMenu.MenuName, Piece, size.ToString(), exToppings, TotalPrice.ToString());
            }
        }
    }

}
