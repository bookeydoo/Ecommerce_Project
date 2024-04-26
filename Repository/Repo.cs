using ecommerce_api.Data;
using ecommerce_api.Interfaces;
using ecommerce_api.Models;


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

        public ICollection<logininfo> GetLogininfos()
        {
            return _logincontext.logininfos.OrderBy(x=>x.FirstName).ToList();
        }

        public ICollection<Storeitems>GetStoreitems() { 
        return _storecontext.storeitems.OrderBy(p=>p.Name).ToList();
            
        }

        public ICollection<Storeitems> GetStores()
        {
            throw new NotImplementedException();
        }
    }
}
