using System;

namespace task3Lab4
{
  class Task3Lab4
  {

    public static void _printAnyArr(Object A, params int[] coef)
    {
      // for (Object item of A)
      // {

      //   Console.WriteLine(item);
      // }

      Array arr = A as Array;
      if (arr == null)
      {
        Console.Write(A + " ");
        // return;
      }
      Console.WriteLine(arr);
    }

    public static void main()
    {
      int[] ar1 = new int[] { 1, 5, 2, 9, 7, 3, 1, 8 };
      int[] ar2 = new int[4];
      int[] ar3 = { 1, 2, 3, 4, 5 };
      _printAnyArr(ar1);
    }
  }
}
