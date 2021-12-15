using BankFinderAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankFinderAPI.Models
{
    public class UnitDto
    {
		public List<PhoneNumberDto> PhoneNumbers { get; set; }
		public List<FaxNumberDto> FaxNumbers { get; set; }
		public List<SortCodeDto> SortCode { get; set; }
		public string RegistrationNumber { get; set; }
		public string UnitType { get; set; }
		public string UnitName { get; set; }
		public string LetterSymbol { get; set; }
		public int AddressId { get; set; }
		public AddressDto Address { get; set; }
		public DateTime DateOfCompanyStart { get; set; }
		public OpeningHoursDto OpeningHours { get; set; }
		public string Email { get; set; }
	}
}
