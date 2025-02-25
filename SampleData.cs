using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    internal static class SampleData
    {
        public static List<Student> students = new List<Student>()
        {
            new Student()
            {
                ID=1, FirstName="Ali", LastName="Mohammed",
                Subjects =new Subject[]
                {
                    new Subject() { Code=22, Name="EF"},
                    new Subject() { Code=33, Name="UML"}
                }
            },


            new Student()
            {
                ID=2, FirstName="Mona", LastName="Gala",
                Subjects =new Subject []
                {
                    new Subject() {Code=22,Name="EF"},
                    new Subject() {Code=34,Name="XML"},
                    new Subject() {Code=25, Name="JS"}
                }
            },

            new Student()
            {
                ID=3, FirstName="Yara", LastName="Yousf",
                Subjects=new Subject[]
                {
                    new Subject (){Code=22,Name="EF"},
                    new Subject (){Code=25,Name="JS"}
                }
            },
            new Student()
            {
                ID=1, FirstName="Ali", LastName="Ali",
                Subjects=new Subject []
                {
                    new Subject (){ Code=33,Name="UML"}
                }
            }
            };
    }
}
