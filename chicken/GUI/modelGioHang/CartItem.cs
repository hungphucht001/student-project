using chicken.App_Start;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace chicken.GUI.modelGioHang
{
    public class CartItem
    {
        private String id, name, image, price;
        private int quantity;
        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Image { get => image; set => image = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public string Price { get => price; set => price = value; }

        public CartItem(String id, String name, String image, int quantity, String price)
        {
            this.id = id;
            this.name = name;
            this.image = image;
            this.quantity = quantity;
            this.price = price;
        }
        public double totalPrice()
        {
            return double.Parse(price) * quantity;
        }
    }
}