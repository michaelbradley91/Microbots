using System.Collections.Generic;
using Ninject;
using Ninject.Modules;

namespace Microbots.Ninject
{
    public class ServiceModulesProvider
    {
        private static IEnumerable<INinjectModule> Modules
        {
            get
            {
                return new INinjectModule[]
                {
                    new ServiceModule(),
                    new Common.Ninject.ServiceModule()
                };
            }
        }

        public static void LoadInto(IKernel kernel)
        {
            kernel.Load(Modules);
        }
    }
}
