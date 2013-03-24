using System;
using System.Web.Mvc;
using System.Web.Routing;
using Ninject;
using KrabStore.Domain.Entities;
using KrabStore.Domain.Abstract;
using System.Linq;
using Moq;
using System.Collections.Generic;
using KrabStore.Domain.Concrete;

namespace KrabStore.WebUI.Infrastructure
{
    public class NinjectControllerFactory : DefaultControllerFactory
    {
        private IKernel ninjectKernel;

        public NinjectControllerFactory()
        {
            ninjectKernel = new StandardKernel();
            AddBindings();
        }

        protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType)
        {
            return controllerType == null
                ? null
                : (IController)ninjectKernel.Get(controllerType);
        }

        private void AddBindings()
        {
            ninjectKernel.Bind<IProductRepository>().To<EFProductRepository>();
        }
    }
}