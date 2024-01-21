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
    public partial class CartPage : Form
    {
        private ListItemViewCartInitializer initializer;
        public CartPage()
        {
            InitializeComponent();
            initializer = new ListItemViewCartInitializer();
            listv3.Items.AddRange(initializer.Items);
            UpdateForm();

        }



        public void PaymentMethod()
        {
            Database db = new Database();
            int c = db.GetCartItemsCount();
            if (c > 0)
            {
                pay.Enabled = true;
            }
            else
            {
                pay.Enabled = false;

            }
        }

        public void TotalCost()
        {
            int sum = 0;
            foreach (ListViewItem item in listv3.Items)
            {
                sum += Convert.ToInt32(item.SubItems[5].Text);
            }
            totalcost.Text = sum.ToString();
        }

        private void UpdateForm()
        {

            TotalCost();
            PaymentMethod();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void listv3_MouseClick(object sender, MouseEventArgs e)
        {
            cartdel.Enabled = true;
            chnumber.Enabled = true;
        }



        private void listv3_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.IsSelected == false)
            {
                cartdel.Enabled = false;
                chnumber.Enabled = false;

            }
        }

        private void cartdel_Click(object sender, EventArgs e)
        {
            var items = listv3.SelectedItems;
            if (items.Count == 0)
            {
                return;
            }
            Database db = new Database();
            int id = Convert.ToInt32(items[0].Text);
            db.DeleteCart(id);
            listv3.Items.Remove(items[0]);
            UpdateForm();
        }


        private void chnumber_Click(object sender, EventArgs e)
        {
            var items = listv3.SelectedItems;
            if (items.Count == 0)
            {
                return;
            }
            Database db = new Database();
            ChangeNumber changeNumber = new ChangeNumber();
            changeNumber.GetPerviuos = items[0];
            changeNumber.ShowDialog();
            UpdateForm();
        }

        private void pay_Click(object sender, EventArgs e)
        {
            CheckOut checkOut = new CheckOut();
            Invoice invoice = new Invoice();
            checkOut.GetItems = listv3.Items;
            var res = checkOut.ShowDialog();

            if (res == DialogResult.Yes)
            {

                invoice.ShowDialog();

                foreach (ListViewItem item in listv3.Items)
                {
                    listv3.Items.Remove(item);
                    UpdateForm();
                }
            }
            base.Close();
        }
    }
}
