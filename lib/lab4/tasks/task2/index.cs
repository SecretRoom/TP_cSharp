using System;

namespace task2Lab4
{
  class Task2Lab4
  {
    public static void _printAnyArr(Array arr)
    {
      // int count = arr.GetLength();
      foreach (var item in arr)
      {
        Console.Write(item.ToString().PadLeft(4));
      }
      Console.WriteLine("\n");
    }

    public static void main()
    {
      int[] ar1 = new int[] { 1, 5, 2, 9, 7, 3, 1, 8 };
      int[] ar2 = new int[4];
      Array.Copy(ar1, ar2, 4);
      _printAnyArr(ar1);
      _printAnyArr(ar2);
      Console.WriteLine("first: {0}, last: {1}\n", Array.IndexOf(ar1, 1), Array.LastIndexOf(ar1, 1));
      Array.Reverse(ar1);
      _printAnyArr(ar1);
      Array.Sort(ar1);
      _printAnyArr(ar1);
      ar1 = new int[] { 1, 5, 2, 9, 7, 3, 1, 8 };
      Console.WriteLine("{0}\n", Array.BinarySearch(ar1, 2));
    }
  }
}
