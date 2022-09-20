using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace ExamenZlobinov
{

    public class Program
    {
        /// <summary>
        /// Класс для работы с файлами
        /// </summary>
        public class test
        {
            public string s;

            //Ввод данных в текстовый файл, чтобы вывести их на экран
          public void vvod()
          {
                //При необходимости стоит создать его в папке Debug
            StreamReader vvod = new StreamReader("vvod.txt");
            while (!vvod.EndOfStream)
            {
                s = vvod.ReadLine();
                Console.WriteLine(s);
            }
            vvod.Close();
          }

           //Вывод введенных данных в csv, введенные в vvod.txt
          public void vivod()
          {
            string[] lines = new string[] { s };
            File.WriteAllLines("test.csv", lines);
          }
    }
        
        /// <summary>
        /// Метод для Unit теста
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>

    //Метод суммы для unit теста
    public int sum(int a, int b)
    {
        return a + b;
    }



    static void Main(string[] args)
        {
            //Объявление методов для работы с файлами
            test test = new test();
            test.vvod();
            test.vivod();
            Console.WriteLine("\nДля вывода данных на экран из файла нужно ввести текст в файл vvod.txt (или создать его)\n");
            //Сумма чисел выводится в Otvet.txt
            Console.Write("Введите a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            int c = a + b;

            //Создание текстовых файлов
            TextWriterTraceListener[] listeners = new TextWriterTraceListener[]
            {
                new TextWriterTraceListener("Debug.txt"),
                new TextWriterTraceListener("Otvet.txt"),
                 new TextWriterTraceListener(Console.Out)
            };
            Debug.Listeners.AddRange(listeners);
            //Вывод информации в debug
            Debug.WriteLine($"Ваш ответ: {c}");
            Debug.WriteLine("Созданы файлы Debug.txt и Otvet.txt. Вся информация записана.");
            Debug.Flush();
            Console.ReadKey();
        }
    }
}
