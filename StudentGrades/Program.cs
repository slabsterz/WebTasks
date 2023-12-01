namespace StudentGrades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int studentCount = int.Parse(Console.ReadLine());
            List<double> averageGradeList = new List<double>();

            for (int i = 0; i < studentCount; i++)
            {
                string[] input = Console.ReadLine().Split();

                string name = input[0];
                int age = int.Parse(input[1]);
                double[] grades = input.Skip(2).Select(double.Parse).ToArray();

                AverageGrades averageGrades = new AverageGrades(name, age, grades);
                double averaged = averageGrades.CalculateAverageGrade(grades);
                averageGradeList.Add(averaged);
            }
            
            foreach (double averageGrades in averageGradeList)
            {                
                Console.WriteLine($"{averageGrades:f2}");
            }
        }
    }
}