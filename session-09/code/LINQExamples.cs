using System;
using System.Collections.Generic;
using System.Linq;

namespace session_09
{
    // LInQ = Language INtegrate Query
    public class LINQExamples
    {
        public class Student
        {
            public int StudentID { get; set; }
            public string StudentName { get; set; }
            public int Age { get; set; }
            public int StandardID { get; set; }
        }

        public class Standard
        {
            public int StandardID { get; set; }
            public string StandardName { get; set; }
        }

        public static void Example()
        {
            int[] nums = new int[] { 2, 0, 1 };
            
            // query syntax
            var results = from a in nums 
                          where a < 3 
                          orderby a 
                          select a;

            // method syntax
            var results2 = nums.Where(a => a < 3).OrderBy(a => a).Select(a => a);

            var studentList = new List<Student>() {
                new Student() { StudentID = 1, StudentName = "John", Age = 18, StandardID = 1 } ,
                new Student() { StudentID = 2, StudentName = "Steve",  Age = 21, StandardID = 1 } ,
                new Student() { StudentID = 3, StudentName = "Bill",  Age = 18, StandardID = 2 } ,
                new Student() { StudentID = 4, StudentName = "Ram" , Age = 20, StandardID = 2 } ,
                new Student() { StudentID = 5, StudentName = "Ron" , Age = 21 }
            };

            var standardList = new List<Standard>() {
                new Standard(){ StandardID = 1, StandardName="Standard 1"},
                new Standard(){ StandardID = 2, StandardName="Standard 2"},
                new Standard(){ StandardID = 3, StandardName="Standard 3"}
            };

            // Multiple Select and where operator
            var studentNames = studentList
                                  .Where(s => s.Age > 18)
                                  .Select(s => s)
                                  .Where(st => st.StandardID > 0)
                                  .Select(s => s.StudentName);

            // LINQ Query returns Collection of Anonymous Objects
            var teenStudentsName = from s in studentList
                                   where s.Age > 12 && s.Age < 20
                                   select new { StudentName = s.StudentName };
            teenStudentsName.ToList().ForEach(s => Console.WriteLine(s.StudentName));

            // Group By
            var studentsGroupByStandard = from s in studentList
                                          group s by s.StandardID into sg
                                          orderby sg.Key
                                          select new { sg.Key, TotalAge = sg.Sum(s => s.Age) };

            //foreach (var group in studentsGroupByStandard)
            //{
            //    Console.WriteLine("StandardID {0}:", group.Key);
            //    group.sg.ToList().ForEach(st => Console.WriteLine(st.StudentName));
            //}

            // Left Outer
            var studentsGroup = from stad in standardList
                                join s in studentList
                                    on stad.StandardID equals s.StandardID
                                    into sg
                                select new
                                {
                                    StandardName = stad.StandardName,
                                    Students = sg
                                };

            foreach (var group in studentsGroup)
            {
                Console.WriteLine(group.StandardName);
                group.Students.ToList().ForEach(st => Console.WriteLine(st.StudentName));
            }

            // Inner Join
            var studentWithStandard = from s in studentList
                                      join stad in standardList
                                            on s.StandardID equals stad.StandardID
                                      select new
                                      {
                                          StudentName = s.StudentName,
                                          StandardName = stad.StandardName
                                      };

            studentWithStandard.ToList().ForEach(s => 
                Console.WriteLine("{0} is in {1}", s.StudentName, s.StandardName));

            // Nested Query
            var nestedQueries = from s in studentList
                                where s.Age > 18 && s.StandardID ==
                                    (from std in standardList
                                     where std.StandardName == "Standard 1"
                                     select std.StandardID).FirstOrDefault()
                                select s;

            nestedQueries.ToList().ForEach(s => Console.WriteLine(s.StudentName));

            // first
            var s1 = studentList.First();
            s1 = studentList.FirstOrDefault();

            // single
            var s2 = studentList.Single(s => s.StudentID == 1);
            s2 = studentList.SingleOrDefault(s => s.StudentID == 1);

            // any
            bool adultsExist = studentList.Any(s => s.Age > 18);

            // orber by desc
            var oldestFirst = studentList.OrderByDescending(s => s.Age);

            // ToList(), IEnumerable -> List<>
            // "eager" evaluation
            List<Student> oddStudents = studentList
                .Where(s => s.StudentID % 2 != 0)
                .Select(s => s)
                .ToList();
            oddStudents = (from s in studentList
                           where s.StudentID % 2 != 0
                           select s).ToList();


            // ToDictionary()
            Dictionary<int, Student> studentDictionary = studentList
                .ToDictionary(s => s.StudentID, s => s);
            s1 = studentDictionary[1];
        }
    }
}
