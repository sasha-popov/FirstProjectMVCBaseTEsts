using Ninject;
using Ninject.Modules;
using NLayerApp.BLL.Infrastructure;
using NLayerApp.BLL.Interfaces;
using NLayerApp.BLL.Services;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace NLayerApp.WEB.Util
{

    public class OrderModule : NinjectModule
        {
            public override void Load()
            {
            Bind<ICustomerOfferDTOService>().To<CustomerOfferDTOService>();
            Bind<ICategoryDTOService>().To<CategoryDTOService>();
            Bind<ICompanyDTOService>().To<CompanyDTOService>();
            Bind<ICustomerDTOService>().To<CustomerDTOService>();
            Bind<ICompanyOfferDTOService>().To<CompanyOfferDTOService>();
            Bind<IOfferDTOService>().To<OfferDTOService>();
        }
        }
    public class NinjectDependencyResolver : IDependencyResolver
    {

        private IKernel kernel;

        public NinjectDependencyResolver(IKernel kernelParam)
        {
            kernel = kernelParam;
        }

        public object GetService(Type serviceType)
        {
            return kernel.TryGet(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return kernel.GetAll(serviceType);
        }

    }
}