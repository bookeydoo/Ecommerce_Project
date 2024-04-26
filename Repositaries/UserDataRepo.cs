using ecommerce_api.Data;
using ecommerce_api.Interfaces;
using ecommerce_api.Models;
using oopAPI.Interfaces;

namespace ecommerce_api.Repositaries
{ 
    
        public class UserDataRepo : IUserDataRepo
        {
            private readonly DataContext _context;
            public UserDataRepo(DataContext context)
            {
                _context = context;
            }
            public ICollection<UserData> GetItems()
            {
                return _context.Userdata.OrderBy(p => p.FirstName).ToList();
            }


        }
    }



