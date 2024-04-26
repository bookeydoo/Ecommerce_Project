using ecommerce_api.Models;
using Microsoft.EntityFrameworkCore;

namespace ecommerce_api.Interfaces
{
    public interface EcommerceInterface
    {
        ICollection<logininfo> GetLogininfos();
        ICollection<Storeitems> GetStoreItems();

        logininfo GetLogininfo(string FirstName);
        
        Storeitems GetStoreitems_id(int id);
        Storeitems GetStoreitems_name( string name );

        //bool CreateItem(string name,int id,int price,Storeitems storeitem);
        //bool UpdateItem(string name, int id, int price, Storeitems storeitem);

        //bool CreateUser(string FirstName, string LastName, string password);
        

        public bool Save();
        
    }
}
