using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace src
{
	class Book
	{
		public string Name { get; }
		public string Author { get; }
		public string Genre { get; }
		public Book(string name, string author, string genre) 
		{
			this.Name = name;
			this.Author = author;
			this.Genre = genre;
		}
		public static bool operator <(Book b1, Book b2) 
		{
			if (string.Compare(b1.Genre, b2.Genre) < 0)
			{
				return true;
			}
			else 
			{
				if (string.Compare(b1.Author, b2.Author) < 0)
				{
					return true;
				}
				else
				{
					if (string.Compare(b1.Name, b2.Name) < 0)
					{
						return true;
					}
					else
					{
						return false;
					}
				}
			}
		}
		public static bool operator >(Book b1, Book b2)
		{
			if (string.Compare(b1.Genre, b2.Genre) > 0)
			{
				return true;
			}
			else
			{
				if (string.Compare(b1.Author, b2.Author) > 0)
				{
					return true;
				}
				else
				{
					if (string.Compare(b1.Name, b2.Name) > 0)
					{
						return true;
					}
					else
					{
						return false;
					}
				}
			}
		}
	}
}

