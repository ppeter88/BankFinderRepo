using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankFinderAPI.Entities
{
    public class BinNumber
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public int InstitutionId { get; set; }
        public virtual Institution Institution { get; set; }
    }
}
