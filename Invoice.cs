using Syncfusion.XPS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.ListView;

namespace HSD_manager
{
    public partial class Invoice : Form
    {
        public Invoice()
        {
            InitializeComponent();
            ListItemViewCartInitializer initializer = new ListItemViewCartInitializer();
            listv4.Items.AddRange(initializer.Items);

            int sum = 0;
            foreach (ListViewItem item in listv4.Items)
            {
                sum += Convert.ToInt32(item.SubItems[5].Text);
            }
            label3.Text = sum.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
