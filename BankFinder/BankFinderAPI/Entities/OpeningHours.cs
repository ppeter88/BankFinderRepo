using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BankFinderAPI.Entities
{
	public class OpeningHours
	{
        public int Id { get; set; }
		public string Monday { get; set; }
		public string Tuesday { get; set; }
		public string Wednesday { get; set; }
		public string Thursday { get; set; }
		public string Friday { get; set; }
	}
}
