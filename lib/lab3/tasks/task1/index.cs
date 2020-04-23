using System;

namespace task1Lab3
{
  class Task1Lab3
  {
    static Random _rnd = new Random();

    public static void _createRandom(int[] arr)
    {
      for (int i = 0; i < arr.Length; i++)
      {
        arr[i] = _rnd.Next();
      }
    }

    public static void _printArray(int[] arr)
    {
      foreach (var item in arr)
      {
        Console.Write(" {0}", item);
      }
      Console.WriteLine("\n");
    }
    public static void main()
    {
      int[] A = new int[5];
      int[] B = new int[5];
      int[] C = new int[5];
      int[] D = new int[int.Parse(Console.ReadLine())];
      int[] X = { 5, 5, 6, 6, 7, 7 };
      int[] U, V;
      U = new int[] { 1, 2, 3 };
      V = U;
      V[0] = 9;

      _createRandom(A);
      _createRandom(B);
      _createRandom(D);
      for (int i = 0; i < C.Length; i++)
      {
        C[i] = A[i] + B[i];
      }
      _printArray(A);
      _printArray(B);
      _printArray(C);
      _printArray(X);
      _printArray(U);
      _printArray(V);
      _printArray(D);
    }
  }

}