using Autofac;
using Autofac.Core;
using Autofac.Extras.DynamicProxy;
using Level_1.Concrete;
using Level_1.Interceptor;
using System;

namespace Level_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;

            var container = new ContainerBuilder();
            container.RegisterType<CacheInterceptor>();
            container.RegisterType<ValidationInterceptor>();
            container.RegisterType<ProductManager>().EnableClassInterceptors();


            var build=container.Build().BeginLifetimeScope();
            var item=build.Resolve<ProductManager>();
            item.Add();

            Console.WriteLine("\n \n \n \n \n \n =====================================");
            Console.ResetColor();
        }
    }
}
