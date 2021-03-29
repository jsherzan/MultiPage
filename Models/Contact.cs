using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultiPage.Models
{
    public class Contact
    {
        public int ID { get; set; }
        public string ContactName { get; set; }
        public string PhoneNumber { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string StateAbr { get; set; }
        public string ZipCode { get; set; }
        public string Notes { get; set; }
    }
}
