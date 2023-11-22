using API_Productos.Models;
using System.Text.Json.Serialization;

namespace API_Productos.Models
{
    public class Customers
    {
        public int id { get; set; }
        public string name { get; set; }
        public string lastName { get; set; }

        private DateTime _birthDate;

        [JsonConverter(typeof(DateConverter))]
        public DateTime birthDate
        {
            get { return _birthDate.Date; }
            set { _birthDate = value; }
        }


        public int typeCustomers_id { get; set; }

        public string dirProvince { get; set; }
        public string dirMunicipality { get; set; }
        public string dirDepartment { get; set; }
        public string dirStreet { get; set; }
        public int dirNumber { get; set; }
        public int typeDocument_id { get; set; }
        public int numDocument { get; set; }
        public string phone1 { get; set; }
        public string phone2 { get; set; }
        public string email { get; set; }

    }
}
