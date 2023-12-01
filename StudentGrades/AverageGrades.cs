using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGrades
{
    public class AverageGrades
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public double[] Grades { get; set; }

        public AverageGrades(string name, int age, double[] grades) 
        { 
            this.Name = name;
            this.Age = age;
            this.Grades = new double[grades.Length];
        }

        public double CalculateAverageGrade(double[] grade)
        {
            double average = grade.Average();
            return average;
        }

        public AverageGrades() { }
    }
}
