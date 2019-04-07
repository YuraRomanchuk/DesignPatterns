using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Singleton
{
    class NotSingleton
    {
        public static NotSingleton instance;

        public static NotSingleton GetInstanceUnSafe
        {
            get
            {
                return new NotSingleton();
            }

        }
    }

}
