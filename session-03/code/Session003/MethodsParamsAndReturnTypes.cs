using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session003
{
    internal class Sample2
    {
        public void MethodName(int i)
        {
            if (i == 0) return; // return control back to the calling method

            //code here
            // do some math that devides by i
            var x = 7 / i;
        }

        public string MethodName2()
        {
            var myString = "string example";
            return myString; // return control back to the calling method with a value
        }

        public bool TryToIncrement(int inVal, out int outVal)
        {
            inVal++;
            outVal = inVal;
            
            return true;
        }

        public void NamedParameters(int i, int j = -1, int x = -1, int y = -1)
        {
            if (x >= 0)
            {
                //logic
            }
        }

        public string VariableNumberOfParams(params string[] arr)
        {
            string result = "";
            foreach (var item in arr)
            {
                result = result + item;
            }
            return result;
        }
    }

    public class CallingCode2
    {
        private void Main()
        {
            var o = new Sample2();
            var x = "";
            var combined = o.VariableNumberOfParams("a", "b", "c", "d", "", "", "", "asdfasdf", x);

            o.NamedParameters(i: 1, y: 4, j: 2);
        }
    }
}
