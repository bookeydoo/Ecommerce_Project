using ecommerce_api.Models;

namespace ecommerce_api.Interfaces
{
        public interface IUserDataRepo
        {
            public ICollection<UserData> GetItems();
        }
    
}
