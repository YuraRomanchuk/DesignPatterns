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
    public class Singleton
    {
        public static Singleton instance;

        private static readonly Lazy<Singleton> lazy = new Lazy<Singleton>(() => new Singleton());

        public static Singleton GetInstanceSafeLazy => lazy.Value;

        public static Singleton GetInstanceUnSafe
        {
            get
            {
                if (instance == null)
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
}
