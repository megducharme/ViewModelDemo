using System;
using System.Collections.Generic;
using VMdemo.Models;

public class SupplierBuilder
{
    public List<Supplier> OrderStuff()
    {
        Product one = new Product()
        {
            Name = "Kao Jai Coffee",
            Price = 12.99,
            SupplierId = 1
        };

        Product two = new Product()
        {
            Name = "Creamer",
            Price = 1.99,
            SupplierId = 1
        };

        Product three = new Product()
        {
            Name = "Sugar",
            Price = 0.99,
            SupplierId = 1
        };

        Product four = new Product()
        {
            Name = "Cups",
            Price = 0.99,
            SupplierId = 1
        };
        Product five = new Product()
        {
            Name = "Straws",
            Price = 0.99,
            SupplierId = 1
        };
        Product six = new Product()
        {
            Name = "Lids",
            Price = 0.99,
            SupplierId = 1
        };
        
        Supplier Reinhart = new Supplier()
        {
            Name = "Reinhart Foodservice",
            Products = new List<Product>(){one, two, three}
        };

        Supplier Walmart = new Supplier()
        {
            Name = "PaperMart",
            Products = new List<Product>(){four, five, six}
        };

        return new List<Supplier>{Reinhart, Walmart};
    }
}