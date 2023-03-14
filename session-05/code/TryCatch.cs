using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session_05
{
    public class TryCatch
    {
        public int Method1(int parm, int parm2)
        {
            if (parm2 == 0)
                throw new MyException(nameof(parm2));

            return Method2(parm, parm2);
        }

        public int Method2(int parm, int parm2)
        {
            //try
            //{
            return Method3(parm, parm2);
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("In Method2");
            //    throw new Exception("My Own Exception"); // rethrows the Exception
            //}
        }

        public int Method3(int parm, int parm2)
        {
            //try
            //{

            return parm / parm2;

            //}
            //catch (DivideByZeroException)
            //{
            //    // not unusual to log here
            //    return 0;
            //}
            //finally
            //{
            //    // cleanup, runs no matter what
            //    // closing a connection to something (db, internet, etc)
            //}
        }
    }

    public class MyException : ArgumentException
    {
        public string ParamName { get; set; }
        public MyException(string paramName) : base($"{paramName} is invalid")
        {
            ParamName = paramName;
        }
    }
}
