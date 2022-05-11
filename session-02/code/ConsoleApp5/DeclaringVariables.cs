using System;

namespace ConsoleApp5
{
    internal class DeclaringVariables
    {
        // TYPE NAME
        public void SampleDeclarationMethod()
        {
            int x; //variable declaration
            int i = 1; //variable declaration and initialization
            int j = SubMethod(); //variable declaration and initialization from method return value
            string s = "";
            SampleClass sc = new SampleClass();

            Console.WriteLine();

            int y;
        }

        public void UsingVarKeyword()
        {
            //var x; //not allowed
            var i = 1;
            var j = SubMethod();
            var s = "";
            var sc = new SampleClass();
        }

        public void DynamicKeyword()
        {
            // don't use this right now
            dynamic i = 1;
            dynamic j = new { FirstName = "J.", LastName = "Tower" };
        }

        public int SubMethod()
        {
            return 10;
        }

        public int UselessMethod(int i)
        {
            return i;
        }
    }

    public class SampleClass
    {

    }
}
