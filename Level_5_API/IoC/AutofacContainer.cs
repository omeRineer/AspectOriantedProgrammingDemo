using Autofac;
using Autofac.Extras.DynamicProxy;
using Castle.DynamicProxy;
using Level_5_API.Abstract;
using Level_5_API.Concrete;
using Level_5_API.Interceptor;

namespace Level_5_API.IoC
{
    public class AutofacContainer:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ProductManager>().As<IProductService>().EnableInterfaceInterceptors(new ProxyGenerationOptions
            {
                Selector=new InterceptorSelector()
            }).SingleInstance();

            //var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            //builder.RegisterAssemblyTypes(assembly)
            //    .AsImplementedInterfaces()
            //    .EnableClassInterceptors(new ProxyGenerationOptions
            //    {
            //        Selector = new InterceptorSelector()
            //    })
            //    .SingleInstance();
        }
    }
}
