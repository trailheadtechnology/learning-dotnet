using System;
using System.Collections.Generic;
using System.Linq;

namespace session_09
{
    public class Delegates
    {
        public delegate string Reverse(string s);

        public static string ReverseString(string s)
        {
            return new string(s.Reverse().ToArray());
        }

        public static void ActionMethod(int i, int j)
        {
            //todo
        }

        public static void Example()
        {
            Reverse rev = ReverseString;
            Console.WriteLine(rev("a string"));

            Func<string, string> rev2 = ReverseString;
            Console.WriteLine(rev2("a string"));
        }

        public static void EventHandlerExample()
        {
            var myObject = new EventHandlerExample();
            myObject.MyEvent += new EventHandler(myObject_MyEvent);
            myObject.Method("argument example");
        }

        public static void myObject_MyEvent(object sender, EventArgs args)
        {
            Console.WriteLine(((MyEventArgs)args).Argument1);
        }

        public static void Example2()
        {
            List<int> list = new List<int>();

            for (int i = 1; i <= 100; i++)
            {
                list.Add(i);
            }

            // Delgates
            List<int> result = list.FindAll(
              delegate (int no)
              {
                  return (no % 2 == 0);
              }
            );

            // Func
            //Func<int, bool> func = delegate (int no)
            //  {
            //      return (no % 2 == 0);
            //  };
            //Predicate<int> predicate = new Predicate<int>(func);
            //List<int> result = list.FindAll(predicate);

            // lambda, lambda expression, arrow functions
            result = list.FindAll(i => i % 2 == 0);

            // lambda with block 
            //result = list.FindAll((int i) =>
            //{
            //    //multiple lines of code
            //    return i % 2 == 0; //need explicit return statement
            //});

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

            // Actions
            Action<int, int> myAction = ActionMethod;
            Action<int, int> myAction2 = (i, j) =>
            {
                //ActionMethod(i, j);
            };
        }
    }

    public class EventHandlerExample
    {
        public event EventHandler MyEvent;

        public void Method(string argument1)
        {
            FireMyEvent(argument1);
        }

        private void FireMyEvent(string argument1)
        {
            if (MyEvent != null)
            {
                MyEvent(this, new MyEventArgs { Argument1 = argument1 });
            }
        }
    }

    public class MyEventArgs : EventArgs
    {
        public string Argument1 { get; set; }
    }
}
