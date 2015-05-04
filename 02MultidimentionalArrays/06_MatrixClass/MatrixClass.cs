using System;

public class Matrix
{
    public int[,] MatrixData { get; set; }

    public Matrix(int n, int m, params int[] numbers)
    {
        MatrixData = new int[n, m];
    }

    public int GetLength(int dimension)
    {
        return this.MatrixData.GetLength(dimension);
    }
    public int this[int row, int column]
    {
        get
        {
            return MatrixData[row, column];
        }
        set
        {
            MatrixData[row, column] = value;
        }
    }
    public override string ToString()
    {
        string result = String.Empty;
        for (int row = 0; row < MatrixData.GetLength(0); row++)
        {
            for (int column = 0; column < MatrixData.GetLength(1); column++)
            {
                result += string.Format("{0, 3}", MatrixData[row, column]);
            }

            result += "\n";
        }

        return result;
    }
    public static Matrix operator +(Matrix m1, Matrix m2)
    {
        if (m1.GetLength(0) != m2.GetLength(0) || m1.GetLength(1) != m2.GetLength(1))
        {
            throw new Exception("Can't add matrix with different dimensions");
        }

        Matrix result = new Matrix(m1.GetLength(0), m1.GetLength(1));
        for (int row = 0; row < result.GetLength(0); row++)
        {
            for (int column = 0; column < result.GetLength(1); column++)
            {
                result[row, column] = m1[row, column] + m2[row, column];
            }
        }

        return result;
    }
    public static Matrix operator -(Matrix m1, Matrix m2)
    {
        if (m1.GetLength(0) != m2.GetLength(0) || m1.GetLength(1) != m2.GetLength(1))
        {
            throw new Exception("Can't add matrix with different dimensions");
        }

        Matrix result = new Matrix(m1.GetLength(0), m1.GetLength(1));
        for (int row = 0; row < result.GetLength(0); row++)
        {
            for (int column = 0; column < result.GetLength(1); column++)
            {
                result[row, column] = m1[row, column] - m2[row, column];
            }
        }

        return result;
    }
    public static Matrix operator *(Matrix m1, Matrix m2)
    {
        if (m1.GetLength(0) != m2.GetLength(1))
        {
            throw new Exception("Matrixes can only be multiplied if rows of first matrix is equel to columns of second matrix");
        }

        Matrix result = new Matrix(m1.GetLength(0), m1.GetLength(1));
        for (int row = 0; row < result.GetLength(0); row++)
        {
            for (int column = 0; column < result.GetLength(1); column++)
            {
                for (int k = 0; k < m1.GetLength(0); k++)
                {
                    result[row, column] += m1[row, k] * m2[k, column];
                }
            }
        }

        return result;
    }
}