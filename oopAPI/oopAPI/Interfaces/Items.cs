using oopAPI.Models;

namespace oopAPI.Interfaces
{
    public interface IItemsRepositary
    {
        ICollection<Items>GetItems();
    }
}
