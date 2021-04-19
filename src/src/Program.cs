using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace src
{
	class Program
	{
		static void Main(string[] args)
        {
            uint n;
            Console.Write("Введите длину массива: ");
            while(!uint.TryParse(Console.ReadLine(), out n))
            {
                Console.WriteLine("Вы ввели число в неверном формате!");
                Console.Write("Введите длину массива: ");
            }
            Console.WriteLine();
            Book[] Libray = new Book[n];
            for (int i = 0; i < n; i++)
            {
                string name = Input("название");
                string author = Input("автора");
                string genre = Input("жанр");
                Libray[i] = new Book(name, author, genre);
                Console.WriteLine();
            }
            WorkWithLibray Worker = new WorkWithLibray(Libray);
            Worker.Sort();
            Console.Write("Введите имя сохраняемого файла: ");
            string fileName = Console.ReadLine();
            Worker.Save(fileName);
            Console.ReadLine();
		}
        private static string Input(string param) 
        {
            Console.Write("Введите " + param + " книги: ");
            string s = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(s)) 
            {
                Console.WriteLine("Похоже вы не указали " + param + " книги!");
                Console.Write("Введите " + param + " книги: ");
                s = Console.ReadLine();
            }
            return s;
        }
	}
}
