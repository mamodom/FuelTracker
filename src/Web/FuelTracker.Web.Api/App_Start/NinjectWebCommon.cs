using System;
using System.Web;
using FuelTracker.DI.Ninject;
using FuelTracker.Libs.Extensions;
using FuelTracker.Web.Api;
using Microsoft.Web.Infrastructure.DynamicModuleHelper;
using Ninject;
using Ninject.Web.Common;

[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(NinjectWebCommon), nameof(NinjectWebCommon.Start))]
[assembly: WebActivatorEx.ApplicationShutdownMethod(typeof(NinjectWebCommon), nameof(NinjectWebCommon.Stop))]
namespace FuelTracker.Web.Api
{
    public static class NinjectWebCommon
    {
        private static readonly Bootstrapper Bootstrapper = new Bootstrapper();

        /// <summary>
        /// Starts the application
        /// </summary>
        public static void Start()
        {
            DynamicModuleUtility.RegisterModule(typeof(OnePerRequestHttpModule));
            DynamicModuleUtility.RegisterModule(typeof(NinjectHttpModule));
            Bootstrapper.Initialize(CreateKernel);
        }

        /// <summary>
        /// Stops the application.
        /// </summary>
        public static void Stop() => Bootstrapper.ShutDown();

        /// <summary>
        /// Creates the kernel that will manage your application.
        /// </summary>
        /// <returns>The created kernel.</returns>
        private static IKernel CreateKernel()
        {
            var kernel = new StandardKernel();
            try
            {
                kernel.Bind<Func<IKernel>>().ToMethod(ctx => () => new Bootstrapper().Kernel);
                kernel.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();

                return kernel.Tap(ResolverFactory.RegisterServices);
            }
            catch
            {
                kernel.Dispose();
                throw;
            }
        }
    }
}
