using BankFinderDataSync.Ninject;

namespace BankFinderDataSync.Services
{
    public static class BankListDownloadService
    {
        public static void StartDownloading()
        {
            var downloadingHanlder = DI.Create<IDownloadingHandler>();
            bool isDownloaded = downloadingHanlder.Execute();
            string msg = isDownloaded ? "Udało się pobrać plik" : "A jednak się nie udało";

            System.Console.WriteLine(msg);
        }
    }
}
