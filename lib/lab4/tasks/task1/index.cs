using System;

namespace task1Lab4
{
  class Task1Lab4
  {
    public static void _printAnyArr(Array arr)
    {
      for (int i = 0; i < arr.GetUpperBound(0) + 1; i++)
      {
        if (arr.Rank == 2)
        {
          for (int j = 0; j < arr.GetUpperBound(1) + 1; j++)
          {
            Console.Write(arr.GetValue(i, j).ToString().PadLeft(4));
          }
          Console.WriteLine("");
        }
        else
        {
          Console.Write(arr.GetValue(i).ToString().PadLeft(4));
        }
      }
      Console.WriteLine("\n");
    }

    public static void main()
    {
      int[] ar1 = new int[] { 1, 2, 3, 5 };
      double[] ar2 = { 5.5, 6.6, 7.7 };
      int[,] ar3 = new int[3, 4];
      _printAnyArr(ar1);
      _printAnyArr(ar2);
      _printAnyArr(ar3);
    }
  }

}