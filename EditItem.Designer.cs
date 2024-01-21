namespace HSD_manager
{
    partial class EditItem
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
            textboxquantity1 = new TextBox();
            label4 = new Label();
            textboxprice1 = new TextBox();
            label3 = new Label();
            textboxdesc1 = new TextBox();
            label2 = new Label();
            textboxname1 = new TextBox();
            label1 = new Label();
            button2 = new Button();
            applybtn = new Button();
            SuspendLayout();
            // 
            // textboxquantity1
            // 
            textboxquantity1.BorderStyle = BorderStyle.FixedSingle;
            textboxquantity1.Location = new Point(106, 333);
            textboxquantity1.Name = "textboxquantity1";
            textboxquantity1.Size = new Size(134, 23);
            textboxquantity1.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 336);
            label4.Name = "label4";
            label4.Size = new Size(53, 15);
            label4.TabIndex = 14;
            label4.Text = "Quantity";
            // 
            // textboxprice1
            // 
            textboxprice1.BorderStyle = BorderStyle.FixedSingle;
            textboxprice1.Location = new Point(106, 267);
            textboxprice1.Name = "textboxprice1";
            textboxprice1.Size = new Size(134, 23);
            textboxprice1.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 269);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 12;
            label3.Text = "Price";
            // 
            // textboxdesc1
            // 
            textboxdesc1.BorderStyle = BorderStyle.FixedSingle;
            textboxdesc1.Location = new Point(106, 106);
            textboxdesc1.Multiline = true;
            textboxdesc1.Name = "textboxdesc1";
            textboxdesc1.Size = new Size(261, 110);
            textboxdesc1.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 108);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 10;
            label2.Text = "Description";
            // 
            // textboxname1
            // 
            textboxname1.BorderStyle = BorderStyle.FixedSingle;
            textboxname1.Location = new Point(106, 31);
            textboxname1.Name = "textboxname1";
            textboxname1.Size = new Size(261, 23);
            textboxname1.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 34);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 8;
            label1.Text = "Name";
            // 
            // button2
            // 
            button2.Location = new Point(223, 421);
            button2.Name = "button2";
            button2.Size = new Size(103, 42);
            button2.TabIndex = 17;
            button2.Text = "Cancle";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // applybtn
            // 
            applybtn.Location = new Point(72, 421);
            applybtn.Name = "applybtn";
            applybtn.Size = new Size(103, 42);
            applybtn.TabIndex = 16;
            applybtn.Text = "Apply";
            applybtn.UseVisualStyleBackColor = true;
            applybtn.Click += button1_Click;
            // 
            // EditItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(404, 475);
            ControlBox = false;
            Controls.Add(button2);
            Controls.Add(applybtn);
            Controls.Add(textboxquantity1);
            Controls.Add(label4);
            Controls.Add(textboxprice1);
            Controls.Add(label3);
            Controls.Add(textboxdesc1);
            Controls.Add(label2);
            Controls.Add(textboxname1);
            Controls.Add(label1);
            MaximizeBox = false;
            MaximumSize = new Size(420, 514);
            MinimizeBox = false;
            MinimumSize = new Size(420, 514);
            Name = "EditItem";
            Text = "EditItem";
            Shown += EditItem_Shown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textboxquantity1;
        private Label label4;
        private TextBox textboxprice1;
        private Label label3;
        private TextBox textboxdesc1;
        private Label label2;
        private TextBox textboxname1;
        private Label label1;
        private Button button2;
        private Button applybtn;
    }
}