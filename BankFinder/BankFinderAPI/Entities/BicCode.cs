using System.Xml.Serialization;

namespace BankFinderAPI.Entities
{
    public class BicCode
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public int SortCodeId { get; set; }
        public virtual SortCode SortCode { get; set; }
    }
}
