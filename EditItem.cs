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
    public partial class EditItem : Form
    {
        public EditItem()
        {
            InitializeComponent();
        }
        private ListViewItem? _data;
        public ListViewItem getPerviuos
        {
            get { return _data!; }
            set { _data = value; }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditItem_Shown(object sender, EventArgs e)
        {
            var data = getPerviuos;
            textboxname1.Text = data.SubItems[1].Text;
            textboxdesc1.Text = data.SubItems[2].Text;
            textboxprice1.Text = data.SubItems[3].Text;
            textboxquantity1.Text = data.SubItems[4].Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var data = getPerviuos;
            data.SubItems[1].Text = textboxname1.Text;
            data.SubItems[2].Text = textboxdesc1.Text;
            data.SubItems[3].Text = textboxprice1.Text;
            data.SubItems[4].Text = textboxquantity1.Text;

            if (Convert.ToInt32(textboxprice1.Text) <= 0 || Convert.ToInt32(textboxquantity1.Text) <= 0) return;

            Database db = new Database();
            int _id = Convert.ToInt32(data.Text);
            int _price = Convert.ToInt32(data.SubItems[3].Text);
            int _quantity = Convert.ToInt32(data.SubItems[4].Text);
            string _name = data.SubItems[1].Text;
            string _description = data.SubItems[2].Text;

            Product p = new Product(_id, _name, _description, _price, _quantity);
            db.UpdateProduct(p);

            this.Close();

        }
    }
}
