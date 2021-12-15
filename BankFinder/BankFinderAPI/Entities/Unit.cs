using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Serialization;

namespace BankFinderAPI.Entities
{
	public class Unit
	{
        public int Id { get; set; }
		[NotMapped]
		public virtual List<PhoneNumber> PhoneNumbers { get; set; }
		[NotMapped]
		public virtual List<FaxNumber> FaxNumbers { get; set; }
		[NotMapped]
		public virtual List<SortCode> SortCode { get; set; }
		public string RegistrationNumber { get; set; }
		public string UnitType { get; set; }
		public string UnitName { get; set; }
		public string LetterSymbol { get; set; }
		public int AddressId { get; set; }
		public virtual Address Address { get; set; }
		public DateTime DateOfCompanyStart { get; set; }
        public int OpeningHoursId { get; set; }
		public OpeningHours OpeningHours { get; set; }
		public string Email { get; set; }
	}
}
