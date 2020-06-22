[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(ClassWork_Login.App_Start.NinjectWeb), "Start")]

namespace ClassWork_Login.App_Start
{
    using Microsoft.Web.Infrastructure.DynamicModuleHelper;

    using Ninject.Web;
    using Ninject.Web.Common.WebHost;

    public static class NinjectWeb 
    {
        /// <summary>
        /// Starts the application
        /// </summary>
        public static void Start() 
        {
            DynamicModuleUtility.RegisterModule(typeof(NinjectHttpModule));
        }
    }
}
