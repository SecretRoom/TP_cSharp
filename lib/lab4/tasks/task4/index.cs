using System;

namespace task4Lab4
{

  class Student
  {
    string name;
    int sumb;

    static Random rnd = new Random();

    public Student()
    {
      name = "Null";
      sumb = -1;
    }

    public void SetValue(string _name)
    {
      name = _name;
      sumb = rnd.Next(0, 50);
    }

    public void Show()
    {
      Console.WriteLine("{0}:\t{1}", name, sumb);
    }

    //функция для инициализации массива заданного размера
    //как ее вызывать, смотрим в коде "Main"
    public static Student[] InitAr(Student[] _Stud)
    {
      for (int i = 0; i < _Stud.Length; i++)
        _Stud[i] = new Student();
      return _Stud;
    }
  }
  class Task4Lab4
  {

    public static void main()
    {
      Student[] arr = new Student[3];
      //вызываем это функцию таким образом, и она сама инициализирует массив объектов
      //конструктором по умолчанию, а дальше уже можем работать с элементами
      Student.InitAr(arr);

      arr[0].SetValue("Александр");
      arr[1].SetValue("Владимир");
      arr[2].SetValue("Егор");

      arr[0].Show();
      arr[1].Show();
      arr[2].Show();

      Console.ReadKey();
    }
  }
}
