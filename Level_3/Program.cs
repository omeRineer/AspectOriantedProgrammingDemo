using Autofac;
using Autofac.Extras.DynamicProxy;
using Castle.DynamicProxy;
using Level_3.Abstract;
using Level_3.Aspects;
using Level_3.Concrete;
using Level_3.Interceptor;
using System;
using System.Reflection;

namespace Level_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;

            var container = new ContainerBuilder();
            container.RegisterType<ProductManager>()
                .As<IProductService>()
                .EnableClassInterceptors(new ProxyGenerationOptions { Selector = new InterceptorSelector() })
                .SingleInstance();

            var build = container.Build().BeginLifetimeScope();
            var item = build.Resolve<IProductService>();

            item.Add();
            item.Delete();

            Console.WriteLine("\n \n \n \n \n \n=====================================");
            Console.ResetColor();
        }
    }
}
