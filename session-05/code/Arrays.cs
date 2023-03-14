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
            int[] ints;
            byte[] data = new byte[7000];
            int[] x = { 1, 2, 3 };
            Array.Resize(ref x, 6);
            int[] z = new int[6];
            x.CopyTo(z, 3);

            int[] y = { 4, 5, 6 };
            int[] y2 = new int[3];

            var twoDim = new int[100,100];
            var j2 = twoDim[0, 0];

            var products = new Product[100];
            products[0] = new Product() { Description = "", ItemNumber = "", ProductId = 123 };

            y2[0] = 4;
            y2[1] = 5;
            y2[2] = 6;

            string[] strArray = { };
            PutMeInAnArray[] putMeInAnArrays;

            // arrays can't be changed
            //int[] z = x.Concat(y).ToArray();

            // referencing an array item using index
            var j = x[x.Length - 1];
            var k = x[1];
            x[1] = 1;
        }

        public class Product
        {
            public int ProductId;
            public string ItemNumber;
            public string Description;
        }
    }

    public class PutMeInAnArray
    {
        public void Sort()
        {
            int[,] array = { { 1, 4 }, { 2, 5 }, { 3, 6 } };

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); i++)
                {
                    array[i,j] = 0;
                }
            }

            foreach (int item in array)
            {
                Console.WriteLine(item);   
            }
        }
    }
}
