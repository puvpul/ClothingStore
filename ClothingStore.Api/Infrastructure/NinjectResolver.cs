using System;
using System.Collections.Generic;
using System.Web.Http.Dependencies;
using Ninject;
using ClothingStore.Api.Data;
using Ninject.Extensions.ChildKernel;

namespace ClothingStore.Api.Infrastructure
{
    public class NinjectResolver : IDependencyResolver
    {
        private IKernel kernel;

        public NinjectResolver(): this (new StandardKernel())
        { }
        public NinjectResolver(IKernel ninjectKernel, bool scope=false)
        {
            kernel = ninjectKernel;
            if (!scope)
            {
                AddBindings(kernel);
            }
        }
        public IDependencyScope BeginScope()
        {
            return new NinjectResolver(AddRequestBindings(new ChildKernel(kernel)), true);
        }

        public object GetService(Type serviceType)
        {
            return kernel.TryGet(serviceType);
        }
        public IEnumerable<object> GetServices(Type serviceType)
        {
            return kernel.GetAll(serviceType);
        }
        public void Dispose()
        {
            throw new NotImplementedException();
        }

        private void AddBindings(IKernel kernel)
        {
            // singleton and transient bindings go here
        }
        private IKernel AddRequestBindings(IKernel kernel)
        {
            kernel.Bind<ICatalougeRepository>().To<CatalougeRepository>().InSingletonScope();
            kernel.Bind<IOrderRepository>().To<OrderRepository>().InSingletonScope();
            return kernel;
        }
    }
}