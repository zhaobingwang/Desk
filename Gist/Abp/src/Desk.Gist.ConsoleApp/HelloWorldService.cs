using System;
using Volo.Abp.DependencyInjection;

namespace Desk.Gist.ConsoleApp
{
    public class HelloWorldService : ITransientDependency
    {
        public void SayHello()
        {
            Console.WriteLine("Hello World!");
        }
    }
}
