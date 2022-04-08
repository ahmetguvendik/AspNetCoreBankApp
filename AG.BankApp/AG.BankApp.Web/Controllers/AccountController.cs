using AG.BankApp.Web.Data.Context;
using AG.BankApp.Web.Data.Resposities;
using AG.BankApp.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace AG.BankApp.Web.Controllers
{
    public class AccountController : Controller
    {
        private readonly BankContext _context;
        private readonly ApplicationUserResposity applicationUserResposity;

        public AccountController(BankContext context)
        {
            _context = context;
            applicationUserResposity = new ApplicationUserResposity(_context);
        }
        public IActionResult Create(int id)
        {
            var userInfo = applicationUserResposity.GetById(id);   
            return View(userInfo);
        }
        
        [HttpPost]
        public IActionResult Create(AccountCreateModel model)
        {
            _context.Accounts.Add(new Data.Entities.Account
            {
                ApplicationUserId = model.ApplicationUserId,
                AccountNumber = model.AccountNumber,
                Balance = model.Balance,
            });
            _context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
    }
}
