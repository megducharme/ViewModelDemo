using System;
using System.Collections.Generic;

namespace VMdemo.Models
{
    public class Customer
    {
        public string Name {get;set;}
        public DateTime Birthday {get;set;}
        public string Email {get;set;}
        public string Address {get;set;}
        public List<Franchise> FranchisesVisted {get;set;}

    }
}