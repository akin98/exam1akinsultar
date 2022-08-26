using Exam.Business.Service.Concrete;
using Exam.Business.Service.Interface;
using Exam.Entities;
using ExamMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ExamMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IProductBusinessService _productBusinessService;
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            _productBusinessService = new ProductBusinessService();
        }

        public IActionResult Index()
        {
            ViewBag.Product = _productBusinessService.GetAllProduct();
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Product()
        {
            var liste = _productBusinessService.GetAllProduct();
            return View(liste);
        }
        public IActionResult AddProduct(Products products)
        {
            _productBusinessService.CreateProduct(products);

            return RedirectToAction(nameof(Index));
        }
        public IActionResult RemoveProduct(int id)
        {
            _productBusinessService.DeleteProduct(id);
            return RedirectToAction(nameof(Index));
        }
        public IActionResult UpdateProduct(Products products)
        {
            _productBusinessService.UpdateProduct(products);
            return RedirectToAction(nameof(Index));
        }
    }
}
