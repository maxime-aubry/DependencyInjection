using DependencyInjection;
using DependencyInjection.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (DependencyInjectionServices dis = DependencyInjectionHandler.ServiceProvider.GetService<DependencyInjectionServices>())
            {
                dis.LocalizationService.GetResource();
            }
        }
    }
}
