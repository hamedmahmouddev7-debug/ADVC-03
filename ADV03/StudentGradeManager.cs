using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADV03
{
    public static class StudentGradeManager
    {
        public static void Run()
        {
            Console.WriteLine("=== Student Grade Manager ===");

            List<int> grades = new List<int> { 85, 92, 78, 95, 88, 70, 100, 65 };

            Console.WriteLine("Grades: " + string.Join(", ", grades));
            Console.WriteLine($"Count: {grades.Count}");
            Console.WriteLine($"First Grade: {grades.First()}");
            Console.WriteLine($"Last Grade: {grades.Last()}");

            grades.Sort();
            Console.WriteLine("Sorted Ascending: " + string.Join(", ", grades));

            int firstAbove90 = grades.First(g => g > 90);
            Console.WriteLine($"First Grade Above 90: {firstAbove90}");
            List<int> failingGrades = grades.Where(g => g < 75).ToList();
            Console.WriteLine("Failing Grades (below 75): " + string.Join(", ", failingGrades));

            grades.RemoveAll(g => g < 75);
            Console.WriteLine("Grades After Removing Failing: " + string.Join(", ", grades));

            bool hasPerfectScore = grades.Any(g => g == 100);
            Console.WriteLine($"Any Grade Equals 100: {hasPerfectScore}");

            List<string> gradeLabels = grades.Select(g => $"Grade: {g}").ToList();
            Console.WriteLine("Grade Labels: " + string.Join(", ", gradeLabels));
        }
    }
}
