using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankFinderAPI.Models
{
    public class AddressDto
    {
		public string Country { get; set; }
		public string Voivodeship { get; set; }
		public string District { get; set; }
		public string City { get; set; }
		public string Street { get; set; }
		public string BuildingNumber { get; set; }
		public string ZpiCode { get; set; }
		public string Post { get; set; }
		public int PoBoxNumber { get; set; }
		public string PoBoxZipCode { get; set; }
	}
}
