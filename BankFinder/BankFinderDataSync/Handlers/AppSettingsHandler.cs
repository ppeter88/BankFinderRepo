using Microsoft.Extensions.Configuration;
using System;

namespace BankFinderDataSync
{
    public class AppSettingsHandler : IAppSettingsHandler
    {
        public string Url { get; set; }
        public string FileName { get; set; }
        public string SavePath { get; set; }

        public AppSettingsHandler()
        {
            var builder = new ConfigurationBuilder()
                .AddJsonFile($"appsettings.json", true, true);
            var config = builder.Build();

            Url = config["NBPUrl"];
            FileName = config["BankListFileName"] + config["FileFormat"];
            SavePath = Environment.CurrentDirectory;
        }

    }
}
