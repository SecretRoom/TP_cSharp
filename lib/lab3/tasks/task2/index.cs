using System;

namespace task2Lab3
{
  class Task2Lab3
  {
    static Random _rnd = new Random();

    public static void _createRandom(int[,] matrix)
    {
      for (int i = 0; i < matrix.GetUpperBound(0) + 1; i++)
      {
        for (int j = 0; j < matrix.GetUpperBound(1) + 1; j++)
        {
          matrix[i, j] = _rnd.Next(1, 20);
        }
      }
    }

    public static void _printMatrix(int[,] matrix)
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

    public static int _RowsCount(int[,] matrix)
    {
      return matrix.GetUpperBound(0) + 1;
    }

    public static int _ColumnsCount(int[,] matrix)
    {
      return matrix.GetUpperBound(1) + 1;
    }


    public static int[,] _MultyMatrix(int[,] matrixA, int[,] matrixB)
    {
      if (_ColumnsCount(matrixA) != _RowsCount(matrixB))
      {
        throw new Exception("Умножение не возможно! Количество столбцов первой матрицы не равно количеству строк второй матрицы.");
      }

      var matrixC = new int[_RowsCount(matrixB), _ColumnsCount(matrixA)];

      for (var i = 0; i < _RowsCount(matrixB); i++)
      {
        for (var j = 0; j < _ColumnsCount(matrixA); j++)
        {
          matrixC[i, j] = 0;
          for (var k = 0; k < _ColumnsCount(matrixA); k++)
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
      _createRandom(matrix1);
      _createRandom(matrix2);
      _printMatrix(matrix1);
      _printMatrix(matrix2);
      _printMatrix(_MultyMatrix(matrix1, matrix2));
    }
  }
}
