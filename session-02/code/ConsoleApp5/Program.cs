using Namespace1;
using ns2 = Namespace2.Class1;
using System;

namespace MyConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// VALUE TYPE
            //int i = 100;
            //Console.WriteLine(i);
            //ChangeValueType(i);
            //Console.WriteLine(i);

            //Console.WriteLine();
            ns2 class2 = new ns2();

            // REFERENCE TYPE
            Student std1 = new Student { StudentName = "Bill" };
            Console.WriteLine(std1.StudentName);
            ChangeReferenceType(std1);
            Console.WriteLine(std1.StudentName);

            Console.ReadKey();
        }

        static void ChangeValueType(int x)
        {
            x = 200;
            Console.WriteLine(x);
        }

        static void ChangeReferenceType(Student std2)
        {
            std2.StudentName = "Steve";
            Console.WriteLine(std2.StudentName);
        }
    }

    public class Student
    {
        public string StudentName { get; set; }
    }
}
