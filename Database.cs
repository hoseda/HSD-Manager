using System;
using System.Data.SQLite;
using System.Collections.Generic;

using Models;
using System.Data;


namespace DB
{

    class Database
    {
        private readonly SQLiteConnection _connection;


        public Database()
        {
            _connection = new SQLiteConnection("Data Source=myDB.db;version=3;");
            try
            {
                _connection.Open();
                CreateProductTable();
                CreateCartTable();

            }
            catch
            {
                throw new Exception("Error : in DB Constroctor.");
            }

        }

        public void CreateProductTable()
        {
            try
            {
                string createTable = "CREATE TABLE IF NOT EXISTS Products (id INTEGER PRIMARY KEY, name TEXT , description TEXT , price INTEGER , quantity INTEGER )";
                SQLiteCommand command = new SQLiteCommand(createTable, _connection);
                command.ExecuteNonQuery();
            }

            catch (Exception)
            {

                throw new Exception("Table Creating Faild.");
            }
        }




        public int SaveProduct(Product product)
        {
            SQLiteCommand insert = new SQLiteCommand("INSERT OR IGNORE INTO Products (id, name, description, price, quantity) VALUES (?,?,?,?,?)", _connection);
            insert.Parameters.AddWithValue("id", product.ID);
            insert.Parameters.AddWithValue("name", product.Name);
            insert.Parameters.AddWithValue("description", product.Description);
            insert.Parameters.AddWithValue("price", product.Price);
            insert.Parameters.AddWithValue("quantity", product.Quantity);

            return insert.ExecuteNonQuery();

        }


        public Product GetProduct(int id)
        {

            SQLiteCommand read = new SQLiteCommand("SELECT name , description , price , quantity FROM Products WHERE id = ?", _connection);
            read.Parameters.AddWithValue("id", id);

            SQLiteDataReader reader = read.ExecuteReader();

            Dictionary<string, object?> myjson = new Dictionary<string, object?>();

            while (reader.Read())
            {
                myjson.Add("id", id);

                myjson.Add("name", reader.GetString(0));
                myjson.Add("description", reader.GetString(1));
                myjson.Add("price", reader.GetInt32(2));
                myjson.Add("quantity", reader.GetInt32(3));
            }


            return new Product(myjson);

        }


        public int GetProductsCount()
        {
            SQLiteCommand count = new SQLiteCommand("SELECT COUNT(*) FROM Products", _connection);
            int countid = Convert.ToInt32(count.ExecuteScalar());
            return countid;
        }

        public void DeleteProduct(int id)
        {

            SQLiteCommand delete = new SQLiteCommand("DELETE FROM Products WHERE id = ?", _connection);
            delete.Parameters.AddWithValue("id", id);
            delete.ExecuteNonQuery();
        }


        public Product[] GetAllProduct()
        {


            SQLiteCommand count = new SQLiteCommand("SELECT * FROM Products", _connection);
            SQLiteDataReader reader = count.ExecuteReader();

            Product[] products = new Product[GetProductsCount()];

            int c = 0;
            while (reader.Read())
            {
                Dictionary<string, object?> myjson = new Dictionary<string, object?>
                {
                    { "id", reader.GetInt32(0) },
                    { "name", reader.GetString(1) },
                    { "description", reader.GetString(2) },
                    { "price", reader.GetInt32(3) },
                    { "quantity", reader.GetInt32(4) }
                };
                products[c] = new Product(myjson);
                c++;
            }


            return products;

        }

        public Product UpdateProduct(Product product)
        {

            SQLiteCommand update = new SQLiteCommand("UPDATE Products SET name = $name , description = $description  , price = $price , quantity = $quantity WHERE id = $id ", _connection);
            update.Parameters.AddWithValue("$id", product.ID);
            update.Parameters.AddWithValue("$name", product.Name);
            update.Parameters.AddWithValue("$description", product.Description);
            update.Parameters.AddWithValue("$price", product.Price);
            update.Parameters.AddWithValue("$quantity", product.Quantity);

            int _id = update.ExecuteNonQuery();
            return product.CopyWith(id: _id);
        }

        public void CreateCartTable()
        {
            try
            {

                string createTable = "CREATE TABLE IF NOT EXISTS Cart(id INTEGER , name TEXT , description TEXT , price INTEGER , number INTEGER , FOREIGN KEY(id) REFERENCES Products(id))";
                SQLiteCommand command = new SQLiteCommand(createTable, _connection);
                command.ExecuteNonQuery();

            }
            catch (Exception)
            {

                throw new Exception("Table Creating Faild.");
            }

        }

