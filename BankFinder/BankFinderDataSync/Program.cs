using BankFinderDataSync.Ninject;
using BankFinderDataSync.Services;
using System;
using System.IO;
using System.Xml.Serialization;
using BankFinderAPI.Models;
using System.Xml.Linq;
using System.Linq;

namespace BankFinderDataSync
{
    class Program
    {
        static void Main(string[] args)
        {
            DI.Initialize();
            BankListDownloadService.StartDownloading();
            Console.ReadLine();
        }
    }
}
