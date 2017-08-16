using System.Collections.Generic;
using VMdemo.Models;

namespace VMdemo.ViewModels
{
    public class ProductOrderingViewModel
    {
        public Franchise Store {get;set;}
        public List<Supplier> Suppliers {get;set;}
    }
}