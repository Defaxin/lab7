namespace ConsoleApp17
{
    struct СomplexNum
    {
        public double X { get; set; }
        public double Y { get; set; }
        public string C { get; set; }
        public СomplexNum(double x, double y, string c)
        {
            X = x;
            Y = y;
            C = c;
            if (c == "+" | c == "-")
            {

            }
            else Console.WriteLine("ERROR");
        }
        public override string ToString() => $"{X}{C}{Y}i";
    }
    class ClСmplxNum
    {
        public void Add(СomplexNum a, СomplexNum b)
        {
            if (a.C == "-")
            {
                a.Y *= -1;
            }
            if (b.C == "-")
            {
                b.Y *= -1;
            }
            a.X += b.X;
            a.Y += b.Y;
            Console.WriteLine(a.ToString());
        }
        public void Subtraction(СomplexNum a, СomplexNum b)
        {
            if (a.C == "-")
            {
                a.Y *= -1;
            }
            if (b.C == "-")
            {
                b.Y *= -1;
            }
            a.X -= b.X;
            a.Y -= b.Y;
            Console.WriteLine(a.ToString());
        }
        public void Multi(СomplexNum a, СomplexNum b)
        {
            if (a.C == "-")
            {
                a.Y *= -1;
            }
            if (b.C == "-")
            {
                b.Y *= -1;
            }
            double num1, num2, num3, num4;
            num1 = a.X * b.X;
            num2 = a.X * b.Y;
            num3 = a.Y * b.X;
            num4 = a.Y * b.Y;
            a.X = num1 - num4;
            a.Y = num2 + num3;
            Console.WriteLine(a.ToString());
        }
        public void Division(СomplexNum a, СomplexNum b)
        {
            if (a.C == "-")
            {
                a.Y *= -1;
            }
            if (b.C == "-")
            {
                b.Y *= -1;
            }
            double num1, num2, num3, num4, num5, num6;
            double x1, x2, x3;
            num1 = a.X * b.X;
            num2 = a.X * b.Y;
            num3 = a.Y * b.X;
            num4 = a.Y * b.Y;
            num5 = num1 - num4;
            num6 = num3 - num2;
            x1 = a.X * b.X;
            x2 = a.Y * b.Y;
            x3 = x1 + x2;
            a.X = num5 / x3;
            a.Y = num6;
            Console.WriteLine(a.ToString());
        }
    }
}