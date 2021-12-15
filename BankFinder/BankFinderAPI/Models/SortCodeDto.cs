using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankFinderAPI.Models
{
    public class SortCodeDto
    {
        public string Code { get; set; }
        public string CodeName { get; set; }
        public List<BicCodeDto> BicCodes { get; set; }
        public DateTime GenerationDate { get; set; }
    }
}
