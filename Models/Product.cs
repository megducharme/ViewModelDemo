using System;

namespace VMdemo.Models
{
    public class Product
    {
        public string Name {get;set;}
        public double Price {get;set;}
        public int SupplierId {get;set;}
        public Supplier Supplier {get;set;}
    }
}