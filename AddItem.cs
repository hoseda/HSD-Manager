using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

using DB;
using Models;

namespace HSD_manager
{
    public partial class AddItem : Form
    {
        public AddItem()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public ListViewItem? GetValue { get; set; }

        private void button1_Click(object sender, EventArgs e)
        {
            bool _name = string.IsNullOrEmpty(textboxname.Text);
            bool _desc = string.IsNullOrEmpty(textboxdesc.Text);
            bool _price = string.IsNullOrEmpty(textboxprice.Text);
            bool _quantity = string.IsNullOrEmpty(textboxquantity.Text);

            if (_name || _desc || _price || _quantity)
            {
                return;
            }

            Database db = new Database();
            int c = db.GetProductsCount();

            if (Convert.ToInt32(textboxprice.Text) <= 0 || Convert.ToInt32(textboxquantity.Text) <= 0) return;

            ListViewItem item = new ListViewItem(c.ToString());
            item.SubItems.Add(textboxname.Text);
            item.SubItems.Add(textboxdesc.Text);
            item.SubItems.Add(textboxprice.Text);
            item.SubItems.Add(textboxquantity.Text);

            Product p = new Product(c, textboxname.Text, textboxdesc.Text, Convert.ToInt32(textboxprice.Text), Convert.ToInt32(textboxquantity.Text));
            db.SaveProduct(p);

            textboxname.Clear();
            textboxdesc.Clear();
            textboxprice.Clear();
            textboxquantity.Clear();

            this.GetValue = item;
            this.DialogResult = DialogResult.OK;
            this.Close();


        }
    }
}
