using AG.BankApp.Web.Data.Context;
using AG.BankApp.Web.Data.Entities;
using AG.BankApp.Web.Models;

namespace AG.BankApp.Web.Data.Resposities
{
    public class ApplicationUserResposity
    {
        private readonly BankContext _context;

        public ApplicationUserResposity(BankContext context)
        {
            _context = context;
        }
    
        public List<ApplicationUser> GetAll()
        {
            return _context.ApplicationUsers.ToList();
            
        }

        public ApplicationUser GetById(int id)
        {
            return _context.ApplicationUsers.SingleOrDefault(x => x.Id == id);
        }

    }
}
