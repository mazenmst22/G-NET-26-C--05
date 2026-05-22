
using System.Drawing;
using System.Security.Cryptography;

namespace G_NET_26_CSharp_05
{
    public class Program
    {
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

        }
    }
}
