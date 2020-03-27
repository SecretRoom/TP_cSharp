using System;

namespace secondTask
{
  public class SecondTask
  {

    static int countBlackCell(int[,] arr)
    {
      int result = 0;
      foreach (int item in arr)
      {
        if (item != 0)
        {
          result++;
        }
      }
      return result;
    }
    static void writeBoard(int[,] arr, int sizeBoard)
    {
      for (int i = 0; i < sizeBoard; i++)
      {
        string str = "";
        for (int j = 0; j < sizeBoard; j++)
        {
          str += " " + arr[i, j].ToString();
        }
        Console.WriteLine(str);
      }
    }
    static int getSize()
    {
      Console.WriteLine("Enter size board\n");
      return int.Parse(Console.ReadLine());
    }

    static int[,] fillBoard(int[,] arr, int sizeBoard)
    {
      for (int i = 0; i < sizeBoard; i++)
      {
        for (int j = 0; j < sizeBoard; j++)
        {
          if (i != 0)
          {
            if (j == 0)
            {
              arr[i, j] = arr[i - 1, j] == 1 ? 0 : 1;
            }
            else
            {
              arr[i, j] = arr[i, j - 1] == 1 ? 0 : 1;
            }
          }
          else
          {
            if (j == 0)
            {
              arr[i, j] = 1;
            }
            else
            {
              arr[i, j] = arr[i, j - 1] == 1 ? 0 : 1;
            }
          }
        }
      }
      return arr;
    }

    public static void main()
    {
      int sizeBoard = getSize();
      int[,] cellBord = new int[sizeBoard, sizeBoard];
      cellBord = fillBoard(cellBord, sizeBoard);
      // writeBoard(cellBord,sizeBoard);
      //Ex1
      // ex1(cellBord);
      //Ex2
      // ex2(cellBord);
      //Ex3
      // ex3(cellBord);
      //Ex4
      ex4(cellBord, sizeBoard);
    }

    public static void ex1(int[,] arr)
    {
      Console.WriteLine("\nEx1\nCount black cell = {0}\n", countBlackCell(arr).ToString());
    }

    public static void ex2(int[,] arr)
    {
      Console.WriteLine("\nEx2\nEnter k and m\n");
      Console.WriteLine("What is color this cell? {0}\n",
        arr[int.Parse(Console.ReadLine()) - 1, int.Parse(Console.ReadLine()) - 1] == 0 ? "white" : "black"
      );
    }

    public static void ex3(int[,] arr)
    {
      Console.WriteLine("\nEx3\nEnter k1,m1 and k2,m2\n");
      Console.WriteLine("Cell same color? {0}\n",
        arr[int.Parse(Console.ReadLine()) - 1, int.Parse(Console.ReadLine()) - 1] == arr[int.Parse(Console.ReadLine()) - 1, int.Parse(Console.ReadLine()) - 1]
      );
    }

    public static void ex4(int[,] arr, int sizeBoard)
    {
      Console.WriteLine("\nEnter cordinats figure 1 and 2\n");
      int i = int.Parse(Console.ReadLine()) - 1;
      int j = int.Parse(Console.ReadLine()) - 1;
      int k = int.Parse(Console.ReadLine()) - 1;
      int m = int.Parse(Console.ReadLine()) - 1;
      Console.WriteLine("\nEnter figure: a) пешка; b) слон; c) ладья; d) ферзь; e) конь\n Exit: Other symbol\n");
      switch (Console.ReadLine())
      {
        case "a":
          {
            Console.WriteLine("figure 2 kill figure 1? {0}", i + 1 == k && (j + 1 == m || j - 1 == m) && k > i && m > i);
            break;
          }
        case "b":
          {
            Console.WriteLine("figure 2 kill figure 1? {0}", Math.Abs(k - i) == Math.Abs(m - j));
            break;
          }
        case "c":
          {
            Console.WriteLine("figure 2 kill figure 1? {0}", i == k || j == m);
            break;
          }
        case "d":
          {
            Console.WriteLine("figure 2 kill figure 1? {0}", (i == k || j == m) || (Math.Abs(k - i) == Math.Abs(m - j)));
            break;
          }
        case "e":
          {
            if ((i - 3 > -1 && j - 1 > -1) && (i - 3 == k && j - 1 == m))
            {
              Console.WriteLine("figure 2 kill figure 1? true");
              break;
            }
            if ((i - 3 > -1 && j + 1 < sizeBoard) && (i - 3 == k && j + 1 == m))
            {
              Console.WriteLine("figure 2 kill figure 1? true");
              break;
            }
            if ((i - 1 > -1 && j - 3 > -1) && (i - 1 == k && j - 3 == m))
            {
              Console.WriteLine("figure 2 kill figure 1? true");
              break;
            }
            if ((i + 1 < sizeBoard && j - 3 > -1) && (i + 1 == k && j - 3 == m))
            {
              Console.WriteLine("figure 2 kill figure 1? true");
              break;
            }
            if ((i + 3 < sizeBoard && j - 1 > -1) && (i + 3 == k && j - 1 == m))
            {
              Console.WriteLine("figure 2 kill figure 1? true");
              break;
            }
            if ((i + 3 < sizeBoard && j + 1 < sizeBoard) && (i + 3 == k && j + 1 == m))
            {
              Console.WriteLine("figure 2 kill figure 1? true");
              break;
            }
            if ((i + 1 < sizeBoard && j + 3 < sizeBoard) && (i + 1 == k && j + 3 == m))
            {
              Console.WriteLine("figure 2 kill figure 1? true");
              break;
            }
            if ((i - 1 > -1 && j + 3 < sizeBoard) && (i - 1 == k && j + 3 == m))
            {
              Console.WriteLine("figure 2 kill figure 1? true");
              break;
            }
            Console.WriteLine("figure 2 kill figure 1? false");
            break;
          }
        default:
          {
            Console.WriteLine("\nExit\n");
            break;
          }
      }
    }
  }
}