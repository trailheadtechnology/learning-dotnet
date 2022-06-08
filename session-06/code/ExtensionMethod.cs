using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session_06
{
    public static class ExtensionMethod
    {
        public static string CleanString(this string input)
        {
            //only have access to public members of the class here
            return input.Trim().ToLower();
        }

        // ...
    }
}
