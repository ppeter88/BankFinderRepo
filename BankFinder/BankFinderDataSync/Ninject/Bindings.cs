using Ninject.Modules;
using Ninject;
using BankFinderDataSync;

public class Bindings : NinjectModule
{
    public override void Load()
    {
        Bind<IAppSettingsHandler>().To<AppSettingsHandler>();
        Bind<IDownloadingHandler>().To<DownloadingHandler>();
    }
}