using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace src
{
	class WorkWithLibray
	{
		public Book[] Libray { get; }
		public WorkWithLibray(Book[] libray)
		{
			Libray = libray;
		}
		public void Sort() 
		{
			for (int i = 0; i < Libray.Length - 1; i++)
			{
				for (int j = i; j >= 0; j--)
				{
					if (Libray[j] < Libray[j + 1])
					{
						Book buf = Libray[j + 1];
						Libray[j + 1] = Libray[j];
						Libray[j] = buf;
					}
				}
			}
		} 
		public void Save(string fileName) 
		{
            if (fileName.Length < 4)
            {
                fileName += ".txt";
            }
            else
            {
                if (fileName.Substring(fileName.Length - 4) != ".txt")
                {
                    fileName += ".txt";
                }
            }
            string[] strmas = new string[Libray.Length];
            for (int i = 0; i < Libray.Length; i++)
            {
                strmas[i] = Libray[i].Name + " " + Libray[i].Author + " " + Libray[i].Genre;
            }
			try
			{
				File.WriteAllLines(fileName, strmas);
			}
			catch (Exception ex) 
			{
                Console.WriteLine("Во время сохранения файла произошла ошибка");
			}
        }
	}
}
