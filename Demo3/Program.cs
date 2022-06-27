using Autofac;
using Autofac.Extras.DynamicProxy;
using Castle.DynamicProxy;
using Demo3.Aspects;
using Demo3.Interceptors;
using DynamicProxy.Concrete;
using System;

namespace Demo3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;


            ContainerBuilder container = new ContainerBuilder();

            container.RegisterType<LogAspect>();
            container.RegisterType<CacheAspect>();
            container.RegisterType<ProductManager>()
                .EnableClassInterceptors(new ProxyGenerationOptions
                {
                    Selector = new InterceptorSelector()
                })
                .SingleInstance();



            var referance = container.Build().BeginLifetimeScope();
            var service = referance.Resolve<ProductManager>();
            service.Add();

            Console.ResetColor();
        }
    }
}
