using ecommerce_api.Data;
using ecommerce_api.Interfaces;
using ecommerce_api.Models;
using Microsoft.EntityFrameworkCore;


namespace ecommerce_api.Repository
{
    public class Repo : EcommerceInterface
    {
        private readonly DataContext _storecontext;
        private readonly DataContext _logincontext;
        public Repo(DataContext context, DataContext logincontext)
        {
            _storecontext = context;
            _logincontext = logincontext;
        }

        public logininfo GetLogininfo(string FirstName)
        {
            return _logincontext.logininfos.Where(p => p.FirstName == FirstName).FirstOrDefault();
        }

        public ICollection<logininfo> GetLogininfos()
        {
            return _logincontext.logininfos.OrderBy(p => p.FirstName).ToList();
        }


        public Storeitems GetStoreitems_id(int id)
        {
            return _storecontext.storeitems.Where(p => p.Id == id).FirstOrDefault();
        }

        public Storeitems GetStoreitems_name(string name)
        {
            return _storecontext.storeitems.Where(p=>p.Name == name).FirstOrDefault();
        }

        public ICollection<Storeitems> GetStoreItems()
        {
            return _storecontext.storeitems.OrderBy(p => p.Name).ToList();
        }
        //public bool CreateItem(string name, int id, int price, Storeitems storeitem)
        //{
        //}



        

        public bool UpdateItem(string name, int id, int price, Storeitems storeitem)
        {
            throw new NotImplementedException();
        }

        //public bool CreateUser(string FirstName, string LastName, string password)
        //{
        //    throw new NotImplementedException();
        //}

        

        public bool Save()
        {
            var saved = _storecontext.SaveChanges();
            return saved > 0 ? true : false;
        }

        internal object GetStoreitems()
        {
            throw new NotImplementedException();
        }
    }
}

    