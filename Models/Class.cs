using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Models
{
    public class General_item_layout
    {
        public string Id { get; set; }
        public int DB_id {  get; set; }
        [DataType(DataType.Date)]
        public DateTime Dateofproduction { get; set; }

        [DataType(DataType.Currency)]
        public int Price { get; set; }

        public int rating { get; set; }
    }
}
