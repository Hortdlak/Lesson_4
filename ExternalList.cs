using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_4
{
    public static class ExternalList
    {
        public static List<Student> GetStudents()
        {
            return new List<Student>
            {
                new Student("Alice", 25, "Science"),
                new Student("Bob", 25, "Science"),
                new Student("Charlie", 19, "Engineering"),
                new Student("David", 30, "Arts"),
                new Student("Eve", 21, "Science")
            };
        }
    }
}
