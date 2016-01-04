using System.Windows;
using Memoizator.Modules.Training;
using Prism.Unity;
using Prism.Modularity;
using Microsoft.Practices.Unity;


namespace Memoizator
{
    public class Bootstrapper : UnityBootstrapper
    {
        protected override DependencyObject CreateShell()
        {
            return Container.Resolve<Shell>();
        }

        protected override void InitializeShell()
        {
            Application.Current.MainWindow.Show();
        }

        protected override void ConfigureModuleCatalog()
        {
            var catalog = (ModuleCatalog) ModuleCatalog;
            catalog.AddModule(typeof (TrainingModule));
        }
    }
}
