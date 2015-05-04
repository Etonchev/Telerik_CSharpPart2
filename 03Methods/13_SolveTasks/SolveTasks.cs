using System;

class SolveTasks
{
    public static int ReverseNumber(int number)
    {
        int reversedNumber = 0;
        while (number > 0)
        {
            reversedNumber *= 10;
            reversedNumber += number % 10;
            number /= 10;
        }

        return reversedNumber;
    }
    public static double FindAverage(int[] array)
    {
        int sum = 0;
        foreach (var item in array)
        {
            sum += item;
        }

        double average = sum / array.Length;
        return average;
    }
    public static void Main()
    {
        Console.WriteLine("-----------------------Menu-----------------------");
        Console.WriteLine("1. Reverse digits of a number");
        Console.WriteLine("2. Calculate the average of a sequence of integers");
        Console.WriteLine("3. Solve a linear equation a * x + b = 0");
        Console.WriteLine("4. Exit");

        int input = Convert.ToInt32(Console.ReadLine());
        switch (input)
        {
            case 1:
                {
                    Console.Write("Enter number: ");
                    int number = Convert.ToInt32(Console.ReadLine());
                    if (number < 0)
                    {
                        throw new Exception("Number should be non-neagitve");
                    }

                    Console.WriteLine(ReverseNumber(number));
                    break;
                }
            case 2:
                {
                    Console.Write("Total numbers: ");
                    int n = Convert.ToInt32(Console.ReadLine());
                    int[] array = new int[n];
                    for (int i = 0; i < n; i++)
                    {
                        Console.Write("array[{0}] = ");
                        array[i] = Convert.ToInt32(Console.ReadLine());
                    }

                    Console.WriteLine(FindAverage(array));
                    break;
                }
            case 3:
                {
                    Console.Write("a: ");
                    int a = Convert.ToInt32(Console.ReadLine());
                    Console.Write("b: ");
                    int b = Convert.ToInt32(Console.ReadLine());

                    double x = -1.0 * b / a;
                    Console.WriteLine(x);
                    break;
                }
            case 4:
                break;
            default:
                Console.WriteLine("Please enter number between 1-4 !");
                break;
        }
    }
}
