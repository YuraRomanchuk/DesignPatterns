using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Singleton
{
    /// <summary>
    /// Instance control– prevents other objects from instantiating their own copies of the Singleton object, ensuring that all objects access the single instance.
    /// Flexibility– since the class controls the instantiation process, the class has the flexibility to change the instantiation process.
    /// Lazy initialization– defers the object’s creation until it is first used.
    /// </summary>
    class Singleton
    {
        public static Singleton instance;

        public static Singleton GetInstanceUnSafe
        {
            get
            {
                if(instance == null)
                {
                    instance = new Singleton();
                }

                return instance;
            }

        }

        public static Singleton GetInstanceThreadSafe
        {
            get
            {
                if (instance == null)
                {
                    lock (instance)
                    {
                        if (instance == null)
                        {
                            instance = new Singleton();
                        }
                    }
                }

                return instance;
            }

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var a = Singleton.GetInstanceUnSafe;

            var b = Singleton.GetInstanceThreadSafe;

            if (a == b)
            {
                Console.WriteLine("Singleton works, both variables contain the same instance.");
            }
            else
            {
                Console.WriteLine("Singleton failed, variables contain different instances.");
            }

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
        }
    }
       
}
