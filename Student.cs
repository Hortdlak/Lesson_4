using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_4
{
    public class Student
    {
        public string Name { get; set; }

        public double Age { get; set; }

        public string Facility { get; set; }

        public Student (string name, double age, string facility)
        {
            Name = name;
            Age = age;
            Facility = facility;
        }
    }
}
