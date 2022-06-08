using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session_06
{
    public partial class PartialClass1
    {
        private int _privateInt;

        public void Method2()
        {
            //this.Method1();
            _privateInt = 2;
            return;
        }
    }
}
