using ecommerce_api.Models;

namespace ecommerce_api.Interfaces
{
    public interface EcommerceInterface
    {
        ICollection<logininfo> GetLogininfos();
        ICollection<Storeitems> GetStores();

    }
}
