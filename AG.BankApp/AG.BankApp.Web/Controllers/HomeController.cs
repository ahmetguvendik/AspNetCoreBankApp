using AG.BankApp.Web.Data.Context;
using AG.BankApp.Web.Data.Resposities;
using AG.BankApp.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace AG.BankApp.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly BankContext _context;
        private readonly ApplicationUserResposity applicationUserResposity;

        public HomeController(BankContext context)
        {
            _context = context;
            applicationUserResposity = new ApplicationUserResposity(_context);
        }
        public IActionResult Index()
        {
            var users = applicationUserResposity.GetAll();
           
            return View(users);
        }
    }
}
