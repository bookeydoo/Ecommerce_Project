

using ecommerce_api.Models;

namespace oopAPI.Interfaces
{
    public interface IItemsRepositary
    {
         public ICollection<Items>GetItems();
    }
}
