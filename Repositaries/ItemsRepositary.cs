
using ecommerce_api.Data;
using ecommerce_api.Models;
using oopAPI.Interfaces;


namespace oopAPI.Repositaries
{
    public class ItemsRepositary:IItemsRepositary
    {
        private readonly DataContext _context;
        public ItemsRepositary(DataContext context) { 
            _context = context; 
        }
        public ICollection<Items>GetItems() {
            return _context.Items.OrderBy(p=>p.Id).ToList();
        }

       
    }
}
