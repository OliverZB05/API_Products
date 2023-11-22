using API_Productos.Models;
using System.Text.Json.Serialization;

namespace API_Productos.Models
{
    public class Bills
    {
        public int id { get; set; }
        public int customer_id { get; set; }

        private DateTime _date;

        [JsonConverter(typeof(DateConverter))]
        public DateTime date
        {
            get { return _date.Date; }
            set { _date = value; }
        }


        public decimal subtotalPrice { get; set; }

        public decimal totalPrice { get; set; }

        public string taxes { get; set; }

        public string creditDays { get; set; }

        public string outstandingBalance { get; set; }
    }
}
