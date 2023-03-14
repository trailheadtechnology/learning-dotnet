using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session_05
{
    internal class Dispose
    {
        public void Main()
        {
            //var myObj = new MyResourceOwningClass();
            //try
            //{
            //    //somethign that could go wrong
            //}
            //catch (Exception)
            //{

            //    throw;
            //}
            //finally
            //{
            //    myObj.Dispose();
            //}

            using (var myObj2 = new MyResourceOwningClass())
            {
                //somethign that could go wrong
                try
                {
                    myObj2.DoSomething();
                }
                catch (Exception)
                {
                    //custom exception handling logic
                }
            } //no matter what, .Dispose() is called right here
        }

        public class MyResourceOwningClass : IDisposable
        {
            public void DoSomething()
            {

            }
            private void CleanUp()
            {
                //where the resources are released or cleaned up
            }

            public void Dispose()
            {
                CleanUp();
            }
        }
    }
}
