using System;

class FillTheMatrix
{
    public static void printMatrix(int[,] matrix)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int column = 0; column < matrix.GetLength(0); column++)
            {
                Console.Write("{0,3}", matrix[row, column]);
            }
            Console.WriteLine();
        }
    }
    static void Main()
    {
        Console.Write("n = ");
        int n = Convert.ToInt32(Console.ReadLine());
        int startIndex = 1;
        //int[,] matrix = new int[n, n];
        //for (int row = 0; row < n; row++)
        //{
        //    for (int column = 0; column < n; column++)
        //    {
        //        Console.Write("matrix[{0}, {1}] = ", row, column);
        //        matrix[row, column] = Convert.ToInt32(Console.ReadLine());
        //    }
        //}
      
        //Subsection a)
        //int[,] matrix = new int[n, n];
        //for (int row = 0; row < n; row++)
        //{
        //    for (int column = 0; column < n; column++)
        //    {
        //        matrix[column, row] = startIndex;
        //        startIndex++;
        //    }
        //}

        //Subsection b)
        //int[,] matrix = new int[n, n];
        //for (int column = 0; column < n; column++)
        //{
        //    for (int row = 0; row < n; row++)
        //    {
        //        if (column % 2 == 0)
        //        {
        //            matrix[row, column] = startIndex;
        //        }
        //        else
        //        {
        //            matrix[n - row - 1, column] = startIndex;
        //        }
        //        startIndex++;
        //    }
        //}

        //Subsection c)

        printMatrix(matrix);
    }
}