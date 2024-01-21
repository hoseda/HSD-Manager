namespace HSD_manager
{
    partial class ChangeNumber
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
            vallable = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 19);
            label1.Name = "label1";
            label1.Size = new Size(101, 15);
            label1.TabIndex = 0;
            label1.Text = "Change Number :";
            // 
            // vallable
            // 
            vallable.AutoSize = true;
            vallable.Location = new Point(136, 57);
            vallable.Name = "vallable";
            vallable.Size = new Size(13, 15);
            vallable.TabIndex = 1;
            vallable.Text = "0";
            // 
            // button1
            // 
            button1.Font = new Font("SF Pro Display", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(188, 49);
            button1.Name = "button1";
            button1.Size = new Size(34, 29);
            button1.TabIndex = 2;
            button1.Text = "+";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("SF Pro Display", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(67, 49);
            button2.Name = "button2";
            button2.Size = new Size(34, 29);
            button2.TabIndex = 3;
            button2.Text = "-";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.DialogResult = DialogResult.OK;
            button3.Location = new Point(47, 97);
            button3.Name = "button3";
            button3.Size = new Size(75, 31);
            button3.TabIndex = 4;
            button3.Text = "Change";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.DialogResult = DialogResult.Cancel;
            button4.Location = new Point(170, 97);
            button4.Name = "button4";
            button4.Size = new Size(75, 31);
            button4.TabIndex = 5;
            button4.Text = "Cancle";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // ChangeNumber
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(295, 144);
            ControlBox = false;
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(vallable);
            Controls.Add(label1);
            MaximumSize = new Size(311, 183);
            MinimumSize = new Size(311, 183);
            Name = "ChangeNumber";
            Text = "ChangeNumber";
            Shown += ChangeNumber_Shown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label vallable;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}