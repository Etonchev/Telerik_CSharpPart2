using System;

class MaximalSum
{
    static void Main()
    {
        int row = 0;
        int col = 0;
        Console.Write("Enter number of rows: ");
        row = int.Parse(Console.ReadLine());
        Console.Write("Enter number of colons: ");
        col = int.Parse(Console.ReadLine());
        int[,] matrix = new int[row, col];

        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < col; j++)
            {
                Console.Write("matrix[{0}, {1}] = ", i, j);
                matrix[i, j] = int.Parse(Console.ReadLine());
            }
        }

        int currentSum = 0;
        int maxSum = int.MinValue;

        for (int i = 0; i <= row - 3; i++)
        {
            for (int j = 0; j <= col - 3; j++)
            {
                currentSum = squareSum(matrix, i, j);
                if (currentSum > maxSum)
                {
                    maxSum = currentSum;
                }
            }
        }
        Console.WriteLine();
        Console.WriteLine("The maximum sum is: {0}", maxSum);
    }

    static int squareSum(int[,] matrix, int rowIndex, int colIndex)
    {
        int result = 0;

        for (int i = rowIndex; i < rowIndex + 3; i++)
        {
            for (int j = colIndex; j < colIndex + 3; j++)
            {
                result += matrix[i, j];
            }
        }

        return result;
    }
}