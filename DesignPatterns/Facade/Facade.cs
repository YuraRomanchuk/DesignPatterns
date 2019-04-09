using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Facade
{
    class Facade
    {
        private SubClass1 subClass1;

        private SubClass2 subClass2;

        public Facade(SubClass1 subClass1, SubClass2 subClass2)
        {
            this.subClass1 = subClass1;
            this.subClass2 = subClass2;
        }

        public void Operation()
        {
            this.subClass1.Operation();
        }
    }

    class SubClass1
    {
        public string Operation()
        {
            return "oper1";
        }
    }

    class SubClass2
    {
        public string Operation()
        {
            return "oper2";
        }
    }

    class Client
    {
        public void Operation(Facade facade)
        {
            facade.Operation();
        }
    }
}
