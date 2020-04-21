using System;

namespace task2Lab3
{
  class Task2Lab3
  {
    static Random rnd = new Random();

    public static void createRandom(int[,] matrix)
    {
      for (int i = 0; i < matrix.GetUpperBound(0) + 1; i++)
      {
        for (int j = 0; j < matrix.GetUpperBound(1) + 1; j++)
        {
          matrix[i, j] = rnd.Next(1, 20);
        }
      }
    }

    public static void printMatrix(int[,] matrix)
    {
      for (int i = 0; i < matrix.GetUpperBound(0) + 1; i++)
      {
        for (int j = 0; j < matrix.GetUpperBound(1) + 1; j++)
        {
          Console.Write(matrix[i, j].ToString().PadLeft(4));
        }
        Console.WriteLine("");
      }
      Console.WriteLine("\n");
    }

    public static int RowsCount(int[,] matrix)
    {
      return matrix.GetUpperBound(0) + 1;
    }

    public static int ColumnsCount(int[,] matrix)
    {
      return matrix.GetUpperBound(1) + 1;
    }


    public static int[,] MultyMatrix(int[,] matrixA, int[,] matrixB)
    {
      if (ColumnsCount(matrixA) != RowsCount(matrixB))
      {
        throw new Exception("Умножение не возможно! Количество столбцов первой матрицы не равно количеству строк второй матрицы.");
      }

      var matrixC = new int[RowsCount(matrixB), ColumnsCount(matrixA)];

      for (var i = 0; i < RowsCount(matrixB); i++)
      {
        for (var j = 0; j < ColumnsCount(matrixA); j++)
        {
          matrixC[i, j] = 0;
          for (var k = 0; k < ColumnsCount(matrixA); k++)
          {
            matrixC[i, j] += matrixA[i, k] * matrixB[k, j];
          }
        }
      }
      return matrixC;
    }

    public static void main()
    {
      int[,] matrix1 = new int[3, 3], matrix2 = new int[3, 3];
      createRandom(matrix1);
      createRandom(matrix2);
      printMatrix(matrix1);
      printMatrix(matrix2);
      printMatrix(MultyMatrix(matrix1, matrix2));
    }
  }
}
