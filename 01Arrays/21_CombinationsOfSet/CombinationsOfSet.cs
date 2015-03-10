using System;
using System.Collections.Generic;

class CombinationsGenerator
{
    static int NumberOfLoops;
    static int NumberOfIterations;
    static int[] Loops;

    static void Main()
    {

        Console.Write("N: ");
        NumberOfIterations = Convert.ToInt32(Console.ReadLine());

        Console.Write("K: ");
        NumberOfLoops = Convert.ToInt32(Console.ReadLine());

        Loops = new int[NumberOfLoops];

        NestedLoops(0, 1);
    }

    static void NestedLoops(int CurrentLoop, int CurrentNumber)
    {
        if (CurrentLoop == NumberOfLoops)
        {
            PrintLoops();
        }
        else
        {
            for (int i = CurrentNumber; i <= NumberOfIterations; i++)
            {
                Loops[CurrentLoop] = i;
                NestedLoops(CurrentLoop + 1, i + 1);
            }
        }
    }

    static void PrintLoops()
    {
        for (int i = 0; i < NumberOfLoops; i++)
        {
            Console.Write("{0} ", Loops[i]);
        }
        Console.WriteLine();
    }
}