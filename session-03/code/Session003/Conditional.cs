using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session003
{
    internal class Conditional
    {
        public void Main()
        {
            // default if statement
            if (true) //returns a bool
            {
                // this will run if condition is true
                Test();
                DoSomething();
            }

            // oneline if statement TRY TO AVOID
            if (true) Test();

            // if...else
            if (true)
            {
                // this will run if condition is true
            }
            else
            {
                // this will run if condition is false
            }

            // if...else if...else
            var x = 1;
            if (x < 2)
            {
                // runs if the "if" condition is true
            }
            else if (x < 3)
            {
                // runs if the "else if" condition is true but the "if" condition was false
            }
            else if (x < 4)
            {
                // runs if the "else if" condition is true but the "if" condition was false
            }
            else if (x < 5)
            {
                // runs if the "else if" condition is true but the "if" condition was false
            }
            else
            {
                // catch all
            }

            // switch statement
            switch (x) //like a "when"
            { 
                case 1:
                case 2:
                case 3:
                    DoSomething();
                    break; //break is live "leave"
                case 4:
                    DoSomething();
                    break;
                case 5:
                    DoSomething();
                    break;
                default:
                    Test();
                    break;
            }

            // ternary operator, inline-if
            string myString = (x == 1) ? "X has a 1" : "X does not have a 1";

            // identical to above
            string myString2;
            if (x == 1)
            {
                myString2 = "X has a 1";
            }
            else
            {
                myString2 = "X does not have a 1";
            }

            // yuck
            myString = 
                x == 1
                ? "X has a 1" 
                : x == 2
                ? "X has a 2"
                : x == 3
                ? "X has a 3"
                : "X does not have a 1, 2, or 3";
        }

        public bool Test()
        {
            return true;
        }

        public void DoSomething()
        { }
    }
}
