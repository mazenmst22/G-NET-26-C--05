
using G_NET_26_C__05;
using System.Drawing;
using System.Security.Cryptography;

namespace G_NET_26_CSharp_05
{
    public class Program
    {
        #region Part 3 Methods
        #region Q1
        static double Add(double a, double b)
        {
            return a + b;
        }

        static double Subtract(double a, double b)
        {
            return a - b;
        }

        static double Multiply(double a, double b)
        {
            return a * b;
        }

        static double Divide(double a, double b)
        {
            return a / b;
        }
        #endregion
        #region Q2
        static void CalculateCircle(double radius, out double area, out double circumference)
        {
            area = Math.PI * radius * radius;
            circumference = 2 * Math.PI * radius;
        }
        #endregion
        #endregion
        #region Student grade Manager Methods
        #region GetGrade 
        static Grade GetGrade(int score)
        {
            if (score >= 90) return Grade.A;
            if (score >= 80) return Grade.B;
            if (score >= 70) return Grade.C;
            if (score >= 60) return Grade.D;
            return Grade.F;
        }
        #endregion
        #region CalculateAverage 
        static double CalculateAverage(int[] scores)
        {
            double sum = 0;
            for (int i = 0; i < scores.Length; i++)
            {
                sum += scores[i];
            }
            return sum / scores.Length;
        }
        #endregion
        #region GetMinMax
        static void GetMinMax(int[] scores, out int min, out int max)
        {
            min = scores[0];
            max = scores[0];

            for (int i = 1; i < scores.Length; i++)
            {
                if (scores[i] < min)
                {
                    min = scores[i];
                }
                if (scores[i] > max )
                {
                    max = scores[i];
                }
            }
        }
        #endregion
        #endregion
        public static void Main(string[] args)
        {
            #region Part 1
            Console.Write("Enter a day number (1-7): ");
            if (int.TryParse(Console.ReadLine(), out int dayNumber))
            {
                DaysOfWeek selectedDay = (DaysOfWeek)dayNumber;

                Console.WriteLine($"Day: {selectedDay}");

                switch (selectedDay)
                {
                    case DaysOfWeek.Friday:
                    case DaysOfWeek.Saturday:
                        Console.WriteLine("It's the Weekend");
                        break;
                    case DaysOfWeek.Sunday:
                    case DaysOfWeek.Monday:
                    case DaysOfWeek.Tuesday:
                    case DaysOfWeek.Wednesday:
                    case DaysOfWeek.Thursday:
                        Console.WriteLine("It's a Workday");
                        break;
                    default:
                        Console.WriteLine("Invalid day range.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }
            #endregion
            #region Part 2
            #region Q1
            Console.WriteLine();
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine();
            Console.Write("Enter array size: ");
            if (int.TryParse(Console.ReadLine(), out int Size) && Size > 0)
            {
                var numbers = new int[Size];
                for (int i = 0; i < Size; i++)
                {
                    Console.Write($"Enter element [{i}]: ");
                    numbers[i] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine();
                int sum = 0, min = numbers[0], max = numbers[0];
                for (int i = 0; i < Size; i++)
                {
                    sum += numbers[i];

                    if (numbers[i] > max)
                    {
                        max = numbers[i];
                    }

                    if (numbers[i] < min)
                    {
                        min = numbers[i];
                    }
                }

                double average = (double)sum / Size;
                Console.WriteLine($"Sum     = {sum}");
                Console.WriteLine($"Average = {average}");
                Console.WriteLine($"Max     = {max}");
                Console.WriteLine($"Min     = {min}");

                Console.Write("Reverse = ");
                for (int i = Size - 1; i >= 0; i--)
                {
                    Console.Write(numbers[i]);
                    if (i > 0)
                    {
                        Console.Write(", ");
                    }
                }
                Console.WriteLine();

            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }
            #endregion
            #region Q2
            Console.WriteLine();
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine();
            double[,] grades = new double[3, 4];
            double totalClassSum = 0;

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Enter Grades for Student: {i + 1}:");
                double studentSum = 0;

                for (int j = 0; j < 4; j++)
                {
                    Console.Write($"Subject {j + 1}: ");
                    grades[i, j] = Convert.ToDouble(Console.ReadLine());
                    studentSum += grades[i, j];
                    totalClassSum += grades[i, j];
                }

                double studentAverage = studentSum / 4;
                Console.WriteLine($"Student {i + 1} Average: {studentAverage:F2}\n");
            }

            double classAverage = totalClassSum / 12.0;
            Console.WriteLine($"Overall Class Average: {classAverage:F2}");


            #endregion
            #endregion
            #region Part 3
            #region Q1
            Console.WriteLine();
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine();

            Console.Write("Enter first number: ");

            string input1 = Console.ReadLine();
            double num1 = Convert.ToDouble(input1);

            Console.Write("Enter second number: ");

            string input2 = Console.ReadLine();
            double num2 = Convert.ToDouble(input2);

            Console.Write("Enter operation (+, -, *, /): ");

            string operation = Console.ReadLine();

            switch (operation)
            {
                case "+":
                    Console.WriteLine(Add(num1, num2));
                    break;
                case "-":
                    Console.WriteLine(Subtract(num1, num2));
                    break;
                case "*":
                    Console.WriteLine(Multiply(num1, num2));
                    break;
                case "/":
                    if (num2 == 0)
                    {
                        Console.WriteLine("Cannot divide by zero.");
                    }
                    else
                    {
                        Console.WriteLine(Divide(num1, num2));
                    }
                    break;
                default:
                    Console.WriteLine("Invalid operation.");
                    break;
            }
            #endregion
            #region Q2
            Console.WriteLine();
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine();
            Console.Write("Enter radius to calculate: ");
            string radInput = Console.ReadLine();

            double radius = Convert.ToDouble(radInput);

            CalculateCircle(radius, out double area, out double circumference);

            Console.WriteLine($"Radius: {radius}");
            Console.WriteLine($"Area: {area:F3}");
            Console.WriteLine($"Circumference: {circumference:F3}");
            #endregion
            #endregion
            #region Student Grade Manager
            Console.WriteLine();
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine();
            int[] scores = new int[5];

            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Enter score for Student {i + 1}: ");
                scores[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine();
            Console.WriteLine("--- Report ---");

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Student {i + 1}: {scores[i]} -> Grade: {GetGrade(scores[i])}");
            }

            Console.WriteLine();
            Console.WriteLine($"Average: {CalculateAverage(scores):F1}");

            GetMinMax(scores, out int min2, out int max2);
            Console.WriteLine($"Highest Score: {max2}");
            Console.WriteLine($"Lowest Score: {min2}");

            #endregion

        }
    }
}
