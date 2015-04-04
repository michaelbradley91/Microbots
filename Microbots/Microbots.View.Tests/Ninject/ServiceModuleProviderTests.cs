using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Microbots.View.Ninject;
using Ninject;
using NUnit.Framework;

namespace Microbots.View.Tests.Ninject
{
    [TestFixture]
    public class ServiceModuleProviderTests
    {
        private const string MicrobotsAssemblyName = "Microbots.View";

        private IKernel _kernel;
        private IEnumerable<Type> _assemblyTypes;
            
        [SetUp]
        public void Setup()
        {
            var assembly = Assembly.Load(MicrobotsAssemblyName);
            _assemblyTypes = assembly.DefinedTypes;

            _kernel = new StandardKernel();
            ServiceModulesProvider.LoadInto(_kernel);
        }

        [Test]
        public void TestControllerBindings()
        {
            foreach (var type in GetAllTypesWithSuffix("Controller").Where(t => t.IsInterface))
            {
                var controller = _kernel.Get(type);
                Assert.That(controller, Is.Not.Null);
            }
        }

        [Test]
        public void TestExceptionHandlerBindings()
        {
            foreach (var type in GetAllTypesWithSuffix("ExceptionHandler").Where(t => t.IsInterface))
            {
                var viewModel = _kernel.Get(type);
                Assert.That(viewModel, Is.Not.Null);
            }
        }

        [Test]
        public void TestViewModelBindings()
        {
            foreach (var type in GetAllTypesWithSuffix("ViewModel"))
            {
                var viewModel = _kernel.Get(type);
                Assert.That(viewModel, Is.Not.Null);
            }
        }

        [STAThread]
        [Test]
        public void TestViewBindings()
        {
            foreach (var type in GetAllTypesWithSuffix("View"))
            {
                var view = _kernel.Get(type);
                Assert.That(view, Is.Not.Null);
            }
        }

        private IEnumerable<Type> GetAllTypesWithSuffix(string suffix)
        {
            return _assemblyTypes.Where(t => t.Name.EndsWith(suffix)).Where(HasConcreteImplementation);
        }

        private bool HasConcreteImplementation(Type type)
        {
            return !type.IsAbstract || _assemblyTypes.Any(t => t.Name == type.Name.Substring(1) && !t.IsAbstract);
        }
    }
}
