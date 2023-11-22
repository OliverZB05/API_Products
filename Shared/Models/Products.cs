using API_Productos.Models;
using System.Text.Json.Serialization;

namespace API_Productos.Models
{
    public class Products
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public decimal price { get; set; }
        public string model { get; set; }
        public string brand { get; set; }
        public string barcode { get; set; }
        public string promotion { get; set; }
        public int stock { get; set; }
    }
}
