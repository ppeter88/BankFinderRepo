using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BankFinderDatasync.Models
{
	[XmlRoot(ElementName = "GodzinyOtwarcia")]
	public class OpeningHours
	{
        public int Id { get; set; }

        [XmlElement(ElementName = "Poniedzialek")]
		public string Monday { get; set; }

		[XmlElement(ElementName = "Wtorek")]
		public string Tuesday { get; set; }

		[XmlElement(ElementName = "Sroda")]
		public string Wednesday { get; set; }

		[XmlElement(ElementName = "Czwartek")]
		public string Thursday { get; set; }

		[XmlElement(ElementName = "Piatek")]
		public string Friday { get; set; }
	}
}
