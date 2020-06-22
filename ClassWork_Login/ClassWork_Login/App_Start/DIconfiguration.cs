using Ninject;
using System.Collections.Generic;
using ClassWork_Login.Models.Repository;
using ClassWork_Login.Presenters;


namespace ClassWork_Login.App_Start
{
    public static class DIconfiguration
    {
        public static void SetupDI(IKernel kernel)
        {
            //GuestResponse
            kernel.Bind<IPresenter<GuestResponse>>().To<RSVPPresenter>();
            kernel.Bind<IPresenter<IEnumerable<GuestResponse>>>().To<RSVPPresenter>();
            kernel.Bind<IRepository>().To<MemoryRepository>().InSingletonScope();
            //GuestResponse                 END
        }
    }
}