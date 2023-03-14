using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session_05
{
    internal class Collections
    {
        public void Main()
        {
            object myObj = 14; //boxing
            int j = (int)myObj + 12; //unboxing

            // ArrayList (not really used any more)
            ArrayList al = new ArrayList();
            al.Add(1);
            al.Add("");
            al.Add(12.34f);
            al.Add(new ArrayList());

            // List - USED FREQUENTLY
            List<int> myList = new List<int>() { 1, 3 };
            List<int> myList2 = new List<int>() { 4, 5, 6 };
            myList.Insert(1, 2);
            //myList.Add(""); //not valid
            myList[1] = 2;
            var myInt = myList[1];
            myList.AddRange(myList2);
            myList.Sort();

            List<string> myListofStrings = new List<string> { "z", "b" };
            myListofStrings.Sort();

            // SortedList
            SortedList<string, int> peopleAges = new SortedList<string, int>();
            peopleAges.Add("Person 4", 59);
            peopleAges.Add("Person 2", 43);
            //peopleAges.Add("Person 2", 43); can't use the same key twice
            peopleAges.Add("Person 1", 15);
            peopleAges.Add("Person 3", 2);
            peopleAges["Person 2"] = 44;
            
            // Queue - FIFO (FIRST IN, FIRST OUT)
            var queue = new Queue(); 
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Dequeue();
            Queue<int> queue1 = new Queue<int>();
            queue1.Enqueue(3);
            queue1.Dequeue();

            // Stack - LIFO (LAST IN, FIRST OUT)
            Stack s = new Stack();
            s.Push(1);
            s.Pop();    
            Stack<int> s1 = new Stack<int>();
            s1.Push(2);
            s1.Pop();

            // Dictionary, SortedDictionary
            Dictionary<int, Person> myDictionary = new Dictionary<int, Person>();
            myDictionary.Add(1, new Person { });
            myDictionary.ContainsKey(2);
            SortedDictionary<int, Person> keyValuePairs = new SortedDictionary<int, Person>();

            // IEnumerable
            // loop over the items in a collection
            foreach (var i in myList)
            {
                // don't change and ienumerable while looping over it
                //myList.Insert(0, 1);
            }
        }

        public class Person
        {
            public string Name { get; set; }
        }
    }
}
