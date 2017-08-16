using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VMdemo.Models;
using VMdemo.ViewModels;

namespace VMdemo.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Employee employee = new Employee()
            {
                Name = "Meg",
                Birthday = new DateTime(1988, 3, 21),
                Email = "meg@meg.com",
                FranchiseId = 1
            };
            return View(employee);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            FranchiseBuilder company = new FranchiseBuilder();
            SupplierBuilder supplier = new SupplierBuilder();

            ProductOrderingViewModel viewModel = new ProductOrderingViewModel();

            viewModel.Store = company.SellFranchise();
            viewModel.Suppliers = supplier.OrderStuff();
            Console.WriteLine(viewModel);

            return View(viewModel);
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
