using Autofac;
using Autofac.Extras.DynamicProxy;
using Castle.DynamicProxy;
using Level_4.Abstract;
using Level_4.Concrete;
using Level_4.Interceptor;
using System;
using System.Reflection;

namespace Level_4
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;

            var container = new ContainerBuilder();
            var assembly=Assembly.GetExecutingAssembly();
            container.RegisterAssemblyTypes(assembly)
                .AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions
                {
                    Selector=new InterceptorSelector()
                })
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
