//using System;
//using System.Text;

//class OneSystemToAnyOther
//{
//    static void Main()
//    {
//        Console.Write("Enter number: ");
//        string input = Console.ReadLine().ToUpper();
//        Console.Write("Base system: ");
//        int fromBase = Convert.ToInt32(Console.ReadLine());
//        Console.Write("System to convert to: ");
//        int target = Convert.ToInt32(Console.ReadLine());

//        long decimalNumber = ConvertToDecimal(input, fromBase);
//        string result = ConvertFromDecimal(decimalNumber, target);

//        Console.WriteLine("Initial number: {0}\nThe number in the target system: {1}",
//            input, result);
//    }

//    static long ConvertToDecimal(string number, int fromBase)
//    {
//        long result = 0;
//        for (int i = number.Length - 1; i >= 0; i--)
//        {
//            if (char.IsDigit(number[i]))
//            {
//                result += int.Parse(number[i].ToString()) * (long)Math.Pow(fromBase, number.Length - i - 1);
//            }
//            else
//            {
//                result += (number[i] - 'A' + 10) * (long)Math.Pow(fromBase, number.Length - i - 1);
//            }
//        }
//        return result;
//    }

//    static string ConvertFromDecimal(long number, int toBase)
//    {
//        string result = "";
//        if (number == 0)
//        {
//            result = "0";
//        }
//        else
//        {
//            while (number > 0)
//            {
//                if (number % toBase < 10)
//                {
//                    result = number % toBase + result;
//                }
//                else
//                {
//                    result = (char)(number % toBase + 'A' - 10) + result;
//                }
//                number /= toBase;
//            }
//        }
//        return result;
//    }
//}