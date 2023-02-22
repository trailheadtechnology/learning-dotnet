using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session003
{
    public abstract class AbstractClass
    {
        // everyone gets the same implementation, may not override
        public void DoSomething()
        {
            //implementation
        }

        // everyone has to implement their own
        public abstract void AbstractMethod(int i);

        // everyone can choose what to do
        public virtual void VirtualMethod(int i)
        {
            // Default implementation which can be overridden by subclasses.
        }
    }

    public class DerivedClass : AbstractClass
    {
        // override = replacing base implementation

        // not possible
        //public override DoSomething()
        //{
        //}

        // shadowing 
        public new void DoSomething()
        {

        }

        public override void AbstractMethod(int i)
        {
            // do my own thing
        }
        public override void VirtualMethod(int i)
        {
            // do my own thing

            // let the base class do its own thing
            base.VirtualMethod(i);
        }
    }

    public class SampleClass
    {
        public void Main()
        {
            var x = new DerivedClass();
            x.DoSomething();
            x.AbstractMethod(1);
            x.VirtualMethod(1);
        }
    }
}
