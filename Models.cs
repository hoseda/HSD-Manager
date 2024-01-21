using System;

namespace Models
{
    class Product
    {
        private int id;
        private string name;
        private string description;
        private int price;
        private int quantity;

        public int ID { get { return id; } }
        public string Name { get { return name; } set { name = value; } }
        public string Description { get { return description; } set { description = value; } }
        public int Price { get { return price; } set { price = value; } }
        public int Quantity { get { return quantity; } }


        public Product(int id, string name, string description, int price, int quantity = 1)
        {
            this.id = id;
            this.name = name;
            this.description = description;
            this.price = price;
            this.quantity = quantity;
        }

        public Product(Dictionary<string, object?> json)
        {
            this.id = (int)json["id"]!;
            this.name = (string)json["name"]!;
            this.description = (string)json["description"]!;
            this.price = (int)json["price"]!;
            this.quantity = (int)json["quantity"]!;
        }


        public Product CopyWith(int? id = null, string? name = null, string? descrption = null, int? price = null, int? quantity = null)
        {
            return new Product
            (
                id: id ?? this.id,
                name: name ?? this.name,
                description: descrption ?? this.description,
                price: price ?? this.price,
                quantity: quantity ?? this.quantity
            );
        }



        public Dictionary<string, object?> ToJson(Product product)
        {
            Dictionary<string, object?> myJson = new Dictionary<string, object?>
            {
                {"id" , product.ID},
                {"name" , product.Name},
                {"description" , product.Description},
                {"price" , product.Price},
                {"quantity" , product.Quantity},
            };

            return myJson;
        }
    }

    class CartItem
    {

        private Product product;
        private int number;

       
        public Product GetProduct
        {
            get { return product; }
            set { product = value; }
        }

        public int Number
        {
            get { return number; }
            set { number = value; }
        }

        public int TotalPrice
        {
            get
            {
                int T = Number * GetProduct.Price;
                return T;
            }
        }

        public CartItem(int id, Product product, int number = 1)
        {
            
            this.product = product;
            this.number = number;
        }


    }
}
