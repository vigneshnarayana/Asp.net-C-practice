using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //// list te num are less then 5
            //int[] num = { 5, 2, 1, 7, 4, 8, 9, 0, 3, 2, 4 };

            //var nums = from n in num
            //           where n < 5
            //           select n;

            //foreach(var val in nums)
            //{
            //    Console.WriteLine(val);
            //}
            /*   NorthwindEntities north = new NorthwindEntities();

               var WACustomer = from n in north.Customers
                                where n.Region == "WA"
                                select n;

               foreach(var val in WACustomer)
               {
                   Console.WriteLine("{0},{1},{2}",val.CompanyName,val.CustomerID,val.ContactTitle);

               }
               north.Dispose();
               */
            /*
         string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "nine", "ten" };

         var showdigits = digits.Where((digit , index)=> digit.Length > index);
         foreach(var n in showdigits)
         {
             Console.WriteLine(n);
         } */

            /*
            int[] nums = new int[] { 0, 2,9,3,4,1 };
            var res = from a in nums where a < 9 orderby a select a;
            foreach (int i in res)
                Console.WriteLine(i);
                */

            /*
            int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            int[] numbersB = { 1, 3, 5, 7, 8 };
            var pairs = from a in numbersA from b in numbersB where a < b select new { a, b };
            Console.WriteLine("Pairs where a < b:");
            foreach (var pair in pairs)
            {
                Console.WriteLine("{0} is less than {1}", pair.a, pair.b);
            }
            */
            /*
            string[] words = { "cherry", "apple", "blueberry" };
            var sortedWords = from w in words orderby w select w;
            Console.WriteLine("The sorted list of words:");
            foreach (var w in sortedWords)
            {
                Console.WriteLine(w);
            }
            */
            /*
            //count
            //int[] factorsOf300 = { 2, 2, 3, 5, 5 };
            //int uniqueFactors = factorsOf300.Distinct().Count();
            //Console.WriteLine("There are {0} unique factors of 300.", uniqueFactors);
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            int oddNumbers = numbers.Count(n => n % 2 == 1);  // or // int oddNumbers = numbers.Where(n => n % 2 == 1).Count();

            Console.WriteLine("There are {0} odd numbers in the list.", oddNumbers);

    */
            /*
             * //Contains
                // string collection
                IList<string> stringList = new List<string>() {
                         "C# Tutorials",
                      "VB.NET Tutorials",
                          "Learn C++",
                     "MVC Tutorials" ,
                       "Java"
                          };

                // LINQ Query Syntax
                var result = from s in stringList
                             where s.Contains("Tutorials")
                             select s;
                  //or /// var result = stringList.Where(s => s.Contains("Tutorials"));

                foreach(var n in result)
                {
                    Console.WriteLine(n);
                }
                */
            /*
                    IList<Student> studentList = new List<Student>() {
                    new Student() { StudentID = 1, StudentName = "John", Age = 13} ,
                    new Student() { StudentID = 2, StudentName = "Moin",  Age = 21 } ,
                    new Student() { StudentID = 3, StudentName = "Bill",  Age = 18 } ,
                    new Student() { StudentID = 4, StudentName = "Ram" , Age = 20} ,
                    new Student() { StudentID = 5, StudentName = "Ron" , Age = 15 }
                };

                        var filteredResult = from s in studentList
                                             where s.Age > 12 && s.Age < 20
                                             select s.StudentName;


                        foreach(var n in filteredResult)
                        {
                            Console.WriteLine(n);

                        }

                */
            /* //OfType 

        IList mixedList = new ArrayList();
        mixedList.Add(0);
        mixedList.Add("One");
        mixedList.Add("Two");
        mixedList.Add(3);
        mixedList.Add(new Student() { StudentID = 1, StudentName = "Bill" });

        var stringResult = from s in mixedList.OfType<string>()
                           select s;

        var intResult = from s in mixedList.OfType<int>()
                        select s;
        foreach(var n in stringResult)
        {
            Console.WriteLine(n);
        }
        */

            /*
                 IList<Student> studentList = new List<Student>() {
                new Student() { StudentID = 1, StudentName = "John", Age = 18 } ,
                new Student() { StudentID = 2, StudentName = "Steve",  Age = 15 } ,
                new Student() { StudentID = 3, StudentName = "Bill",  Age = 25 } ,
                new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 } ,
                new Student() { StudentID = 5, StudentName = "Ron" , Age = 19 }
            };
                        //ORDER BY - Ascending and descending order  
                        var orderByResult = from s in studentList
                                            orderby s.StudentName
                                            select s;

                        var orderByDescendingResult = from s in studentList
                                                      orderby s.StudentName descending
                                                      select s;
                        //ThenBy - after the Ascending and descending order  
                        var thenByResult = studentList.OrderBy(s => s.StudentName).ThenBy(s => s.Age);

                        var thenByDescResult = studentList.OrderBy(s => s.StudentName).ThenByDescending(s => s.Age);
                        //Group By
                        var groupedResult = from s in studentList
                                            group s by s.Age;

                        foreach (var n in groupedResult)
                        {
                            Console.WriteLine(n.Key);
                            foreach (Student s in n) // Each group has inner collection
                                Console.WriteLine("Student Name: {0}", s.StudentName);
                        }
            */
            /* Joins

            IList<string> strList1 = new List<string>() {
    "One",
    "Two",
    "Three",
    "Four",
    "Six"

};

            IList<string> strList2 = new List<string>() {
    "One",
    "Two",
    "Five",
    "Six"
};

            var innerJoin = strList1.Join(strList2,
                                  str1 => str1,
                                  str2 => str2,
                                  (str1, str2) => str1);

            foreach(var n in innerJoin)
            {
                Console.WriteLine(n);
            }

    */
            /* joins
                    IList<Student> studentList = new List<Student>() {
            new Student() { StudentID = 1, StudentName = "John", StandardID =1 },
            new Student() { StudentID = 2, StudentName = "Moin", StandardID =1 },
            new Student() { StudentID = 3, StudentName = "Bill", StandardID =2 },
            new Student() { StudentID = 4, StudentName = "Ram" , StandardID =2 },
            new Student() { StudentID = 5, StudentName = "Ron"  }
        };

                    IList<Standard> standardList = new List<Standard>() {
            new Standard(){ StandardID = 1, StandardName="Standard 1"},
            new Standard(){ StandardID = 2, StandardName="Standard 2"},
            new Standard(){ StandardID = 3, StandardName="Standard 3"}
        };

                    var innerJoin = studentList.Join(// outer sequence 
                                          standardList,  // inner sequence 
                                          student => student.StandardID,    // outerKeySelector
                                          standard => standard.StandardID,  // innerKeySelector
                                          (student, standard) => new  // result selector
                              {
                                              StudentName = student.StudentName,
                                              StandardName = standard.StandardName
                                          });
                    foreach(var n in innerJoin)
                    {
                        Console.WriteLine(n);
                    }

            */


            /*

               IList<Student> studentList = new List<Student>() {
               new Student() { StudentID = 1, StudentName = "John", StandardID =1 },
               new Student() { StudentID = 2, StudentName = "Moin", StandardID =1 },
               new Student() { StudentID = 3, StudentName = "Bill", StandardID =2 },
               new Student() { StudentID = 4, StudentName = "Ram",  StandardID =2 },
               new Student() { StudentID = 5, StudentName = "Ron" }
           };

                IList<Standard> standardList = new List<Standard>() {
               new Standard(){ StandardID = 1, StandardName="Standard 1"},
               new Standard(){ StandardID = 2, StandardName="Standard 2"},
               new Standard(){ StandardID = 3, StandardName="Standard 3"}
           };

                       var groupJoin = standardList.GroupJoin(studentList,  //inner sequence
                                                       std => std.StandardID, //outerKeySelector 
                                                       s => s.StandardID,     //innerKeySelector
                                                       (std, studentsGroup) => new // resultSelector 
                                           {
                                                           Students = studentsGroup,
                                                           StandarFulldName = std.StandardName
                                                       });

                       foreach (var item in groupJoin)
                       {
                           Console.WriteLine(item.StandarFulldName);

                           foreach (var stud in item.Students)
                               Console.WriteLine(stud.StudentName);
                       }
           */

            /* //SELECT  and ALL
            IList<Student> studentList = new List<Student>() {
    new Student() { StudentID = 1, StudentName = "John", Age = 13 } ,
    new Student() { StudentID = 2, StudentName = "Moin",  Age = 21 } ,
    new Student() { StudentID = 3, StudentName = "Bill",  Age = 18 } ,
    new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 } ,
    new Student() { StudentID = 5, StudentName = "Ron" , Age = 15 }
}; 
            //SELECT

            var selectResults = from s in studentList
                               select s.StudentName;

            var selectResult = from s in studentList
                               select new { Name = "Mr. " + s.StudentName, Age = s.Age };

            var selectResult12 = studentList.Select(s => new {
                Name = s.StudentName,
                Age = s.Age
            });
            // ALL

            bool areAllStudentsTeenAger = studentList.All(s => s.Age > 12 && s.Age < 20);

            Console.WriteLine(areAllStudentsTeenAger);
            foreach (var n in selectResult12)
            {

                Console.WriteLine(n);
            }
            */
            /*
                        // Contains- Like
                        IList<int> intList = new List<int>() { 1, 2, 3, 4, 5 };
                        bool result = intList.Contains(10);  // returns false
                        //Aggregate
                        IList<String> strList = new List<String>() { "One", "Two", "Three", "Four", "Five" };

                        var commaSeperatedString = strList.Aggregate((s1, s2) => s1 + ", " + s2);

                        Console.WriteLine(commaSeperatedString); //One, Two, Three, Four, Five

                */
            /*
                  // AVG
                    IList<int> intLists = new List<int> () { 10, 20, 30,40 };

                    var avg = intLists.Average();

                    Console.WriteLine("Average: {0}", avg);


            */
            /*
            //MAX
            IList<int> intList = new List<int>() { 10, 21, 30, 45, 50, 87 };

            var largest = intList.Max();

            Console.WriteLine("Largest Element: {0}", largest);

            var largestEvenElements = intList.Max(i => {
                if (i % 2 == 0)
                    return i;

                return 0;
            });
            var largestEvenElementss = intList.Max(i => i % 2 == 0); //true
           

            Console.WriteLine("Largest Even Element: {0}", largestEvenElements);
            */
            /*
            //SUM

            IList<int> intList = new List<int>() { 10, 21, 30, 45, 50, 87 };

            var total = intList.Sum();

            Console.WriteLine("Sum: {0}", total);

            var sumOfEvenElements = intList.Sum(i => {
                if (i % 2 == 0)
                    return i;

                return 0;
            });

            Console.WriteLine("Sum of Even Elements: {0}", sumOfEvenElements);

    */
            /*
                    //ElementAt, ElementAtOrDefault
                    IList<int> intList = new List<int>() { 10, 21, 30, 45, 50, 87 };
                    IList<string> strList = new List<string>() { "One", "Two", null, "Four", "Five" };

                    Console.WriteLine("1st Element in intList: {0}", intList.ElementAt(0));
                    Console.WriteLine("1st Element in strList: {0}", strList.ElementAt(0));

                    Console.WriteLine("2nd Element in intList: {0}", intList.ElementAt(1));
                    Console.WriteLine("2nd Element in strList: {0}", strList.ElementAt(1));

                    Console.WriteLine("3rd Element in intList: {0}", intList.ElementAtOrDefault(2));
                    Console.WriteLine("3rd Element in strList: {0}", strList.ElementAtOrDefault(2));

                    Console.WriteLine("10th Element in intList: {0} - default int value",
                                    intList.ElementAtOrDefault(9));
                    Console.WriteLine("10th Element in strList: {0} - default string value (null)",
                                     strList.ElementAtOrDefault(9));


                    Console.WriteLine("intList.ElementAt(9) throws an exception: Index out of range");
                    Console.WriteLine("-------------------------------------------------------------");
                    Console.WriteLine(intList.ElementAt(9));
                    */
            //First and Last
            /*
            IList<int> intList = new List<int>() { 7, 10, 21, 30, 45, 50, 87 };
            IList<string> strList = new List<string>() { null, "Two", "Three", "Four", "Five" };
            IList<string> emptyList = new List<string>();

            Console.WriteLine("1st Element in intList: {0}", intList.First());
            Console.WriteLine("1st Even Element in intList: {0}", intList.First(i => i % 2 == 0));

            Console.WriteLine("1st Element in strList: {0}", strList.Last());

            Console.WriteLine("emptyList.First() throws an InvalidOperationException");
            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine(emptyList.First());
           */
            /*
            //FirstOrDefault and LastOrDefault
            IList<int> intList = new List<int>() { 7, 10, 21, 30, 45, 50, 87 };
            IList<string> strList = new List<string>() { null, "Two", "Three", "Four", "Five" };
            IList<string> emptyList = new List<string>();

            Console.WriteLine("1st Element in intList: {0}", intList.FirstOrDefault());
            Console.WriteLine("1st Even Element in intList: {0}",
                                             intList.FirstOrDefault(i => i % 2 == 0));

            Console.WriteLine("1st Element in strList: {0}", strList.FirstOrDefault());

            Console.WriteLine("1st Element in emptyList: {0}", emptyList.FirstOrDefault());

    */
            //IList<int> intList = new List<int>() { 7, 10, 21, 30, 45, 50, 87 };
            //IList<string> strList = new List<string>() { null, "Two", "Three", "Four", "Five" };

            //Console.WriteLine("1st Element which is greater than 250 in intList: {0}",
            //                                intList.First(i =>i > 2));

            //Console.WriteLine("1st Even Element in intList: {0}",
            //                                strList.FirstOrDefault(s => s.Contains("T")));

            /*
            IList<int> oneElementList = new List<int>() { 7 };
            IList<int> intList = new List<int>() { 7, 10, 21, 30, 45, 50, 87 };
            IList<string> strList = new List<string>() { null, "Two", "Three", "Four", "Five" };
            IList<string> emptyList = new List<string>();

            Console.WriteLine("The only element in oneElementList: {0}", oneElementList.Single());
            Console.WriteLine("The only element in oneElementList: {0}",
                         oneElementList.SingleOrDefault());

            Console.WriteLine("Element in emptyList: {0}", emptyList.SingleOrDefault());

            Console.WriteLine("The only element which is less than 10 in intList: {0}",
                         intList.Single(i => i < 10));
                         */
            /*  //SequenceEqual
              IList<string> strList1 = new List<string>() { "One", "Two", "Three", "Four", "Three" };

              IList<string> strList2 = new List<string>() { "One", "Two", "Three", "Four", "Three" };

              bool isEqual = strList1.SequenceEqual(strList2); // returns true
              Console.WriteLine(isEqual);
              */
            /*
             //Concat
             IList<string> collection1 = new List<string>() { "One", "Two", "Three" };
             IList<string> collection2 = new List<string>() { "Five", "Six" };

             var collection3 = collection1.Concat(collection2);

             foreach (string str in collection3)
                 Console.WriteLine(str); //one,two,three,Five,six

     */
            /*      //Distinct
                  IList<string> strList = new List<string>() { "One", "Two", "Three", "Two", "Three" };

                  IList<int> intList = new List<int>() { 1, 2, 3, 2, 4, 4, 3, 5 };

                  var distinctList1 = strList.Distinct();

                  foreach (var str in distinctList1)
                      Console.WriteLine(str);

                  var distinctList2 = intList.Distinct();

                  foreach (var i in distinctList2)
                      Console.WriteLine(i);

          */
            //EXCEPT, INTERSECT, UNION
            //TACK &TACKWHILE AND SKIP &SKIPWHILE

            //  Expression<Action<Student>> printStudentName = s => Console.WriteLine(s.StudentName);
            //deffer execution -above ex 
            /*
                        //Immidiate Execution
                        IList<Student> studentList = new List<Student>() {
                new Student() { StudentID = 1, StudentName = "John", Age = 13 } ,
                new Student() { StudentID = 2, StudentName = "Moin",  Age = 21 } ,
                new Student() { StudentID = 3, StudentName = "Bill",  Age = 18 } ,
                new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 } ,
                new Student() { StudentID = 5, StudentName = "Ron" , Age = 15 }
            };
                        IList<Student> teenAgerStudents = (from s in studentList
                                                           where s.Age > 12 && s.Age < 20
                                                           select s).ToList();
                        foreach (var n in teenAgerStudents)
                            Console.WriteLine(n.StudentName);
                            */

         /*
            //let andinto
            IList<Student> studentList = new List<Student>() {
    new Student() { StudentID = 1, StudentName = "John", Age = 18 } ,
    new Student() { StudentID = 2, StudentName = "Steve",  Age = 21 } ,
    new Student() { StudentID = 3, StudentName = "Bill",  Age = 18 } ,
    new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 } ,
    new Student() { StudentID = 5, StudentName = "Ron" , Age = 21 }
};

            //var lowercaseStudentNames = from s in studentList
            //                            where s.StudentName.ToLower().StartsWith("r")
            //                            select s.StudentName.ToLower();
            var lowercaseStudentNames = from s in studentList
                                        let lowercaseStudentName = s.StudentName.ToLower()
                                        where lowercaseStudentName.StartsWith("r")
                                        select lowercaseStudentName;
            var teenAgerStudents = from s in studentList
                                   where s.Age > 12 && s.Age < 20
                                   select s
                                   into teenStudents
                                   where teenStudents.StudentName.StartsWith("B")
                                   select teenStudents;
            //teenStudentsName.ToList().ForEach(s => Console.WriteLine(s.StudentName));
            teenAgerStudents.ToList().ForEach(s => Console.WriteLine(s.StudentName));
            //foreach (var n in teenAgerStudents)
            //    Console.WriteLine(n.StudentName);
            */
            Console.Read();
        }
    }
    public class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }
    }
    internal class Students
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public int StandardID { get; set; }
    }

    internal class Standard
    {
        public int StandardID { get; set; }
        public string StandardName { get; set; }
       
    }
}
