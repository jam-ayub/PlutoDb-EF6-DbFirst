using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbFirstDotNet46
{
    public class Program
    {
        static void Main(string[] args)
        {
            var _dbContext = new PlutoDbContext();
            var courses = _dbContext.GetCourses();

            var author = _dbContext.GetAuthorCourses(2);

            foreach (var course in courses)
            {
                Console.WriteLine(course.Title);
            }
            Console.ReadLine();
        }
    }
}
