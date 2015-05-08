using System;
using System.IO;

class MaximalAreaSum
{
    static int Sum2x2(int[,] matrix, int row, int columnumn)
    {
        int result = 0;

        for (int i = row; i < row + 2; i++)
        {
            for (int j = columnumn; j < columnumn + 2; j++)
            {
                result += matrix[i, j];
            }
        }

        return result;
    }

    static void Main()
    {
        StreamReader reader = new StreamReader(@"E:\matrix.txt");
        using (reader)
        {
            string line = reader.ReadLine();
            int matrixSize = Convert.ToInt32(line);
            int[,] matrix = new int[matrixSize, matrixSize];
            for (int row = 0; row < matrixSize; row++)
            {
                line = reader.ReadLine();
                string[] numbers = line.Split(' ');
                for (int column = 0; column < matrixSize; column++)
                {
                    matrix[row, column] = Convert.ToInt32(numbers[column]);
                }
            }

            int currentSum = 0;
            int maxSum = int.MinValue;
            for (int i = 0; i <= matrixSize - 2; i++)
            {
                for (int j = 0; j <= matrixSize - 2; j++)
                {
                    currentSum = Sum2x2(matrix, i, j);
                    if (currentSum > maxSum)
                    {
                        maxSum = currentSum;
                    }
                }
            }

            StreamWriter writer = new StreamWriter(@"E:\MaxAreaSum.txt");
            using (writer)
            {
                writer.WriteLine(maxSum);
            }

            Console.WriteLine("File with maximum sum saved successfully !");
        }
    }
}