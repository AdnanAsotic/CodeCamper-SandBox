using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeCamper.Data.Contracts;
using CodeCamper.Data.Ninject;
using CodeCamper.Data.Repositories;
using CodeCamper.Model;
using Ninject;

namespace CodeCamper.Data
{
    public class CodeCamperNinjectKernelConfigurator
    {
        public IKernel Kernel { get; set; }

        public CodeCamperNinjectKernelConfigurator(IKernel kernel)
        {
            Kernel = kernel;
        }

        public void Configure()
        {
            // configure ninject
            Kernel.Bind<DbContext>().To<CodeCamperDbContext>().InRequestOrThreadScope();
            Kernel.Bind<IUnitOfWork>().To<UnitOfWork>().InRequestOrThreadScope();

            // default repos
            Kernel.Bind<IRepository<Room>>().To<EFRepository<Room>>().InRequestOrThreadScope();
            Kernel.Bind<IRepository<TimeSlot>>().To<EFRepository<TimeSlot>>().InRequestOrThreadScope();
            Kernel.Bind<IRepository<Track>>().To<EFRepository<Track>>().InRequestOrThreadScope();

            // custom repos
            Kernel.Bind<IAttendanceRepository>().To<AttendanceRepository>().InRequestOrThreadScope();
            Kernel.Bind<IPersonsRepository>().To<PersonsRepository>().InRequestOrThreadScope();
            Kernel.Bind<ISessionsRepository>().To<SessionsRepository>().InRequestOrThreadScope();

            // set common provider locator
            Microsoft.Practices.ServiceLocation.ServiceLocator.SetLocatorProvider(() => new NinjectServiceLocator(Kernel));
        }
    }
}
