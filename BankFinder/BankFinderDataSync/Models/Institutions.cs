using BankFinderAPI.Entities;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BankFinderDatasync.Models
{
    [XmlRoot(ElementName = "Instytucje")]
	public class Institutions
	{

		[XmlElement(ElementName = "Instytucja")]
		public List<Institution> InstitutionsList { get; set; }
	}
}
