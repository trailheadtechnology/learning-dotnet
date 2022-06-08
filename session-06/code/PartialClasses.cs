using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// compiled into a dll that I'm referencing
namespace session_06
{
    public partial class PartialClass1
    {
        public void Method1()
        {
            //this.Method2();
            _privateInt = 1;
            return;
        }
    }
}
