using System;

class SubtractMultiplyPolynomials
{
    public static int[] SubtractPolynomials(int[] smaller, int[] larger)
    {
        int[] first = smaller;
        int[] second = larger;
        if (Math.Max(smaller.Length, larger.Length) == smaller.Length)
        {
            int[] temp = smaller;
            smaller = larger;
            larger = temp;
        }

        Array.Reverse(smaller);
        Array.Reverse(larger);
        int[] result = new int[larger.Length];
        for (int i = 0; i < smaller.Length; i++)
        {
            result[i] = first[i] - second[i];
        }

        for (int j = smaller.Length; j < larger.Length; j++)
        {
            if (first == larger)
            {
                result[j] = larger[j];
            }
            else
            {
                result[j] = larger[j] * -1;
            }
        }

        Array.Reverse(result);
        return result;
    }
    static int[] MultiplyPolynomials(int[] first, int[] second)
    {
        int[] result = new int[first.Length + second.Length - 1];
        for (int i = 0; i < first.Length; i++)
        {
            for (int j = 0; j < second.Length; j++)
            {
                result[i + j] += first[i] * second[j];
            }

        }
        return result;
    }
    static void PrintPolynomial(int[] polynomial)
    {
        foreach (var item in polynomial)
        {
            Console.Write(item + " ");
        }

        Console.WriteLine();
    }
    static void Main()
    {
        int[] firstPolynomial = { 2, 3 };
        int[] secondPolynomial = { 1, 1, 1 };
        int[] subtracted = SubtractPolynomials(firstPolynomial, secondPolynomial);
        int[] multiplied = MultiplyPolynomials(firstPolynomial, secondPolynomial);

        PrintPolynomial(subtracted);
        PrintPolynomial(multiplied);
    }
}