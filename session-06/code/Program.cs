using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var p = new PartialClass1();

            p.Method1();
            p.Method2();

            string s = "    sdf lkjLKJLKJ LKJLll ";
            //s = s.Trim().ToLower();
            //s = ExtensionMethod.CleanString(s);
            s = s.CleanString();
        }

        public async void DoSomethingAsync()
        {
            var x = new AsyncAwait();
            var y = await x.GetUrlContentLengthAsync();
        }
    }
}
