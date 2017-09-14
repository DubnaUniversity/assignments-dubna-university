using System;
using System.Collections.Generic;

namespace Lesson2.BankApplication
{
	internal class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello!\r\n What's your name?");

			string name = Console.ReadLine();
			
			Console.WriteLine("Name: {0}", name);

			Console.ReadLine();
		}
	}
}