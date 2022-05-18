using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session003
{
    internal class Sample2
    {
        public void MethodName()
        {
            return; // return control back to the calling method
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
            var combined = o.VariableNumberOfParams("a", "b", "c", "d", "", "");
        }
    }
}
