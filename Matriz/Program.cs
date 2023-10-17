using System;

class Program
{
    static void Main()
    {
        int[,] matrix = {
            {1, 2, 3},
            {4, 0, 6},
            {7, 8, 9}
        };

        Console.WriteLine("Matriz original:");
        PrintMatrix(matrix);

        SetZeroes(matrix);

        Console.WriteLine("Matriz con filas y columnas a 0:");
        PrintMatrix(matrix);
    }

    static void SetZeroes(int[,] matrix)
    {
        int numRows = matrix.GetLength(0);
        int numCols = matrix.GetLength(1);

        // Arrays para rastrear las filas y columnas que contienen 0
        bool[] zeroRows = new bool[numRows];
        bool[] zeroCols = new bool[numCols];

        // Identificar las filas y columnas que contienen 0
        for (int i = 0; i < numRows; i++)
        {
            for (int j = 0; j < numCols; j++)
            {
                if (matrix[i, j] == 0)
                {
                    zeroRows[i] = true;
                    zeroCols[j] = true;
                }
            }
        }

        // Establecer filas a 0
        for (int i = 0; i < numRows; i++)
        {
            if (zeroRows[i])
            {
                for (int j = 0; j < numCols; j++)
                {
                    matrix[i, j] = 0;
                }
            }
        }

        // Establecer columnas a 0
        for (int j = 0; j < numCols; j++)
        {
            if (zeroCols[j])
            {
                for (int i = 0; i < numRows; i++)
                {
                    matrix[i, j] = 0;
                }
            }
        }
    }

    static void PrintMatrix(int[,] matrix)
    {
        int numRows = matrix.GetLength(0);
        int numCols = matrix.GetLength(1);

        for (int i = 0; i < numRows; i++)
        {
            for (int j = 0; j < numCols; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
