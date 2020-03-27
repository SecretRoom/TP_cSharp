using System;

namespace fourthTask
{
  class FourthTask
  {
    static bool filter(int num)
    {
      int el = num;
      double arg = 0;
      while (el > 0)
      {
        arg += Math.Pow(Convert.ToDouble(el % 10), num.ToString().Length);
        el /= 10;
      }
      return arg == num;
    }

    static int[] addElem(int[] list, int num)
    {
      Array.Resize(ref list, list.Length + 1);
      list[list.Length - 1] = num;
      return list;
    }


    public static void main()
    {
      int[] armList = new int[0];
      for (int i = 99; i < 1000; i++)
      {
        if (filter(i))
        {
          armList = addElem(armList, i);
        }
      }
      foreach (var item in armList)
      {
        Console.WriteLine("item {0}",item);
      }
    }

  }
}