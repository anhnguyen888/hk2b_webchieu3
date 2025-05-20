using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MyWebApp.Models;
using System.Collections.Generic; // Thêm dòng này

namespace MyWebApp.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        // Tạo Mock Data cho Featured Products
            var featuredProducts = new List<Product>
            {
                new Product { Id = 1, Name = "Featured Product 1", Price = 25.00m, ImageUrl = "~/images/p1.jpg", Description = "Description for featured 1" },
                new Product { Id = 2, Name = "Featured Product 2", Price = 15.00m, ImageUrl = "~/images/p2.jpg", Description = "Description for featured 2" },
                new Product { Id = 3, Name = "Featured Product 3", Price = 45.00m, ImageUrl = "~/images/p3.jpg", Description = "Description for featured 3" }
            };

            // Tạo Mock Data cho New Products
            var newProducts = new List<Product>
            {
                new Product { Id = 4, Name = "New Product 4", Price = 30.00m, ImageUrl = "~/images/p4.jpg", Description = "Description for new 4" },
                new Product { Id = 5, Name = "New Product 5", Price = 55.00m, ImageUrl = "~/images/p5.jpg", Description = "Description for new 5" },
                new Product { Id = 6, Name = "New Product 6", Price = 65.00m, ImageUrl = "~/images/p6.jpg", Description = "Description for new 6" }
            };

            var viewModel = new HomeViewModel
            {
                FeaturedProducts = featuredProducts,
                NewProducts = newProducts
            };

            return View(viewModel); // Truyền viewModel đến View
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
}
