using Ninject.Modules;
using NLayerApp.DAL.Entities.Interfaces;
using NLayerApp.DAL.Repositories;

namespace NLayerApp.BLL.Infrastructure
{
    public class ServiceModule : NinjectModule
    {
        private string connectionString;
        public ServiceModule(string connection)
        {
            connectionString = connection;
        }
        public override void Load()
        {
            Bind<IUnitOfWork>().To<EFUnitOfWork>().WithConstructorArgument(connectionString);
        }
    }
}
