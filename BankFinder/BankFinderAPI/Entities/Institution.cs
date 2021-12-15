using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Serialization;

namespace BankFinderAPI.Entities
{
	public class Institution
	{
        public int Id { get; set; }
		public string InstitutionType { get; set; }
		public string InstitutionSubType { get; set; }
		public int InstitutionNumber { get; set; }
		public string Name { get; set; }
		public string Lettersymbol { get; set; }
		public DateTime DateOfCompanyStart { get; set; }
		public string TIN { get; set; }
		public string LEIIdent { get; set; }
		public string GiinNumber { get; set; }
		public string WWW { get; set; }
		[NotMapped]
		public virtual List<BinNumber> BinNumbers { get; set; }
		[NotMapped]
		public virtual List<Unit> Unit { get; set; }
	}
}
