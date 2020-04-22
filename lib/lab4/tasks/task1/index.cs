using System;

namespace task1Lab4
{
  class Task1Lab4
  {
    static Random rnd = new Random();

    public static void createRandom(int[] arr)
    {
      for (int i = 0; i < arr.Length; i++)
      {
        arr[i] = rnd.Next();
      }
    }

    public static void printArray(int[] arr)
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

      createRandom(A);
      createRandom(B);
      createRandom(D);
      for (int i = 0; i < C.Length; i++)
      {
        C[i] = A[i] + B[i];
      }
      printArray(A);
      printArray(B);
      printArray(C);
      printArray(X);
      printArray(U);
      printArray(V);
      printArray(D);
    }
  }

}