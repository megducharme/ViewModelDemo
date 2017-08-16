using System;
using System.Collections.Generic;
using VMdemo.Models;

public class FranchiseBuilder
{
    public List<Franchise> SellFranchise()
    {
        Employee one = new Employee()
        {
            Name = "Meg Ducharme",
            Birthday = new DateTime(1988, 3, 21),
            FranchiseId = 1
        };
        Employee two = new Employee()
        {
            Name = "Hannah Hall",
            Birthday = new DateTime(1989, 3, 11),
            FranchiseId = 1
        };
        Employee three = new Employee()
        {
            Name = "Steve Brownlee",
            Birthday = new DateTime(1968, 6, 26),
            FranchiseId = 1
        };
        Employee four = new Employee()
        {
            Name = "Brenda Long",
            Birthday = new DateTime(1967, 9, 21),
            FranchiseId = 1
        };

        Franchise WestNashvilleLocation = new Franchise()
        {
            Name = "West Nashville",
            Budget = 1000000000.00,
            Manager = one,
            Id = 1
        };

        Franchise WhiteBridgeRd = new Franchise()
        {
            Name = "Whitebridge Road",
            Budget = 1000000000.00,
            Manager = two,
            Id = 2
        };

        Franchise DowntownNashville = new Franchise()
        {
            Name = "Downtown Nashville",
            Budget = 1000000000.00,
            Manager = three,
            Id = 3
        };

        return new List<Franchise>{WestNashvilleLocation, WhiteBridgeRd, DowntownNashville};
    }
}