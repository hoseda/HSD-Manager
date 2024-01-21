namespace HSD_manager
{
    partial class CartPage
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
            label1 = new Label();
            listv3 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            button1 = new Button();
            cartdel = new Button();
            chnumber = new Button();
            label2 = new Label();
            totalcost = new Label();
            pay = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 34);
            label1.Name = "label1";
            label1.Size = new Size(35, 15);
            label1.TabIndex = 0;
            label1.Text = "Cart :";
            // 
            // listv3
            // 
            listv3.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6 });
            listv3.FullRowSelect = true;
            listv3.GridLines = true;
            listv3.Location = new Point(12, 79);
            listv3.MultiSelect = false;
            listv3.Name = "listv3";
            listv3.Size = new Size(801, 361);
            listv3.TabIndex = 1;
            listv3.UseCompatibleStateImageBehavior = false;
            listv3.View = View.Details;
            listv3.ItemSelectionChanged += listv3_ItemSelectionChanged;
            listv3.MouseClick += listv3_MouseClick;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Name";
            columnHeader2.Width = 130;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Description";
            columnHeader3.Width = 250;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Price";
            columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Number";
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Total Pirce";
            columnHeader6.Width = 120;
            // 
            // button1
            // 
            button1.Location = new Point(12, 503);
            button1.Name = "button1";
            button1.Size = new Size(75, 38);
            button1.TabIndex = 2;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // cartdel
            // 
            cartdel.Enabled = false;
            cartdel.Location = new Point(258, 503);
            cartdel.Name = "cartdel";
            cartdel.Size = new Size(75, 38);
            cartdel.TabIndex = 3;
            cartdel.Text = "Delete";
            cartdel.UseVisualStyleBackColor = true;
            cartdel.Click += cartdel_Click;
            // 
            // chnumber
            // 
            chnumber.Enabled = false;
            chnumber.Location = new Point(363, 503);
            chnumber.Name = "chnumber";
            chnumber.Size = new Size(75, 41);
            chnumber.TabIndex = 4;
            chnumber.Text = "Change Number";
            chnumber.UseVisualStyleBackColor = true;
            chnumber.Click += chnumber_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(574, 476);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 6;
            label2.Text = "Total Cost :";
            // 
            // totalcost
            // 
            totalcost.AutoSize = true;
            totalcost.Location = new Point(670, 476);
            totalcost.Name = "totalcost";
            totalcost.Size = new Size(13, 15);
            totalcost.TabIndex = 7;
            totalcost.Text = "0";
            // 
            // pay
            // 
            pay.Enabled = false;
            pay.Location = new Point(543, 503);
            pay.Name = "pay";
            pay.Size = new Size(236, 38);
            pay.TabIndex = 8;
            pay.Text = "Proceed to Checkout";
            pay.UseVisualStyleBackColor = true;
            pay.Click += pay_Click;
            // 
            // CartPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(825, 556);
            Controls.Add(pay);
            Controls.Add(totalcost);
            Controls.Add(label2);
            Controls.Add(chnumber);
            Controls.Add(cartdel);
            Controls.Add(button1);
            Controls.Add(listv3);
            Controls.Add(label1);
            MaximizeBox = false;
            MaximumSize = new Size(841, 595);
            MinimizeBox = false;
            MinimumSize = new Size(841, 595);
            Name = "CartPage";
            Text = " ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListView listv3;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private Button button1;
        private Button cartdel;
        private Button chnumber;
        private Label label2;
        private Label totalcost;
        private Button pay;
    }
}