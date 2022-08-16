using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simplic.OxS.Contact.InternalClient.Model
{
    public class AddressInternalModel
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? CompanyName { get; set; }
        public string? Additional01 { get; set; }
        public string? Additional02 { get; set; }
        public string? Street { get; set; }
        public string? HouseNumber { get; set; }
        public string? Zipcode { get; set; }
        public string? City { get; set; }
        public string? CountryIso { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }
}
