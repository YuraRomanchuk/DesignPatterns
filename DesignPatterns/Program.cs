using DesignPatterns.Singleton;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class Program
    {
        static void Main(string[] args)
        {
            //var a = Singleton.GetInstanceUnSafe;

            //var b = Singleton.GetInstanceUnSafe;

            //if (a == b)
            //{
            //    Console.WriteLine("Singleton works, both variables contain the same instance.");
            //}
            //else
            //{
            //    Console.WriteLine("Singleton failed, variables contain different instances.");
            //}

            var c = NotSingleton.GetInstanceUnSafe;

            var d = NotSingleton.GetInstanceUnSafe;

            if (c == d)
            {
                Console.WriteLine("Singleton works, both variables contain the same instance.");
            }
            else
            {
                Console.WriteLine("Singleton failed, variables contain different instances.");
            }

            Client client = new Client();

            var simple = new ConcreteComponent();
            Console.WriteLine("Client: I get a simple component:");
            client.ClientCode(simple);
            Console.WriteLine();

            ConcreteDecoratorA decorator1 = new ConcreteDecoratorA(simple);
            ConcreteDecoratorB decorator2 = new ConcreteDecoratorB(decorator1);
            ConcreteDecoratorC decorator3 = new ConcreteDecoratorC(decorator2);
            Console.WriteLine("Client: Now I've got a decorated component:");
            client.ClientCode(decorator3);
        }
    }
}
