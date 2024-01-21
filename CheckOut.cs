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
using static System.Windows.Forms.ListView;

namespace HSD_manager
{
    public partial class CheckOut : Form
    {
        public CheckOut()
        {
            InitializeComponent();
        }
        private ListViewItemCollection? items;
        public ListViewItemCollection GetItems
        {
            get { return items!; }
            set { items = value; }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Database db = new Database();
            var items = GetItems;
            foreach (ListViewItem item in items)
            {
                int id = Convert.ToInt32(item.Text);
                Product product = db.GetProduct(id);
                CartItem cartItem = db.GetCartItem(id);
                product = product.CopyWith(quantity: product.Quantity - cartItem.Number);
                db.UpdateProduct(product);
                db.DeleteCart(id);
            }


        }
    }
}
