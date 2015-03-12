using System;

class TriangleSurface
{
    public static double TriangleArea(double side, double height)
    {
        return (side * height) / 2.0;
    }
    public static double TriangleArea(double sideA, double sideB, double sideC)
    {
        double semiPerimeter = (sideA + sideB + sideC) / 2;
        double area = Math.Sqrt(semiPerimeter * (semiPerimeter - sideA) * (semiPerimeter - sideB) * (semiPerimeter - sideC));
        return area;
    }
    public static double TriangleArea(double sideA, double sideB, int angle)
    {
        double area = (sideA * sideB) / 2 * Math.Sin(angle * Math.PI / 180);
        return area;
    }
    static void Main()
    {
        Console.WriteLine("0. Calculate triangle area by side and height");
        Console.WriteLine("1. Calculate triangle area by three sides");
        Console.WriteLine("2. Calculate triangle area by two sides and angle");
        int input = Convert.ToInt32(Console.ReadLine());
        switch (input)
        {
            case 0: 
                Console.Write("Side: ");
                double side = Convert.ToDouble(Console.ReadLine());
                Console.Write("Height: ");
                double height = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine(TriangleArea(side, height));
                break;
            case 1: 
                Console.WriteLine("SideA: ");
                double sideA = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("SideB: ");
                double sideB = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("SideC: ");
                double sideC = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("{0:0.00}", TriangleArea(sideA, sideB, sideC));
                break;
            case 2: 
                Console.WriteLine("SideA: ");
                double firstSide = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("SideB: ");
                double secondSide = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Angle degrees: ");
                int angle = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("{0:0.00}", TriangleArea(firstSide, secondSide, angle));
                break;
            default:
                Console.WriteLine("Wrong input !");
                break;
        }
    }
}