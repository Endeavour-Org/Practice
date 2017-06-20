using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listing2_49_CreatingAnAbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        abstract class Base
        {
            public virtual void MethodWithImplementation() { /* Method Details */ }

            public abstract void AbstractMethod();
        }

        class Derived : Base
        {
            public override void AbstractMethod()
            {
                /* Method Details*/
            }
        }
    }
}
