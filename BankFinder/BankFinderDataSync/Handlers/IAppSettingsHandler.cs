namespace BankFinderDataSync
{
    public interface IAppSettingsHandler
    {
        string FileName { get; set; }
        string SavePath { get; set; }
        string Url { get; set; }
    }
}