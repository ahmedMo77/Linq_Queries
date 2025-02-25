using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region declare a list of numbers

            //var list = new List<int> { 2, 4, 6, 7, 1, 4, 2, 9, 1 };

            //// query 1
            //var query1 = list.Distinct().Order();

            //foreach (var item in query1)
            //{
            //    Console.WriteLine(item);
            //}

            //// query 2
            //var query2 = list.Distinct().Order().Select(x => new { num = x, mul = x * x });

            //foreach (var item in query2)
            //{
            //    Console.WriteLine($"Number = {item.num}, Multiply = {item.mul}");
            //}

            #endregion



            #region declare an array of names
            //string[] names = { "Tom", "Dick", "Harry", "MARY", "Jay" };

            //// query 1
            //var query1 = names.Where(name => name.Length == 3);
            ////var query1 = from name in names where name.Length == 3 select name;

            //foreach (var item in query1)
            //{
            //    Console.WriteLine(item);
            //}


            //// query 2
            //var query2 = names.Where(name => name.ToLower().Contains('a')).OrderBy(name => name.Length);
            ////var query2 = from name in names where name.ToLower().Contains('a') orderby name.Length select name;
            //foreach (var item in query2)
            //{
            //    Console.WriteLine(item);
            //}

            //// query 3
            //var query3 = names.Take(2);
            //// 'partitioning' not used in query syntax

            //foreach (var item in query3)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region data from SmapleData class

            // query 1
            var query1 = SampleData.students.Select(stu => new { name = $"{stu.FirstName} {stu.LastName}", NoOfCources = stu.Subjects.Count() });
            foreach (var item in query1)
            {
                Console.WriteLine($"Full name: {item.name}, NoOfCources = {item.NoOfCources}");
            }

            // query 2
            var query2 = SampleData.students.OrderByDescending(stu => stu.FirstName).ThenBy(stu => stu.LastName).Select(stu => stu.FirstName + " " + stu.LastName);
            foreach (var item in query2)
            {
                Console.WriteLine(item);
            }

            // query 3
            var query3 = SampleData.students.SelectMany(stu => stu.Subjects.Select(subject => new { name = $"{stu.FirstName} {stu.LastName}", SubjectName = subject.Name }));
            foreach (var item in query3)
            {
                Console.WriteLine($"StudentName: {item.name}, SubjectName: {item.SubjectName}");
            }

            // query 4 Bonus
            var query4 = SampleData.students.GroupBy(stu => $"{stu.FirstName} {stu.LastName}").Select(group => new { name = group.Key, subjects = group.SelectMany(x => x.Subjects) });
            foreach (var student in query4)
            {
                //var listOfCourses = string.Join(", ", student.Select(stu => string.Join(", ", stu.Subjects.Select(sub => sub.Name))));
                var listOfCourses = string.Join(", ", student.subjects.Select(stu => stu.Name));
                Console.WriteLine(student.name);
                Console.WriteLine(listOfCourses);
                //foreach (var subject in student.subjects)
                //{
                //    Console.WriteLine(" - " + subject.Name);
                //}
            } 
            #endregion

        }
    }
}
