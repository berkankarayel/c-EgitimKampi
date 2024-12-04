using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace C__Kontrol_Yapıları
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// Easy  Problem : Check Leap Year 

			// qUESTİON: 

			/*
				write a program that checks whether a given  year 
			is a leap year or not .
			 
			 */

			Console.WriteLine("enter a year : ");
			int year = Convert.ToInt32(Console.ReadLine());
			if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
			{
				Console.WriteLine($"{year} is a leap year ");
			}
			else
			{
				Console.WriteLine($"{year} is not a leap year ");
			}
			Console.ReadLine();




			// Hard Problem (Zor): Triangle Type Detector
			//Write a program to determine the type of a triangle based on the lengths of its sides provided by the user.

			//If all three sides are equal, it is an Equilateral Triangle.
			//If two sides are equal, it is an Isosceles Triangle.
			//If all three sides are different, it is a Scalene Triangle.
			//If the given sides do not form a triangle, output "Not a valid triangle".


			Console.WriteLine("Enter side 1: ");
			int side1 = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Enter side 2: ");
			int side2 = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Enter side 3: ");
			int side3 = Convert.ToInt32(Console.ReadLine());

			// check if the sides form a valid triangle 

			if (side1 + side2 > side3 && side1 + side3 > side2 && side2 + side3 > side1)
			{
				if (side1 == side2 && side2 == side3)
				{
					Console.WriteLine("the triangle is equilateral");
				}
				else if (side1 == side2 || side1 == side3 || side2 == side3)
				{
					Console.WriteLine("the triangle is Isosceles");
				}
				else
				{
					Console.WriteLine("the triangle is scalene");
				}


			}
			else
			{
				Console.WriteLine("Not a valid triangle");
			}
			Console.ReadLine();
		}
	}
}