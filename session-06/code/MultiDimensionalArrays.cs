using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session_06
{
    public class MultiDimensionalArrays
    {
        public void Main()
        {
            int[] array = new int[2] { 1, 2 };

            // 1 2
            // 2 3
            // 3 1
            int[,] array2 = { { 1, 2 }, { 2, 3 }, { 3, 1 } };
            
            int[,,] array3 = new int [1,2,6];
        }
    }
}
