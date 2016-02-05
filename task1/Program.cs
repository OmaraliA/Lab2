using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack(@"C:\Ару");
        }
        static void Stack(string path)//создается стек
        {
            Stack<string> dirs = new Stack<string>(50);//количество файлов в начальной папке
            Console.WriteLine(path + ":" + Directory.GetFiles(path).Length);
            dirs.Push(path);// добавляем путь начальной папки

            while (dirs.Count > 0)// выполняется цикл, пока стек не станет пустым
            {
                string currentDir = dirs.Pop();// берется путь последней добавленной папки 
                string[] subDirs = Directory.GetDirectories(currentDir);// в массив добавляются пути папок в текущей папке
                foreach (string str in subDirs)
                {
                    Console.WriteLine(str + ": " + Directory.GetFiles(str).Length);//выводит количество файлов в каждой папке

                    dirs.Push(str);//пути папок добавляются в стек

                }
            }
            

        }
    }
}