using System;

class SequenceNMatrix
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int m = int.Parse(Console.ReadLine());

        string[,] matrix = new string[n, m];
        for (int i = 0; i < n; ++i)
        {
            for (int j = 0; j < m; ++j)
            {
                Console.Write("matrix[{0}, {1}] = ", i, j);
                matrix[i, j] = Console.ReadLine();
            }
        }

        const int vSequence = 0;
        const int hSequence = 1;
        const int diagSequenceRight = 2;
        const int diagSequenceLeft = 3;

        int[] deltaX = new int[] { 1, 0, 1, 1 };
        int[] deltaY = new int[] { 0, 1, 1, -1 };

        int[, ,] newMatrix = new int[n, m, 4];

        int maxLength = 0;
        int bestRow = 0, bestCol = 0;

        for (int i = 0; i < n; ++i)
        {
            for (int j = 0; j < m; ++j)
            {
                for (int k = 0; k < 4; ++k)
                {
                    newMatrix[i, j, k] = 1;
                }

                if (i > 0 && matrix[i, j].Equals(matrix[i - 1, j]))
                {
                    newMatrix[i, j, vSequence] = newMatrix[i - 1, j, vSequence] + 1;
                }
                if (j > 0 && matrix[i, j].Equals(matrix[i, j - 1]))
                {
                    newMatrix[i, j, hSequence] = newMatrix[i, j - 1, hSequence] + 1;
                }
                if (i > 0 && j > 0 && matrix[i, j].Equals(matrix[i - 1, j - 1]))
                {
                    newMatrix[i, j, diagSequenceRight] = newMatrix[i - 1, j - 1, diagSequenceRight] + 1;
                }
                if (i > 0 && j < n - 1 && matrix[i, j].Equals(matrix[i - 1, j + 1]))
                {
                    newMatrix[i, j, diagSequenceLeft] = newMatrix[i - 1, j + 1, diagSequenceLeft] + 1;
                }

                for (int k = 0; k < 4; ++k)
                {
                    if (newMatrix[i, j, k] > maxLength)
                    {
                        maxLength = newMatrix[i, j, k];
                        bestRow = i;
                        bestCol = j;
                    }
                }
            }
        }
        for (int i = 0; i < maxLength; i++)
        {
            Console.WriteLine("{0}, ", matrix[bestRow, bestCol]);
        }

        Console.WriteLine();
    }
}
