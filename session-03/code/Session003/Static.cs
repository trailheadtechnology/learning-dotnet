using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session003
{
    public class MyClass
    {
        private MyClass() { } // now I can't create these outside of this class

        public static int Id { get; set; }

        public void DoSomething()
        {
            var i = Id * 100;
            Id = 55;
        }
        public static MyClass CreateAMyClass() // in VB.NET static is called "shared"
        {
            return new MyClass();
        }
    }

    public class EmailSender
    {
        private EmailSender() { }

        public void Send() { }

        private static EmailSender _instance;
        public static EmailSender Current
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new EmailSender();
                }
                return _instance;
            }
        }
    }

    internal class Static
    {
        public void Main()
        {
            //var mc = new MyClass();

            //var mc = MyClass.CreateAMyClass();
            //MyClass.Id = 12;
            //mc.DoSomething();

            //var mc2 = MyClass.CreateAMyClass();
            //MyClass.Id = 89;

            // singlton pattern
            var sc = EmailSender.Current;
            sc.Send();
            EmailSender.Current.Send();
        }
    }
}
