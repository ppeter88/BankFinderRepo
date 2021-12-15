using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Serialization;

namespace BankFinderDatasync.Models
{
    [XmlRoot(ElementName = "Jednostka")]
	public class Unit
	{
        public int Id { get; set; }

        [XmlElement(ElementName = "NumerTelefonu")]
		[NotMapped]
		public virtual List<string> PhoneNumbers { get; set; }

		[XmlElement(ElementName = "NumerFaksu")]
		[NotMapped]
		public virtual List<string> FaxNumbers { get; set; }

		[XmlElement(ElementName = "NumerRozliczeniowy")]
		public virtual List<SortCode> SortCode { get; set; }

		[XmlElement(ElementName = "NrEwidencyjny")]
		public string RegistrationNumber { get; set; }

		[XmlElement(ElementName = "TypJednostki")]
		public string UnitType { get; set; }

		[XmlElement(ElementName = "NazwaJednostki")]
		public string UnitName { get; set; }

		[XmlElement(ElementName = "SymbolLiterowy")]
		public string LetterSymbol { get; set; }

		public int AddressId { get; set; }

		[XmlElement(ElementName = "DaneAdresowe")]
		public virtual Address Address { get; set; }

		[XmlElement(ElementName = "DataPodjeciaDzialalnosci")]
		public DateTime DateOfCompanyStart { get; set; }

        public int OpeningHoursId { get; set; }

        [XmlElement(ElementName = "GodzinyOtwarcia")]
		public OpeningHours OpeningHours { get; set; }

		[XmlElement(ElementName = "AdresEmail")]
		public string Email { get; set; }
	}
}
