using Memoizator.Modules.Training.Training;
using Prism.Modularity;
using Prism.Regions;

namespace Memoizator.Modules.Training
{
    public class TrainingModule : IModule
    {
        private readonly IRegionManager _regionManager;

        public TrainingModule(IRegionManager regionManager)
        {
            _regionManager = regionManager;
        }

        public void Initialize()
        {
            _regionManager.RegisterViewWithRegion("SplashRegion", typeof(TrainingView));
        }
    }
}
