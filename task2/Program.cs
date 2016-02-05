using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream a = new FileStream("input.txt", FileMode.OpenOrCreate, FileAccess.Read);//создаем файловый поток
            StreamReader b = new StreamReader(a);//создаем потоковый читатель и связываем его с файловым потоком
            string c = b.ReadToEnd();//считываем все символы, начиная с текущей позиции до конца потока
            b.Close();//закрываем файловый поток
            a.Close();//закрываем потоковый читатель

            string[] array = c.Split(' ');//разбиваем строку массива по указанному символу

            int max = -9999;//начальное значение максимума
            int min = 9999;//начальное значение минимума
            for (int i = 0; i < array.Length; i++)//пробегаемся по массиву с начала до конца
            {
                int num = int.Parse(array[i]);//конвертация строки в целое число

                if (num > max)
                {
                    max = num; //если число больше макс, то оно теперь становится макс
                }
                if (num < min)
                {
                    min = num;////если число меньше мин, то оно теперь становится мин
                }

            }

            Console.WriteLine("Maximum:" + max + "   Minimum:" + min);//выводим результат

        }
    }
}
