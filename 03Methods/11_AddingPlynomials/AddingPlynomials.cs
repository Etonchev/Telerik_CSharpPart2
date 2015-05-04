using System;

class AddingPlynomials
{
    public static int[] AddPolynomials(int[] smaller, int[] larger)
    {
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
            result[i] = smaller[i] + larger[i];
        }

        for (int j = smaller.Length; j < larger.Length; j++)
        {
            result[j] = larger[j];
        }

        Array.Reverse(result);
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
        int[] added = AddPolynomials(firstPolynomial, secondPolynomial);

        PrintPolynomial(added);
    }
}