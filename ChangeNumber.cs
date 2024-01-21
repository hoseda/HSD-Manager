using DB;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HSD_manager
{
    public partial class ChangeNumber : Form
    {
        private ListViewItem? _data;
        public ListViewItem GetPerviuos
        {
            get { return _data!; }
            set { _data = value; }
        }

        private int _number = 0;

        public int Number
        {
            get => _number;
            set => _number = value;
        }
        public ChangeNumber()
        {
            InitializeComponent();

        }

        private void button4_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void ChangeNumber_Shown(object sender, EventArgs e)
        {
            vallable.Text = GetPerviuos.SubItems[4].Text;
            Number = Convert.ToInt32(GetPerviuos.SubItems[4].Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Database db = new Database();
            int quantity = db.GetCartItem(Convert.ToInt32(GetPerviuos.Text)).GetProduct.Quantity;
            if (Number < quantity)
            {
                Number++;
            }

            vallable.Text = Number.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int number = Number;
            GetPerviuos.SubItems[4].Text = number.ToString();
            GetPerviuos.SubItems[5].Text = (number * Convert.ToInt32(GetPerviuos.SubItems[3].Text)).ToString();
            Database db = new Database();
            CartItem item = db.GetCartItem(Convert.ToInt32(GetPerviuos.Text));
            item.Number = number;
            db.UpdateCartItem(item);
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Number > 0)
            {
                Number--;
            }
            vallable.Text = Number.ToString();
        }
    }
}
