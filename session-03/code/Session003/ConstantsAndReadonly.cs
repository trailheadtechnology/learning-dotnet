using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session003
{
    public class ConstantsAndReadonly
    {
        public const string MY_CONSTANT_EXAMPLE = "asdf"; // CAN NEVER CHANGE VALUE AFTER INIT
        public readonly string _exampleReadOnly = "asdf"; // CAN CAN NOT CHANGE AFTER CONSTRUCTOR

        public ConstantsAndReadonly(string initValue)
        {
            Console.WriteLine(MY_CONSTANT_EXAMPLE); //read
            Console.WriteLine(_exampleReadOnly); //read

            //MY_CONSTANT_EXAMPLE = ""; //write - not allowed
            _exampleReadOnly = initValue; //write
        }

        public void DoSomething()
        {
            //MY_CONSTANT_EXAMPLE = ""; //write - not allowed
            //_exampleReadOnly = ""; //write - not allowed
        }
    }
}
