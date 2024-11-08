using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbFirstDotNet46
{
    public class Program
    {
        public enum Level : byte
        {
            Beginner = 1,
            Intermediate = 2,
            Advanced = 3
        }

        static void Main(string[] args)
        {
            var _dbContext = new PlutoDbContext();
            var courses = _dbContext.GetCourses();

            var author = _dbContext.GetAuthorCourses(2);

            var course = new Cours();
            course.Level = CourseLevel.Begginer;

            foreach (var c in courses)
            {
                Console.WriteLine(c.Title);
            }
            Console.ReadLine();
        }
    }
}
