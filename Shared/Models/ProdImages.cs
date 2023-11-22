using API_Productos.Models;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace API_Productos.Models
{
    public class ProdImages
    {
        [Key]
        public int product_id { get; set; }
        public string routes { get; set; }
    }
}
