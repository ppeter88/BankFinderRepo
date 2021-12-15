using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BankFinderDatasync.Models
{
	[XmlRoot(ElementName = "NumerRozliczeniowy")]
	public class SortCode
	{
        public int Id { get; set; }

        [XmlElement(ElementName = "NrRozliczeniowy")]
		public string Code { get; set; }

		[XmlElement(ElementName = "NazwaNumeru")]
		public string CodeName { get; set; }

		[XmlElement(ElementName = "KodyBIC")]
		[NotMapped]
		public virtual List<string> BicCodes { get; set; }

		[XmlElement(ElementName = "DataWygenerowania")]
		public DateTime GenerationDate { get; set; }

        public int UnitId { get; set; }
        public virtual Unit Unit { get; set; }
    }
}
