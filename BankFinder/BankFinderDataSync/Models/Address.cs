using System.Xml.Serialization;

namespace BankFinderDatasync.Models
{
    [XmlRoot(ElementName = "DaneAdresowe")]
	public class Address
	{
		[XmlElement(ElementName = "kraj")]
		public string Country { get; set; }

		[XmlElement(ElementName = "wojewodztwo")]
		public string Voivodeship { get; set; }

		[XmlElement(ElementName = "powiat")]
		public string District { get; set; }

		[XmlElement(ElementName = "miejscowosc")]
		public string City { get; set; }

		[XmlElement(ElementName = "ulica")]
		public string Street { get; set; }

		[XmlElement(ElementName = "numerBudynku")]
		public string BuildingNumber { get; set; }

		[XmlElement(ElementName = "kodPocztowy")]
		public string ZpiCode { get; set; }

		[XmlElement(ElementName = "poczta")]
		public string Post { get; set; }

		[XmlElement(ElementName = "nrSkrytkiPocztowej")]
		public int PoBoxNumber { get; set; }

		[XmlElement(ElementName = "kodPocztySkrytkiPocztowej")]
		public string PoBoxZipCode { get; set; }

	}

}
