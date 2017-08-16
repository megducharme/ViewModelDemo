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
            FranchiseBuilder company = new FranchiseBuilder();

            List<Franchise> allStores = company.SellFranchise();

            StoreListViewModel viewModel = new StoreListViewModel();
            viewModel.Stores = allStores;

            return View(viewModel);
        }

        public IActionResult About(int id)
        {
            SupplierBuilder supplier = new SupplierBuilder();
            FranchiseBuilder company = new FranchiseBuilder();

            List<Franchise> allStores = company.SellFranchise();

            ProductOrderingViewModel viewModel = new ProductOrderingViewModel();
            viewModel.Store = allStores.SingleOrDefault(store => store.Id == id);
            viewModel.Suppliers = supplier.OrderStuff();

            return View(viewModel);
        }

        public IActionResult Employee()
        {
            ViewData["Message"] = "Your contact page.";
            Employee meg = new Employee()
            {
                Name = "Meg Ducharme",
                Birthday = new DateTime(1988, 3, 21),
                Email = "meg@meg.com",
                FranchiseId = 1
            };
            
            return View(meg);
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
