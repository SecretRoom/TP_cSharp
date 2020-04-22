using System;

namespace task3Lab3
{
  class Task3Lab3
  {
    static Random _rnd = new Random();

    public static void _createItem(int[] item)
    {
      for (int i = 0; i < item.Length; i++)
      {
        item[i] = _rnd.Next(1, 20);
      }
    }

    public static void _list(int[][] arrList, string type)
    {
      if (type == "print")
      {
        foreach (var item in arrList)
        {
          _printList(item);
        }
      }
      else
      {
        foreach (var item in arrList)
        {
          _createItem(item);
        }
      }
    }

    public static void _printList(int[] item)
    {
      foreach (var elem in item)
      {
        Console.Write(elem.ToString().PadLeft(4));
      }
      Console.WriteLine("\n");
    }


    public static void main()
    {
      int length = 1;
      int[][] arrList = new int[10][] {
        new int[length++],
        new int[length++],
        new int[length++],
        new int[length++],
        new int[length++],
        new int[length++],
        new int[length++],
        new int[length++],
        new int[length++],
        new int[length++],
      };
      _list(arrList, "service");
      _list(arrList, "print");
    }
  }
}
