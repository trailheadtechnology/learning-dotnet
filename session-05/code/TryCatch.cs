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
            if (parm == 0)
                throw new MyException("Cannot divide by zero");

            return Method2(parm, parm2);
        }

        public int Method2(int parm, int parm2)
        {
            try
            {
                return Method3(parm, parm2);
            }
            catch (Exception)
            {
                throw; // rethrows the Exception
            }
        }

        public int Method3(int parm, int parm2)
        {
            try
            {
                return parm / parm2;
            }
            catch (DivideByZeroException)
            {
                // not unusual to log here
                return 0;
            }
            finally
            {
                // cleanup, runs no matter what
                // closing a connection to something (db, internet, etc)
            }
        }
    }

    public class MyException: ArgumentException
    {
        public MyException(string message) : base(message)
        {

        }
    }
}
