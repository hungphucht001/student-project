using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DT.Models
{
    public class Cart
    {

        private DateTime _dateCreated;
        private DateTime _lastUpdate;

        private List<CartItem> _items;

        public Cart()
        {
            _dateCreated = DateTime.Now;
            _lastUpdate = DateTime.Now;
            this._items = new List<CartItem>();
        }

        public List<CartItem> Items { get => _items; set => _items = value; }
        public DateTime DateCreated { get => _dateCreated; set => _dateCreated = value; }
        public DateTime LastUpdate { get => _lastUpdate; set => _lastUpdate = value; }
        public double totalPri()
        {
            return _items.Select(t => t.SubToTal).Sum();
        }
        public void Insert(CartItem item)
        {
            if(item.Quantity > 0)
            {
                int exist = _items.Where(t => t.ProductID == item.ProductID).Count();
                if (exist > 0)
                {
                    update(item.ProductID, item.Quantity);
                    return;
                }
                _items.Add(item);
            }
        }
        public void Reduce(int productId)
        {
            foreach (CartItem item in _items)
            {
                if (item.ProductID == productId)
                {
                    if (item.Quantity > 0)
                    {
                        item.Quantity--;
                        break;
                    }
                    else
                    {
                        _items.Remove(item);
                        break;
                    }
                }
            }
        }
        public void Increase(int productId)
        {
            foreach (CartItem item in _items)
            {
                if (item.ProductID == productId)
                {
                    item.Quantity++;
                    break;
                }
            }
        }
        public void update(int productId, int quantity)
        {

            foreach (CartItem item in _items)
            {
                if (item.ProductID == productId)
                {
                    if (quantity > 0)
                    {
                        item.Quantity = item.Quantity + quantity;
                        break;
                    }
                    else
                    {
                        _items.Remove(item);
                        break;
                    }
                }
            }
            _lastUpdate = DateTime.Now;
        }
        public void delete(int productId)
        {
            foreach (CartItem item in _items)
            {
                if (item.ProductID == productId)
                {
                    _items.Remove(item);
                    break;
                }
            }
            _lastUpdate = DateTime.Now;
        }
    }
}