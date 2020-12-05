using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza_Order_Screen.Entities.StaticFunction
{
    public static class Function //We ve created an Eraser Function.
    {
        public static void Eraser(Control.ControlCollection collection) 
        { 
            
            foreach (Control item in collection)
            {
                if (item is TextBox)   ///In this row we ve created an eraser  that it clears after took a order for all checkbox on the form1.
                {
                    TextBox txt = (TextBox)item;
                    txt.Clear();
                }
                else if (item is CheckBox)   ///In this row we ve created an eraser that it clears after took a order for all checkbox on the form1.
                {
                    CheckBox chk = (CheckBox)item;
                    chk.Checked = false;

                }
                else if (item is RadioButton)
                {
                    RadioButton rdn = (RadioButton)item; // By using this code we make this radiobutton can be born true on the "Small Size" otherwise application can give random.
                    if (rdn.Name == "rdnSmall")
                    {
                        rdn.Checked = true;
                    }
                    else
                    {
                        rdn.Checked = false;
                    }
                }
                else if (item is NumericUpDown)    ///We did this value 1 because customer can not order "0" pizza.
                {
                    NumericUpDown nmr = (NumericUpDown)item;
                    nmr.Value = 1;

                }
                else if (item is GroupBox) 
                {
                    GroupBox grp = (GroupBox)item;
                    Eraser(grp.Controls);
                }
                else if (item is FlowLayoutPanel)
                {
                    FlowLayoutPanel flp = (FlowLayoutPanel)item;
                    Eraser(flp.Controls);

                }
                else if (item is ComboBox)
                {
                    ComboBox cmb = (ComboBox)item;
                    cmb.SelectedIndex = 0;
                }
            } 
           

        }
	
	

	}
  
}
