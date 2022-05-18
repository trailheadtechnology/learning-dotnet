using System;

namespace Session003
{
    public class Email
    {
        private bool _sent = false;

        private string _to;
        public string To
        {
            get
            {
                // replace domain with ****** jtower@trailheadtechnology.com -> jtower@****.com
                return _to;
            }
            set
            {
                //check to see if the email was already sent
                if (_sent)
                {
                    //throw an exception
                    throw new InvalidOperationException("Can't change To address after sending");
                }
                else
                {
                    _to = value;
                }
            }
        }

        public string From { get; set; }
        //public string _from;
        //public string From { get { return _from; } set { _from = value; } }
        public string Subject { get; set; }

        public string body;

        public void Send()
        {
            _sent = true;
            //todo
        }
    }

    public class OtherClass
    {
        public void Main()
        {
            var email = new Email() { body = "", From = "", Subject = "", To = "initial email" };
            email.Send();
            //email.To = "some other email";
        }
    }
}
