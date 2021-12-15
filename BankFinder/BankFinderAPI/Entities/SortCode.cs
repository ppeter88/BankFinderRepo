using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BankFinderAPI.Entities
{
	public class SortCode
	{
        public int Id { get; set; }
		public string Code { get; set; }
		public string CodeName { get; set; }
		[NotMapped]
		public virtual List<BicCode> BicCodes { get; set; }
		public DateTime GenerationDate { get; set; }
        public int UnitId { get; set; }
        public virtual Unit Unit { get; set; }
    }
}
