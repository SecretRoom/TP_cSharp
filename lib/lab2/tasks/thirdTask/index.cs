using System;

namespace thirdTask
{
  public class ThirdTask
  {
    static void dateEx1(DateTime date)
    {
      DateTime dateBasic = new DateTime(date.Year, 1, 1);
      Console.WriteLine("С начала года прошло {0}", date.Subtract(dateBasic).Days);
    }

    static void dateEx2(DateTime date)
    {
      DateTime dateBasic = new DateTime(date.Year, 12, 31);
      Console.WriteLine("До конца года осталось {0}", dateBasic.Subtract(date).Days);
    }

    static void dateEx3(DateTime date)
    {
      Console.WriteLine("Вчера было {0}", date.AddDays(-1));
    }
    static void dateEx4(DateTime date)
    {
      Console.WriteLine("Вчера будет {0}", date.AddDays(1));
    }

    static void date()
    {
      // int day = 11; //int.Parse(Console.ReadLine());
      // int month = 04; // int.Parse(Console.ReadLine());
      // int year = 20; //int.Parse(Console.ReadLine());
      DateTime date = DateTime.Now;
      //ex1
      // dateEx1(date);
      //ex2
      // dateEx2(date);
      //ex3
      dateEx3(date);
      //ex4
      dateEx4(date);
    }

    public static void main()
    {
      date();
    }
  }
}