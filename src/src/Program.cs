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
            int n;
            Console.Write("Введите длину массива: ");
            while(!int.TryParse(Console.ReadLine(), out n))
            {
                Console.WriteLine("Вы ввели число в неверном формате!");
                Console.Write("Введите длину массива: ");
            }
            Console.WriteLine();
            Book[] Libray = new Book[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Введите название книги: ");
                string name = Console.ReadLine();
                Console.Write("Введите автора книги: ");
                string author = Console.ReadLine();
                Console.Write("Введите жанр книги: ");
                string genre = Console.ReadLine();
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
	}
}
