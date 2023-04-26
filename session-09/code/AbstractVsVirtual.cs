using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session_09
{
    public abstract class BaseClass
    {
        // must be overridden, no implementation
        public abstract decimal GetArea(decimal Radius);

        // can be overridden, has implementation
        public virtual decimal InterestPerMonth(decimal amount)
        {
            return amount * 12 / 100;
        }

        // can be overridden, has implementation
        public virtual decimal TotalAmount(decimal Amount, decimal principleAmount)
        {
            return Amount + principleAmount;
        }
    }

    public class DerivedClass : BaseClass
    {
        public override decimal GetArea(decimal Radius)
        {
            return 2 * (22 / 7) * Radius;
        }

        public override decimal InterestPerMonth(decimal amount)
        {
            return base.InterestPerMonth(amount) * 2;
        }
    }
}
