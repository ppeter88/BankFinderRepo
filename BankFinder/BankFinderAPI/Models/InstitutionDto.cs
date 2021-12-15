using System;
using System.Collections.Generic;

namespace BankFinderAPI.Models
{
    public class InstitutionDto
    {
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
		public List<BinNumberDto> BinNumbers { get; set; }
		public List<UnitDto> Unit { get; set; }
	}
}
