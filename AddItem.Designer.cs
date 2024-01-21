namespace HSD_manager
{
    partial class AddItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddItem));
            label1 = new Label();
            textboxname = new TextBox();
            textboxdesc = new TextBox();
            label2 = new Label();
            textboxprice = new TextBox();
            label3 = new Label();
            textboxquantity = new TextBox();
            label4 = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 34);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // textboxname
            // 
            textboxname.BorderStyle = BorderStyle.FixedSingle;
            textboxname.Location = new Point(102, 31);
            textboxname.Name = "textboxname";
            textboxname.PlaceholderText = "name of product";
            textboxname.Size = new Size(261, 23);
            textboxname.TabIndex = 1;
            // 
            // textboxdesc
            // 
            textboxdesc.BorderStyle = BorderStyle.FixedSingle;
            textboxdesc.Location = new Point(102, 106);
            textboxdesc.Multiline = true;
            textboxdesc.Name = "textboxdesc";
            textboxdesc.PlaceholderText = "describe the product";
            textboxdesc.Size = new Size(261, 110);
            textboxdesc.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 108);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 2;
            label2.Text = "Description";
            // 
            // textboxprice
            // 
            textboxprice.BorderStyle = BorderStyle.FixedSingle;
            textboxprice.Location = new Point(102, 267);
            textboxprice.Name = "textboxprice";
            textboxprice.PlaceholderText = "     price by dollar";
            textboxprice.Size = new Size(134, 23);
            textboxprice.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 269);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 4;
            label3.Text = "Price";
            // 
            // textboxquantity
            // 
            textboxquantity.BorderStyle = BorderStyle.FixedSingle;
            textboxquantity.Location = new Point(102, 333);
            textboxquantity.Name = "textboxquantity";
            textboxquantity.PlaceholderText = "number of products";
            textboxquantity.Size = new Size(134, 23);
            textboxquantity.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 336);
            label4.Name = "label4";
            label4.Size = new Size(53, 15);
            label4.TabIndex = 6;
            label4.Text = "Quantity";
            // 
            // button1
            // 
            button1.Location = new Point(70, 413);
            button1.Name = "button1";
            button1.Size = new Size(103, 42);
            button1.TabIndex = 8;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(221, 413);
            button2.Name = "button2";
            button2.Size = new Size(103, 42);
            button2.TabIndex = 9;
            button2.Text = "Cancle";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // AddItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(404, 475);
            ControlBox = false;
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textboxquantity);
            Controls.Add(label4);
            Controls.Add(textboxprice);
            Controls.Add(label3);
            Controls.Add(textboxdesc);
            Controls.Add(label2);
            Controls.Add(textboxname);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(420, 514);
            MinimizeBox = false;
            MinimumSize = new Size(420, 514);
            Name = "AddItem";
            ShowInTaskbar = false;
            Text = "Add new Product";
            TopMost = true;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textboxname;
        private TextBox textboxdesc;
        private Label label2;
        private TextBox textboxprice;
        private Label label3;
        private TextBox textboxquantity;
        private Label label4;
        private Button button1;
        private Button button2;
    }
}