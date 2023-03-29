using System;
using System.Collections;

namespace Practica13_C
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            list.Add(4.5);
            list.Add(18);
            list.AddRange(new string[] { "Студент","Юльтимирова"});
            foreach(object e in list)
            {
                Console.WriteLine(e);
            }
            list.Remove(0);
            list.Reverse();
            Console.WriteLine(list[1]);
            for(int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
            ArrayList list1 = new ArrayList();
            ArrayList list12 = new ArrayList();
            list.AddRange(new string[] { "Число", "Студенты", "Лекции" });
            try
            {
                Console.WriteLine("Введите  какого индекса начинать вставлять данные");
                int dann = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите  количество");
                int count = Convert.ToInt32(Console.ReadLine());
                if (dann < 0 || dann > list.Count || count <= 1 || count>list12.Count)
                {
                    Console.WriteLine("Неверно");
                }
                else
                {
                    list1 = list12.GetRange(0,count );
                    list.InsertRange(dann, list1);
                }
                for(int i = 0; i < list.Count; i++)
                {
                    Console.WriteLine(list[i]);
                }
            }
            catch
            {
                Console.WriteLine("Неверный ввод");
            }

              
        }
    }
}
