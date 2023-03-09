using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Tranport_management_system.Models;

namespace Tranport_management_system.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly TransportManagementContext _transport;

        public HomeController(ILogger<HomeController> logger,TransportManagementContext transport)
        {
            _logger = logger;
            _transport = transport;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(string agency,string password)
        { 
            if(agency==null || _transport.Registers==null)
            {
                return NotFound();
            }
            var res= _transport.Registers.FirstOrDefault(m=>m.AdminAgencyName==agency);
            if (res == null) { return NotFound();}
            else
            {
                if(res.AdminPassword==password)
                {
                    return RedirectToAction("Index", "Bookings");
                }
            }
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
    }
}