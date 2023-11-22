using API_Productos.Models;
using System.Text.Json.Serialization;

namespace API_Productos.Models
{
    public class ItemsBills
    {
        public int id { get; set; }
        public int bills_id { get; set; }
        public int products_id { get; set; }
        public int quantity { get; set; }

        public decimal price { get; set; }
        public string taxes { get; set; }
        public decimal totalprice { get; set; }
        public string discount { get; set; }
    }
}
