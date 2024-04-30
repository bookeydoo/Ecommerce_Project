using WebApi.Classes;

namespace WebApi.Interfaces
{
    public interface UserdataInterface
    {
       public ICollection<userdata> GetUserdatas();//defining get items to return  many items as objects

    }
}
