namespace Pizza_Order_Screen
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.rdnSmall = new System.Windows.Forms.RadioButton();
            this.rdnBig = new System.Windows.Forms.RadioButton();
            this.rdnMiddle = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nmrPiece = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.OrderList = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbmenus = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lbltotalprice = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.flpExtraToppings = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrPiece)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(16, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(449, 197);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // rdnSmall
            // 
            this.rdnSmall.AutoSize = true;
            this.rdnSmall.Location = new System.Drawing.Point(16, 330);
            this.rdnSmall.Name = "rdnSmall";
            this.rdnSmall.Size = new System.Drawing.Size(61, 18);
            this.rdnSmall.TabIndex = 2;
            this.rdnSmall.TabStop = true;
            this.rdnSmall.Text = "Small";
            this.rdnSmall.UseVisualStyleBackColor = true;
            // 
            // rdnBig
            // 
            this.rdnBig.AutoSize = true;
            this.rdnBig.Location = new System.Drawing.Point(257, 330);
            this.rdnBig.Name = "rdnBig";
            this.rdnBig.Size = new System.Drawing.Size(46, 18);
            this.rdnBig.TabIndex = 2;
            this.rdnBig.TabStop = true;
            this.rdnBig.Text = "Big";
            this.rdnBig.UseVisualStyleBackColor = true;
            // 
            // rdnMiddle
            // 
            this.rdnMiddle.AutoSize = true;
            this.rdnMiddle.Location = new System.Drawing.Point(137, 330);
            this.rdnMiddle.Name = "rdnMiddle";
            this.rdnMiddle.Size = new System.Drawing.Size(68, 18);
            this.rdnMiddle.TabIndex = 2;
            this.rdnMiddle.TabStop = true;
            this.rdnMiddle.Text = "Middle";
            this.rdnMiddle.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 313);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 14);
            this.label1.TabIndex = 3;
            this.label1.Text = "Size";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 366);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 14);
            this.label2.TabIndex = 4;
            this.label2.Text = "Extra Toppings";
            // 
            // nmrPiece
            // 
            this.nmrPiece.Location = new System.Drawing.Point(179, 526);
            this.nmrPiece.Name = "nmrPiece";
            this.nmrPiece.Size = new System.Drawing.Size(182, 21);
            this.nmrPiece.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(102, 528);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 14);
            this.label3.TabIndex = 7;
            this.label3.Text = "Custom";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(367, 528);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 14);
            this.label4.TabIndex = 8;
            this.label4.Text = "Piece/Pieces";
            // 
            // OrderList
            // 
            this.OrderList.FormattingEnabled = true;
            this.OrderList.Location = new System.Drawing.Point(471, 23);
            this.OrderList.Name = "OrderList";
            this.OrderList.Size = new System.Drawing.Size(532, 407);
            this.OrderList.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(846, 435);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 44);
            this.button1.TabIndex = 10;
            this.button1.Text = "Order";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 14);
            this.label5.TabIndex = 11;
            this.label5.Text = "Menu";
            // 
            // cmbmenus
            // 
            this.cmbmenus.FormattingEnabled = true;
            this.cmbmenus.Location = new System.Drawing.Point(19, 250);
            this.cmbmenus.Name = "cmbmenus";
            this.cmbmenus.Size = new System.Drawing.Size(387, 21);
            this.cmbmenus.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(478, 449);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 14);
            this.label7.TabIndex = 14;
            this.label7.Text = "Total Price";
            // 
            // lbltotalprice
            // 
            this.lbltotalprice.AutoSize = true;
            this.lbltotalprice.Location = new System.Drawing.Point(587, 449);
            this.lbltotalprice.Name = "lbltotalprice";
            this.lbltotalprice.Size = new System.Drawing.Size(15, 14);
            this.lbltotalprice.TabIndex = 15;
            this.lbltotalprice.Text = "0";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(172, 553);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(197, 28);
            this.button2.TabIndex = 16;
            this.button2.Text = "Add Order Screen";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // flpExtraToppings
            // 
            this.flpExtraToppings.Location = new System.Drawing.Point(12, 399);
            this.flpExtraToppings.Name = "flpExtraToppings";
            this.flpExtraToppings.Size = new System.Drawing.Size(453, 112);
            this.flpExtraToppings.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OrangeRed;
            this.ClientSize = new System.Drawing.Size(1243, 593);
            this.Controls.Add(this.flpExtraToppings);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lbltotalprice);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbmenus);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.OrderList);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nmrPiece);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rdnMiddle);
            this.Controls.Add(this.rdnBig);
            this.Controls.Add(this.rdnSmall);
            this.Controls.Add(this.pictureBox2);
            this.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrPiece)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.RadioButton rdnSmall;
        private System.Windows.Forms.RadioButton rdnBig;
        private System.Windows.Forms.RadioButton rdnMiddle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nmrPiece;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox OrderList;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbmenus;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbltotalprice;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.FlowLayoutPanel flpExtraToppings;
    }
}

