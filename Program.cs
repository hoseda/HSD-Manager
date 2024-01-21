using DB;
using Models;
using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Net;

namespace HSD_manager
{
    internal static class Program
    {


        [STAThread]
        static void Main()
        {

            ApplicationConfiguration.Initialize();
            Application.Run(new HSD());



        }

    }


    class ListViewItemProductInitializer
    {
        private ListViewItem[]? items;
        public ListViewItem[]? Items
        {
            get { return items; }
        }

        public ListViewItemProductInitializer()
        {
            Database db = new Database();
            int c = db.GetProductsCount();
            ListViewItem[] _items = new ListViewItem[c];

            for (int i = 0; i < c; i++)
            {
                ListViewItem item = new ListViewItem(i.ToString());
                Product product = db.GetProduct(i);
                item.SubItems.Add(product.Name);
                item.SubItems.Add(product.Description);
                item.SubItems.Add(product.Price.ToString());
                item.SubItems.Add(product.Quantity.ToString());
                _items[i] = item;
            }

            this.items = _items ?? new ListViewItem[c];
        }
    }



    class ListItemViewCartInitializer
    {
        private ListViewItem[]? _items;
        public int ID { get; set; }
        public int Number
        {
            get
            {
                int c = IsUnique(ID);
                return c == 0 ? 0 : c;
            }
        }
        public ListViewItem[]? Items
        {
            get { return _items ?? null; }
        }

        public int IsUnique(int ProductId)
        {
            int count = 0;
            Database db = new Database();
            int c = db.GetCartItemsCount();
            CartItem[] items = new CartItem[c];
            items = db.GetAllCartItems();

            foreach (CartItem item in items)
            {
                if (item.GetProduct.ID == ProductId)
                {
                    count++;
                }
            }
            return count;
        }

        public ListItemViewCartInitializer()
        {
            Database db = new Database();
            int c = db.GetCartItemsCount();

            ListViewItem[] items = new ListViewItem[c];

            for (int i = 0; i < c; i++)
            {
                CartItem cart = db.GetCartItem(i);
                ListViewItem item = new ListViewItem(i.ToString());
                item.SubItems.Add(cart.GetProduct.Name);
                item.SubItems.Add(cart.GetProduct.Description);
                item.SubItems.Add(cart.GetProduct.Price.ToString());
                item.SubItems.Add(cart.Number.ToString());
                item.SubItems.Add((cart.Number * cart.GetProduct.Price).ToString());
                items[i] = item;

            }
            this._items = items ?? new ListViewItem[c];
        }


    }


    class ListViewSorter : IComparer
    {
        private int _col;
        private SortOrder _order;
        private CaseInsensitiveComparer _objectCompare;


        public int ColumnToSort
        {
            get { return _col; }
            set { _col = value; }
        }

        public SortOrder SortOrder
        {
            get { return _order; }
            set { _order = value; }
        }


        public ListViewSorter()
        {
            _col = 0;
            _order = SortOrder.None;
            _objectCompare = new CaseInsensitiveComparer();
        }

        public int Compare(object? x, object? y)
        {
            int res;

            ListViewItem? listViewItemX, listViewItemY;
            listViewItemX = x as ListViewItem;
            listViewItemY = y as ListViewItem;

            res = _objectCompare.Compare(listViewItemX?.SubItems[_col].Text, listViewItemY?.SubItems[_col].Text);

            if (_order == SortOrder.Ascending)
            {
                return res;
            }
            else if (_order == SortOrder.Descending)
            {
                return -res;
            }
            else
            {
                return 0;
            }
        }
    }
}