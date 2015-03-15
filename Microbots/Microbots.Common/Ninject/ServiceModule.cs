using Microbots.Common.Helpers;
using Ninject.Modules;

namespace Microbots.Common.Ninject
{
    public class ServiceModule : NinjectModule
    {
        public override void Load()
        {
            LoadHelpers();
        }

        private void LoadHelpers()
        {
            Bind<ICacheHelper>().To<CacheHelper>();
        }
    }
}
