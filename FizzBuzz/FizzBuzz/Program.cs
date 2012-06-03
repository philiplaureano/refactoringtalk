using System;
using System.Collections.Generic;
using Hiro;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            // Manually register the dependencies
            var map = new DependencyMap();
            map.AddService<IRunner, Runner>();
            map.AddService<INumberDisplay, NumberDisplay>();
            map.AddService<INumberDisplay, ActualNumberDisplay>("ActualNumberDisplay");
            map.AddService<INumberPrinter, NumberPrinter>();

            var container = map.CreateContainer();

            var runner = container.GetInstance<IRunner>();
            runner.Run();
        }
    }
}
