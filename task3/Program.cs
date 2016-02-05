using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fsRead= new FileStream("input.txt", FileMode.OpenOrCreate, FileAccess.Read);//создаем файловый поток
            StreamReader sr = new StreamReader(fsRead);//создаем потоковый читатель и связываем его с файловым потоком

            FileStream fsWrite = new FileStream("output.txt", FileMode.OpenOrCreate, FileAccess.Write);//создаем файловый поток
            StreamWriter sw = new StreamWriter (fsWrite);//создаем потоковый писатель и связываем его с файловым потоком

            string data = sr.ReadToEnd();//считывам все данные строки
            sr.Close();//закрываем потоковый читатель
            fsRead.Close();//закрываем файловый поток

            string[] array = data.Split(' ');//разбиваем строку массива по указанному символу
            int min = 9999;//добавим переменную чтобы потом сравнить его с мин.цел.числой 
            bool prime;//объявляем логическую переменную
            for (int i = 0; i < array.Length; i++)//пробегаемся по циклу
            {
                int x = int.Parse(array[i]);//конвертация строки в целое число
                prime = true;//обозначим переменную как истина

                for (int j = 2; j < Math.Sqrt(x); j++)//пробегаемся по массиву 
                {
                    if (x % j == 0)
                    {
                        prime = false;//если число делится на числа от 2 до самого числа, то число не является простым
                        break;//выход из цикла
                    }
                }
                if (prime == true && min > x)// если числа простые и меньше начального значения, то  х теперь  мин.цел.число 
                    min = x;
            }

            sw.Write(min + " is the minimum prime number");//в файле output.txt выводим результат
            sw.Close();//закрываем потоковый читатель
            fsRead.Close();//закрываем файловый поток
            fsWrite.Close();//закрываем файловый поток

        }
    }
}
