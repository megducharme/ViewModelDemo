using System;
using System.Collections.Generic;

namespace VMdemo.Models
{

    public class Franchise
    {
        public string Name {get;set;}
        public double Budget {get;set;}
        public List<Employee> Employees {get;set;}
    }
}