using System;

namespace VMdemo.Models
{
    public class Employee
    {
        public string Name {get;set;}
        public DateTime Birthday {get;set;}
        public string Email {get;set;}
        
        public int FranchiseId {get;set;}
        public Franchise Franchise {get;set;}
    }
}