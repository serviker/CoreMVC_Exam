using CoreMVC_Exam.Areas.Identity.Data;
using CoreMVC_Exam.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace CoreMVC_Exam.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly ApplicationDBContext _context;

        private readonly ApplicationUser _users;

        public HomeController(ILogger<HomeController> logger, ApplicationDBContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        

        public IActionResult ClientOrders()
        {
            return View();
        }

        public IActionResult Clients()
        {
            return View();
        }

        public IActionResult CreateClient()
        {
            return View();
        }

        public ActionResult EditClient(string id)
        {
            var client = (from c in _context.Clients
                          where c.Id == id
                          select c).FirstOrDefault();

            if (client == null)
                return RedirectToAction("Clients", "Home");

            return View("EditClient", client);
        }

        public IActionResult Products()
        {
            return View();
        }
        public IActionResult CreateProduct()
        {
            ViewData["IdCategory"] = new SelectList(_context.Categories, "Id", "NameCategory");
            return View();
        }

        public ActionResult EditProduct(string id)
        {
            var product = (from p in _context.Products
                           where p.Id == id
                           select p).FirstOrDefault();

            if (product == null)
                return RedirectToAction("Products", "Home");

            return View("EditProduct", product);
        }

        public IActionResult Orders()
        {
            return View();
            /*
            if (_context.Orders != null)
            {
                if (User.IsInRole("Admin"))
                {
                    return View();
                }
                else
                {
                    var OrdersDetail = from orders in _context.Orders
                                        join products in _context.Products on orders.IdProduct equals products.Id
                                        join users in _context.Users on orders.IdClient equals users.UserName
                                        select new OrderDeteils
                                        {
                                            IdOrder = orders.Id,
                                            IdProduct = orders.IdProduct,
                                            Brand = products.Brand,
                                            IdClient = orders.IdClient,
                                            ClientName = users.LastName,
                                            StartDate = orders.StartDate,
                                            EndDate = orders.EndDate,
                                            Price = orders.Price
                                        };

                    return View(OrdersDetail.Where(o => o.ClientName == _users.LastName).ToList());

                    //return View(await _context.Orders.Where(o => o.Client == applicationUser.UserName).ToListAsync());
                }
            }
            else 
            { 
            return Problem("Entity set 'AppDBContext.Orders'  is null."); }
            */
        }
        public IActionResult CreateOrder()
        {
            ViewData["idProduct"] = new SelectList(_context.Products, "Id", "Brand");
            ViewData["idClient"] = new SelectList(_context.Clients, "Id", "LastName");
            return View();
        }

        public ActionResult EditOrder(string id)
        {
            var order = (from c in _context.Orders
                           where c.Id == id
                           select c).FirstOrDefault();

            if (order == null)
                return RedirectToAction("Orders", "Home");

            return View("EditOrder", order);
        }

        public IActionResult Categories()
        {
            return View();
        }
        public IActionResult CreateCategory()
        {
            return View();
        }

        public ActionResult EditCategory(string id)
        {
            var category = (from c in _context.Categories
                         where c.Id == id
                         select c).FirstOrDefault();

            if (category == null)
                return RedirectToAction("Categories", "Home");

            return View("EditCategory", category);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}