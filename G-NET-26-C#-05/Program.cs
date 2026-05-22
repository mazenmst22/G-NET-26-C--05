
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
        }
    }
}
