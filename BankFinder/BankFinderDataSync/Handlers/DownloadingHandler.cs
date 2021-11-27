using System;
using System.Net;
using System.IO;

namespace BankFinderDataSync
{
    public class DownloadingHandler : IDownloadingHandler
    {
        private readonly IAppSettingsHandler _appSettings;

        public DownloadingHandler(IAppSettingsHandler appSettings)
        {
            _appSettings = appSettings;
        }

        public bool Execute()
        {
            string bankListPath = Path.Combine(_appSettings.SavePath, _appSettings.FileName);
            using (var client = new WebClient())
            {
                client.DownloadFileAsync(new Uri(_appSettings.Url), bankListPath);
            }

            return File.Exists(bankListPath);
        }
    }
}
