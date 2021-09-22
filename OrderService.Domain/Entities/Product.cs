﻿using OrderService.Shared.Entities;

namespace OrderService.Domain.Entities
{
    public class Product : Entity
    {
        public Product(string name, string description, decimal price, int quantityInStock, string image)
        {
            Name = name;
            Description = description;
            Price = price;
            QuantityInStock = quantityInStock;
            Image = image;
        }
        public string Name { get; private set; }
        public string Description { get; private set; }
        public decimal Price { get; private set; }
        public int QuantityInStock { get; private set; }
        public string Image { get; private set; }

        public int CategoryId { get; private set; }
        public Category Category { get; private set; }

    }
}
