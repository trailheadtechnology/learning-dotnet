using System;
using System.Reflection;

namespace session_09
{
    [Author("J. Tower", version = 1.0)]
    [Author("Another Developer", version = 1.1)]
    public class AttributesExample
    {
        //[ApplySecurity()]
        //[ApplyValidation()]
        //public static void Endpoint(object obj)
        //{
        //    //todo
        //}
    }

    public static class ReflectionExample
    {
        public static void Example(AttributesExample attributesExample)
        {
            var t = attributesExample.GetType();
            var attrs = t.GetCustomAttributes<AuthorAttribute>();
            foreach (var attr in attrs)
            {
                Console.WriteLine($"{attr.name} {attr.version}");
            }

            Console.ReadKey();
        }
    }

    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct, AllowMultiple = true)]
    public class AuthorAttribute : Attribute
    {
        public string name;
        public double version;

        public AuthorAttribute(string name)
        {
            this.name = name;
            version = 1.0;
        }
    }
}
