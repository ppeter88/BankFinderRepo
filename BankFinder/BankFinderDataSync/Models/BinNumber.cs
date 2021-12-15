namespace BankFinderDatasync.Models
{
    public class BinNumber
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public int InstitutionId { get; set; }
        public virtual Institution Institution { get; set; }
    }
}
