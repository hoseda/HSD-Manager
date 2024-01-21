namespace HSD_manager
{
    partial class Storage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Storage));
            label1 = new Label();
            listv2 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            backbtn = new Button();
            gotocartbtn = new Button();
            addbtn = new Button();
            delbtn = new Button();
            editbtn = new Button();
            addtocartbtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Location = new Point(13, 36);
            label1.Name = "label1";
            label1.Size = new Size(90, 15);
            label1.TabIndex = 0;
            label1.Text = "List of Product :";
            // 
            // listv2
            // 
            listv2.BorderStyle = BorderStyle.FixedSingle;
            listv2.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5 });
            listv2.FullRowSelect = true;
            listv2.GridLines = true;
            listv2.Location = new Point(13, 80);
            listv2.MultiSelect = false;
            listv2.Name = "listv2";
            listv2.Size = new Size(796, 405);
            listv2.Sorting = SortOrder.Ascending;
            listv2.TabIndex = 3;
            listv2.UseCompatibleStateImageBehavior = false;
            listv2.View = View.Details;
            listv2.ColumnClick += listv2_ColumnClick;
            listv2.ItemSelectionChanged += listv2_ItemSelectionChanged;
            listv2.MouseClick += listv2_MouseClick;
            listv2.MouseDoubleClick += listv2_MouseDoubleClick;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "ID";
            columnHeader1.Width = 50;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Name";
            columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Description";
            columnHeader3.Width = 330;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Price";
            columnHeader4.Width = 150;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Quantity";
            columnHeader5.Width = 100;
            // 
            // backbtn
            // 
            backbtn.Location = new Point(13, 511);
            backbtn.Name = "backbtn";
            backbtn.Size = new Size(90, 32);
            backbtn.TabIndex = 4;
            backbtn.Text = "Back";
            backbtn.UseVisualStyleBackColor = true;
            backbtn.Click += button1_Click_1;
            // 
            // gotocartbtn
            // 
            gotocartbtn.Location = new Point(722, 511);
            gotocartbtn.Name = "gotocartbtn";
            gotocartbtn.Size = new Size(90, 32);
            gotocartbtn.TabIndex = 5;
            gotocartbtn.Text = "Go to Cart";
            gotocartbtn.UseVisualStyleBackColor = true;
            gotocartbtn.Click += gotocartbtn_Click;
            // 
            // addbtn
            // 
            addbtn.Location = new Point(159, 511);
            addbtn.Name = "addbtn";
            addbtn.Size = new Size(109, 32);
            addbtn.TabIndex = 6;
            addbtn.Text = "Add New Product";
            addbtn.UseVisualStyleBackColor = true;
            addbtn.Click += button3_Click;
            // 
            // delbtn
            // 
            delbtn.Enabled = false;
            delbtn.Location = new Point(426, 511);
            delbtn.Name = "delbtn";
            delbtn.Size = new Size(90, 32);
            delbtn.TabIndex = 7;
            delbtn.Text = "Delete";
            delbtn.UseVisualStyleBackColor = true;
            delbtn.Click += delbtn_Click;
            // 
            // editbtn
            // 
            editbtn.Enabled = false;
            editbtn.Location = new Point(300, 511);
            editbtn.Name = "editbtn";
            editbtn.Size = new Size(90, 32);
            editbtn.TabIndex = 8;
            editbtn.Text = "Edit";
            editbtn.UseVisualStyleBackColor = true;
            editbtn.Click += editbtn_Click;
            // 
            // addtocartbtn
            // 
            addtocartbtn.Enabled = false;
            addtocartbtn.Location = new Point(546, 511);
            addtocartbtn.Name = "addtocartbtn";
            addtocartbtn.Size = new Size(98, 32);
            addtocartbtn.TabIndex = 9;
            addtocartbtn.Text = "Add to Cart";
            addtocartbtn.UseVisualStyleBackColor = true;
            addtocartbtn.Click += addtocartbtn_Click;
            // 
            // Storage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(825, 556);
            Controls.Add(addtocartbtn);
            Controls.Add(editbtn);
            Controls.Add(delbtn);
            Controls.Add(addbtn);
            Controls.Add(gotocartbtn);
            Controls.Add(backbtn);
            Controls.Add(listv2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(841, 595);
            MinimizeBox = false;
            MinimumSize = new Size(841, 595);
            Name = "Storage";
            Padding = new Padding(10);
            ShowInTaskbar = false;
            Text = "Storage";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListView listv2;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private Button backbtn;
        private Button gotocartbtn;
        private Button addbtn;
        private Button delbtn;
        private Button editbtn;
        private ColumnHeader columnHeader5;
        private Button addtocartbtn;
    }
}