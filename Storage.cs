using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DB;
using Models;

namespace HSD_manager
{



    public partial class Storage : Form
    {

        private ListViewSorter listsorter;
        private ListViewItemProductInitializer initializer;



        public Storage()
        {

            InitializeComponent();
            initializer = new ListViewItemProductInitializer();
            listv2.Items.AddRange(initializer.Items);



            //sorting
            listsorter = new ListViewSorter();
            listv2.ListViewItemSorter = listsorter;
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {



            AddItem addItem = new AddItem();
            var s = addItem.ShowDialog();

            if (s == DialogResult.OK)
            {
                ListViewItem item = addItem.GetValue!;
                listv2.Items.Add(item);

            }
        }


        private void listv2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            editbtn_Click(sender, e);
        }

        private void delbtn_Click(object sender, EventArgs e)
        {
            var items = listv2.SelectedItems;
            if (items.Count == 0)
            {
                return;
            }
            else
            {
                Database db = new Database();
                db.DeleteProduct(Convert.ToInt32(items[0].Text));
                db.DeleteCart(Convert.ToInt32(items[0].Text));
                listv2.Items.Remove(items[0]);
                delbtn.Enabled = false;
            }
        }

        private void listv2_MouseClick(object sender, MouseEventArgs e)
        {



            delbtn.Enabled = true;
            editbtn.Enabled = true;
            addtocartbtn.Enabled = true;



        }

        private void editbtn_Click(object sender, EventArgs e)
        {
            var items = listv2.SelectedItems;
            if (items.Count == 0)
            {
                return;
            }
            EditItem editItem = new EditItem();
            editItem.getPerviuos = items[0];
            editItem.ShowDialog();

        }


        private void addtocartbtn_Click(object sender, EventArgs e)
        {
            var items = listv2.SelectedItems;
            if (items.Count == 0) { return; }
            if (Convert.ToInt32(items[0].SubItems[4].Text) == 0)
            {
                MessageBox.Show("Quantity is 0");
            }
            Database db = new Database();
            int _id = db.GetCartItemsCount();
            Product product = db.GetProduct(Convert.ToInt32(items[0].Text));


            CartItem item = new CartItem(_id, product);
            db.SaveCart(item);
        }

        private void listv2_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.IsSelected == false)
            {
                delbtn.Enabled = false;
                editbtn.Enabled = false;
                addtocartbtn.Enabled = false;
            }
        }



        private void listv2_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (e.Column == listsorter.ColumnToSort)
            {
                if (listsorter.SortOrder == SortOrder.Ascending)
                {
                    listsorter.SortOrder = SortOrder.Descending;
                }
                else
                {
                    listsorter.SortOrder = SortOrder.Ascending;
                }
            }
            else
            {
                listsorter.ColumnToSort = e.Column;
                listsorter.SortOrder = SortOrder.Ascending;
            }

            listv2.Sort();


        }

        private void gotocartbtn_Click(object sender, EventArgs e)
        {
            CartPage cartpage = new CartPage();
            cartpage.ShowDialog();

        }
    }
}
