using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace chicken.GUI.modelGioHang
{
    public class Cart
    {
        private DateTime _dateCreated;
        private DateTime _lastUpdate;
        private List<CartItem> _items;
        public Cart()
        {
            this._dateCreated = DateTime.Now;
            this._items = new List<CartItem>();
        }
        public List<CartItem> Items { get => _items; set => _items = value; }
        public void insert(CartItem item)
        {
            if(item.Quantity > 0)
            {
                foreach (CartItem i in _items)
                {
                    if (i.Id.Equals(item.Id))
                    {
                        i.Quantity += item.Quantity;
                        return;
                    }
                }
                _items.Add(item);
            }
        }
        public void delete(String id)
        {
            foreach(CartItem item in Items)
            {
                if (item.Id.Equals(id))
                {
                    _items.Remove(item);break;
                }
            }
        }
        public void update(String id, int quaitity)
        {
            foreach (CartItem item in _items)
            {
                if (item.Id.Equals(id))
                {
                    if (quaitity == 0) {
                        _items.Remove(item);
                        return;
                    }
                    else
                    {
                        item.Quantity = quaitity;
                        break;
                    }
                }
            }
        }
    }
}