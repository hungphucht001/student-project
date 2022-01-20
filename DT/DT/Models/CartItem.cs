using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DT.Models
{
    public class CartItem
    {
        private int _ProductID;
        private string _ProductName;
        private string _ImageUrl;
        private int _Quantity;
        private double _Price;
        private double _SubToTal;

        public CartItem(int _ProductID, string _ProductName, string _ImageUrl, int _Quantity, double _Price)
        {
            this.ProductID = _ProductID;
            this.ProductName = _ProductName;
            this.ImageUrl = _ImageUrl;
            this.Quantity = _Quantity;
            this.Price = _Price;
            this.SubToTal = _Quantity * _Price;
        }

        public int ProductID { get => _ProductID; set => _ProductID = value; }
        public string ProductName { get => _ProductName; set => _ProductName = value; }
        public string ImageUrl { get => _ImageUrl; set => _ImageUrl = value; }
        public int Quantity { get => _Quantity; set => _Quantity = value; }
        public double Price { get => _Price; set => _Price = value; }
        public double SubToTal { get => _SubToTal; set => _SubToTal = value; }
    }
}