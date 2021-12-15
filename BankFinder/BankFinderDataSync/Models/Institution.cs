using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Serialization;

namespace BankFinderDatasync.Models
{
    [XmlRoot(ElementName = "Instytucja")]
	public class Institution
	{
        public int Id { get; set; }
        [XmlElement(ElementName = "TypInstytucji")]
		public string InstitutionType { get; set; }

		[XmlElement(ElementName = "PodtypInstytucji")]
		public string InstitutionSubType { get; set; }

		[XmlElement(ElementName = "NrInstytucji")]
		public int InstitutionNumber { get; set; }

		[XmlElement(ElementName = "NazwaInstytucji")]
		public string Name { get; set; }

		[XmlElement(ElementName = "SymbolLiterowy")]
		public string Lettersymbol { get; set; }

		[XmlElement(ElementName = "DataRozpDzial")]
		public DateTime DateOfCompanyStart { get; set; }

		[XmlElement(ElementName = "NIP")]
		public string TIN { get; set; }

		[XmlElement(ElementName = "IdentyfikatorLEI")]
		public string LEIIdent { get; set; }

		[XmlElement(ElementName = "NumerGIIN")]
		public string GiinNumber { get; set; }

		[XmlElement(ElementName = "WWW")]
		public string WWW { get; set; }

		[XmlElement(ElementName = "BIN")]
		[NotMapped]
		public virtual List<string> BinNumbers { get; set; }

		[XmlElement(ElementName = "Jednostka")]
		public virtual List<Unit> Unit { get; set; }
	}
}
