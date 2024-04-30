using WebApi.Classes;

namespace WebApi.Interfaces
{
    public interface IitemsInterface
    {
      public  ICollection<Items> GetItems();//defining get items to return  many items as objects
      
       
    }
}
