
namespace ConsoleApp17
{
    struct Fraction
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Fraction(int x, int y)
        {
            X = x;
            Y = y;
        }
        public override string ToString() => $"{X}/{Y}";
    }
    class ClFranction
    {
        public void Add(Fraction a, Fraction b)
        {
            if (a.Y == b.Y)
            {
                a.X += b.X;
            }
            else
            {
                a.X *= b.Y;
                b.X *= a.Y;
                a.Y *= b.Y;
                a.X += b.X;
            }
            Console.WriteLine(a.ToString());
        }
        public void Subtraction(Fraction a, Fraction b)
        {
            if (a.Y == b.Y)
            {
                a.X -= b.X;
            }
            else
            {
                a.X *= b.Y;
                b.X *= a.Y;
                a.Y *= b.Y;
                a.X -= b.X;
            }
            Console.WriteLine(a.ToString());
        }
        public void Multi(Fraction a, Fraction b)
        {
            a.X *= b.X;
            a.Y *= b.Y;
            Console.WriteLine(a.ToString());
        }
        public void Division(Fraction a, Fraction b)
        {
            if (a.X > b.Y)
            {
                a.X /= b.Y;
            }
            else
            {
                a.X = b.Y / a.X;
            }
            if (a.Y > b.X)
            {
                a.Y /= b.X;
            }
            else
            {
                a.Y = b.X / a.Y;
            }
            Console.WriteLine(a.ToString());
        }
    }
}