using System.Xml.Serialization;

namespace BankFinderDatasync.Models
{
    public class BicCode
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public int SortCodeId { get; set; }
        public virtual SortCode SortCode { get; set; }
    }
}
