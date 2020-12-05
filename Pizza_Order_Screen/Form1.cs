using Pizza_Order_Screen.Entities.Abstract;
using Pizza_Order_Screen.Repository;
using System;
using Pizza_Order_Screen.Entities.StaticFunction;
using System.Windows.Forms;
using Pizza_Order_Screen.Entities.Concretes;
using System.Collections.Generic;

namespace Pizza_Order_Screen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();
        }

       
        public decimal TotalCalculate()
        {
            decimal totalCalculate = 0;
            for (int i = 0; i < OrderList.Items.Count; i++)
            {
                Order order = (Order)OrderList.Items[i];
                totalCalculate += order.TotalPrice;

            }
            lbltotalprice.Text = totalCalculate.ToString();
            return totalCalculate;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
         
            
            
            foreach (PizzaMenu item in StaticList.menus )
            {
                cmbmenus.Items.Add(item);

            }
            foreach (IExtras item in StaticList.extras )
            {
                flpExtraToppings.Controls.Add(new CheckBox()
                {
                    Text = item.ExtraName,
                    Tag = item
                }
                );

            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Order newOrder = new Order();
            newOrder.SelectedMenu = (PizzaMenu)cmbmenus.SelectedItem;
            if (rdnSmall.Checked)
            {
                newOrder.size = Enums.Size.Small;
            }
            else if (rdnMiddle.Checked)
            {
                newOrder.size = Enums.Size.Middle;
            }
            else if (rdnBig.Checked)
            {
                newOrder.size = Enums.Size.Big;
            }

            newOrder.Piece = Convert.ToInt32(nmrPiece.Value);
            newOrder.Calculate();
            StaticList.SelectedOrders.Add(newOrder);
            StaticList.orders.Add(newOrder);
            OrderList.Items.Add(newOrder);
            TotalCalculate();
            
           }
   

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Total Order Price:" + TotalCalculate().ToString() + "Are you sure?", "Sipariş Bilgisi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult==DialogResult.Yes)
            {
                OrderList.Items.Clear();
                StaticList.SelectedOrders.Clear();
                TotalCalculate();
                MessageBox.Show("Ordered has been Succesfull.");
                Function.Eraser(this.Controls);

            }
            else
            {
                MessageBox.Show("Order has been Canceled");
                Function.Eraser(this.Controls);
                OrderList.Items.Clear();
                lbltotalprice.Text = String.Empty;
            }
        }
    }
}
