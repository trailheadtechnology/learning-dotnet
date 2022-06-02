using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session_05
{
    internal class Arrays
    {
        public void Main()
        {
            byte[] data = new byte[7000];
            int[] x = { 1, 2 };
            int[] y = { 4, 5, 6 };
            int[] y2 = new int[3];
            y2[0] = 4;
            y2[1] = 5;
            y2[2] = 6;

            string[] strArray = { };
            PutMeInAnArray[] putMeInAnArrays;

            // arrays can't be changed
            int[] z = x.Concat(y).ToArray();

            // referencing an array item using index
            var j = x[x.Length - 1];
        }
    }

    public class PutMeInAnArray
    {
        public int[] Sort(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                var item = array[i];
            }
            foreach(int item in array)
            {

            }

            return array;
        }
    }
}
