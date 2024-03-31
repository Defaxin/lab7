using ConsoleApp17;

namespace ConsoleApp11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var franct1 = new Fraction(4, 3);
            var franct2 = new Fraction(5, 4);
            var complx1 = new СomplexNum(4, 6, "+");
            var complx2 = new СomplexNum(4, 3, "+");
            var birthday1 = new BirthDay(15, 04, 2000);
            ClFranction cl = new ClFranction();
            ClСmplxNum cl2 = new ClСmplxNum();
            ClBirthDay cl3 = new ClBirthDay();
            int whil = 0;
            while (whil <= 0)
            {
                Console.WriteLine("\nChoose Task 1-3 or 4 to exit: ");
                int swh = int.Parse(Console.ReadLine());
                switch (swh)
                {
                    case 1:
                        Console.WriteLine("Frunct 1: " + franct1.ToString());
                        Console.WriteLine("Frunct 2: " + franct2.ToString());
                        cl.Add(franct1, franct2);
                        cl.Subtraction(franct1, franct2);
                        cl.Multi(franct1, franct2);
                        cl.Division(franct1, franct2);
                        break;
                    case 2:
                        Console.WriteLine("Complex Number 1: " + complx1.ToString());
                        Console.WriteLine("Complex Number 2: " + complx2.ToString());
                        cl2.Add(complx1, complx2);
                        cl2.Subtraction(complx1, complx2);
                        cl2.Multi(complx1, complx2);
                        cl2.Division(complx1, complx2);
                        break;
                    case 3:
                        Console.WriteLine("Birth Day: " + birthday1.ToString());
                        cl3.NextWeekInYear(birthday1);
                        cl3.NextDayInWeek(birthday1, 2024);
                        cl3.DayToBirthDay(birthday1);
                        break;
                    case 4:
                        whil = 1;
                        break;
                }
            }
        }
    }
}