        public int GetCartItemsCount()
        {
            SQLiteCommand count = new SQLiteCommand("SELECT COUNT(*) FROM Cart", _connection);
            int countid = Convert.ToInt32(count.ExecuteScalar());
            return countid;
        }


        public int SaveCart(CartItem item)
        {
            Product product = item.GetProduct;
            CartItem[] items = GetAllCartItems();
            CartItem? e = items.Where(i => i.GetProduct.ID == product.ID).SingleOrDefault();

            if (e != null)
            {
                if (e.Number < e.GetProduct.Quantity)
                {
                    e.Number++;
                }
                int _id = UpdateCartItem(e);
                return _id;
            }
            else
            {
                SQLiteCommand insert = new SQLiteCommand("INSERT OR IGNORE INTO Cart (id, name, description, price, number) VALUES (?,?,?,?,?)", _connection);
                insert.Parameters.AddWithValue("id", product.ID);
                insert.Parameters.AddWithValue("name", product.Name);
                insert.Parameters.AddWithValue("description", product.Description);
                insert.Parameters.AddWithValue("price", product.Price);
                insert.Parameters.AddWithValue("number", item.Number);

                int _id = insert.ExecuteNonQuery();
                return _id;
            }
        }
        public CartItem GetCartItem(int id)
        {
            SQLiteCommand read = new SQLiteCommand("SELECT name , description , price , number FROM Cart WHERE id = ?", _connection);
            SQLiteCommand quantity = new SQLiteCommand("SELECT quantity FROM Products WHERE id = ?", _connection);
            read.Parameters.AddWithValue("id", id);
            quantity.Parameters.AddWithValue("id", id);

            SQLiteDataReader reader = read.ExecuteReader();
            int q = Convert.ToInt32(quantity.ExecuteScalar());

            Dictionary<string, object?> myjson = new Dictionary<string, object?>();

            while (reader.Read())
            {
                myjson.Add("id", id);
                myjson.Add("name", reader.GetString(0));
                myjson.Add("description", reader.GetString(1));
                myjson.Add("price", reader.GetInt32(2));
                myjson.Add("number", reader.GetInt32(3));
                myjson.Add("quantity", q);
            }


            Product product = new Product(myjson);
            CartItem item = new CartItem(id, product, (int)myjson["number"]!);
            return item;


        }

        public CartItem[] GetAllCartItems()
        {

            SQLiteCommand count = new SQLiteCommand("SELECT * FROM Cart", _connection);
            SQLiteCommand quantity = new SQLiteCommand("SELECT quantity FROM Products WHERE id = ?", _connection);

            SQLiteDataReader reader = count.ExecuteReader();

            CartItem[] items = new CartItem[GetCartItemsCount()];

            int c = 0;
            while (reader.Read())
            {
                int id = reader.GetInt32(0);
                quantity.Parameters.AddWithValue("id", id);
                int q = Convert.ToInt32(quantity.ExecuteScalar());
                Dictionary<string, object?> myjson = new Dictionary<string, object?>
                {
                    { "id", id },
                    { "name", reader.GetString(1) },
                    { "description", reader.GetString(2) },
                    { "price", reader.GetInt32(3) },
                    { "number", reader.GetInt32(4) },
                    {"quantity" , q }
                };
                Product product = new Product(myjson);
                items[c] = new CartItem(c, product, (int)myjson["number"]!);
                c++;
            }

            return items;

        }
        public void DeleteCart(int id)
        {
            SQLiteCommand delete = new SQLiteCommand("DELETE FROM Cart WHERE id = ?", _connection);
            delete.Parameters.AddWithValue("id", id);
            delete.ExecuteNonQuery();
        }

        public int UpdateCartItem(CartItem item)
        {
            Product product = item.GetProduct;
            SQLiteCommand update = new SQLiteCommand("UPDATE Cart SET name = $name , description = $description  , price = $price , number = $number WHERE id = $id ", _connection);
            update.Parameters.AddWithValue("$id", product.ID);
            update.Parameters.AddWithValue("$name", product.Name);
            update.Parameters.AddWithValue("$description", product.Description);
            update.Parameters.AddWithValue("$price", product.Price);
            update.Parameters.AddWithValue("$number", item.Number);

            int id = update.ExecuteNonQuery();
            return id;
        }

    }
}
