using System;

namespace session_10
{
    public class GenericsExample
    {
        private static void Example()
        {
            bool isEqual = false;

            isEqual = EqualsComparison.AreEqual(10, 20);
            isEqual = EqualsComparison.AreEqual("ABC", "ABC");
            isEqual = EqualsComparison.AreEqual(10.5, 20.5);
            Console.WriteLine(isEqual ? "Both are Equal" : "Both are Not Equal");
            Console.ReadKey();

            ////struct 
            //NodeList<int> lst1 = new NodeList<int>();    //No error, as int is a value type
            //NodeList<string> lst2 = new NodeList<string>(); //Error as string is a reference type
            //NodeList<Employee> lst3 = new NodeList<Employee>(); //Error as Employee is a reference type;

            ////class
            //NodeList<string> nodesOfString = new NodeList<string>();        // string is a reference type
            //var nodesOfEmployee = new NodeList<Employee>();  // Employee is a reference type
            //NodeList<int> nodesOfAction = new NodeList<int>();    //int is not a reference type

            ////new
            //NodeList<Employee> employeeNodes = new NodeList<Employee>(); //No Error, as Emplyoee has constructor of no parameters.
            //NodeList<Customer> customerNodes = new NodeList<Customer>(); //Error, as Customer has constructor which takes parameters.

            ////BaseEmployee
            //NodeList<Employee> employeeNodes = new NodeList<Employee>(); //No Error, as Emplyoee is inherited from BaseEmployee
            //NodeList<Customer> customerNodes = new NodeList<Customer>(); //Error, as Customer is not inheried from BaseEmployee
        }
    }

    public class EqualsComparison
    {
        public static bool AreEqual<T>(T value1, T value2)
        {
            return value1.Equals(value2);
        }
    }

    //public class NodeList<T> where T : struct
    //public class NodeList<T> where T : class
    //public class NodeList<T> where T : new() 
    public class NodeList<T> where T : BaseEmployee, new()
    {
        public void DoSomething(T input)
        {
            input.Department = "Something";

            T output = new T();
        }
    }

    public class BaseEmployee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }
    }

    public class Employee : BaseEmployee
    {
        public Employee() { }
        public Employee(int i) { }
    }

    public class Customer
    {
        public Customer(string customerName) { }
    }
}
