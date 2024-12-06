using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__Overloading
{
	internal class Program
	{

		class Library
		{
			// Kitapları metotlarla arıyoruz

			// 1. Kitap adıyla arama
			public void SearchBook(string bookName)
			{
				Console.WriteLine($"Kitap adıyla arama yapılıyor: {bookName}");
			}

			// 2. Yazar adıyla arama
			public void SearchBook(string authorName, bool isAuthor)
			{
				if (isAuthor)
				{
					Console.WriteLine($"Yazar adıyla arama yapılıyor: {authorName}");
				}
			}

			public void SearchBook(int publicationYear)
			{
				Console.WriteLine($"Yayın yılına göre arama yapılıyor: {publicationYear}");
			}

			static void Main(string[] args)
			{

				// Farklı parametre sayıları ile aynı metot adı çağrılır
				Topla(5, 10); // İki parametreli
				Topla(5, 10, 15); // Üç parametreli
				Console.WriteLine("2 Sayıyı Toplayalım: " + Hesapla(5, 10));
				Console.WriteLine("3 Sayıyı Toplayalım: " + Hesapla(5, 10, 15));
				Console.WriteLine("Double Sayıları Toplayalım: " + Hesapla(5.5, 10.5));
				Library library = new Library();

				// Kitap adıyla arama
				library.SearchBook("Savaş ve Barış");

				// Yazar adıyla arama
				library.SearchBook("Tolstoy", true);

				// Yayın yılıyla arama
				library.SearchBook(1869);
				Console.ReadLine();



			}

			// İki parametreli toplama metodu
			static void Topla(int a, int b)
			{
				Console.WriteLine($"İki sayının toplamı: {a + b}");
			}

			// Üç parametreli toplama metodu
			static void Topla(int a, int b, int c)
			{
				Console.WriteLine($"Üç sayının toplamı: {a + b + c}");
			}

			static int Hesapla(int a, int b)
			{
				return a + b;
			}

			static int Hesapla(int a, int b, int c)
			{
				return a + b + c;
			}

			static double Hesapla(double a, double b)
			{
				return a + b;
			}


			
		}
	}
}
