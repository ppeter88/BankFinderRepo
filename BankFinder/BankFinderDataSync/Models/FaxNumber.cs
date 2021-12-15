namespace BankFinderDatasync.Models
{
    public class FaxNumber
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public int UnitId { get; set; }
        public virtual Unit Unit { get; set; }

    }
}
