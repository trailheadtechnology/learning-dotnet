using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session003
{
    internal class Overloading
    {
        public void SendEmail()
        {
            SendEmail("default-to", "default body", "default subject", "", "");
        }

        public void SendEmail(string to) 
        {
            SendEmail(to, "default body", "default subject", "", "");
        }

        public void SendEmail(string to, string body) 
        {
            SendEmail(to, body, "default subject", "", "");
        }

        public void SendEmail(string to, string body, string subject) 
        { 
        }

        public void SendEmail(string to, string body, string subject, string cc, string bcc)
        {
            // send the email here
        }
        public void SendEmail(string to, string body, string subject, string cc) 
        { 
        }


        // can't do this because the signatures match
        //public void SendEmail(int i, int j) { }
    }

    public class Sample3
    {
        public void Main()
        {
            var x = new Overloading();
            x.SendEmail("jtower@trailheadtechnology.com");
        }
    }
}
