using Autofac;
using Autofac.Extras.DynamicProxy;
using Castle.DynamicProxy;
using DynamicProxyDemo.Concrete;
using DynamicProxyDemo.Interceptors;
using System;

namespace DynamicProxyDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;


            ContainerBuilder container=new ContainerBuilder();
            container.RegisterType<LogAspect>();
            container.RegisterType<CacheAspect>();
            container.RegisterType<ProductManager>().EnableClassInterceptors().SingleInstance();
            var referance=container.Build().BeginLifetimeScope();
            var service=referance.Resolve<ProductManager>();
            service.Add();


            Console.ResetColor();
        }
    }

}
