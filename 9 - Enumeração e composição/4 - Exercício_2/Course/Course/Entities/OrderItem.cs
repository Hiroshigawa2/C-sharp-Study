﻿using System.Globalization;

namespace Course.Entities
{
    internal class OrderItem
    {

        CultureInfo ci = CultureInfo.InvariantCulture;
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; }

        public OrderItem() { }

        public OrderItem(int quantity, double price, Product product)
        {
            Quantity = quantity;
            Price = price;
            Product = product;
        }

        public double SubTotal() 
        {
            return Quantity * Price;
        }

        public override string ToString()
        {
            return Product.Name + ", $" + Product.Price.ToString("F2", ci) + ", Quantity: " + Quantity + ", Subtotal: "
                + SubTotal().ToString("F2", ci);
        }
    }
}
