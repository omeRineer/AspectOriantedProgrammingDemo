using Autofac;
using Autofac.Extras.DynamicProxy;
using Castle.DynamicProxy;
using Level_2.Aspects;
using Level_2.Concrete;
using Level_2.Interceptor;
using System;

namespace Level_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;

            var container = new ContainerBuilder();
            container.RegisterType<CacheAspect>();
            container.RegisterType<ValidationAspect>();
            container.RegisterType<ProductManager>()
                .EnableClassInterceptors(new ProxyGenerationOptions 
                { 
                    Selector=new InterceptorSelector()
                });

            var build = container.Build().BeginLifetimeScope();
            var item = build.Resolve<ProductManager>();
            item.Add();

            Console.WriteLine("\n \n \n \n \n \n=====================================");
            Console.ResetColor();
        }
    }
}
