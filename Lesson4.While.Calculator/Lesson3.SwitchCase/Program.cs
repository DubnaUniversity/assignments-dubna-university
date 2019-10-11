using System;
using System.Collections.Generic;

/*
Дома:
1. Сделать цикл для банковской программы
2. Очистку консоли (кто не успел)
*/

namespace Lesson3.SwitchCase
{
	internal class Program
	{
		public static void Main(string[] args)
		{
			while (true)
			{
				Console.WriteLine("Set first number");
				int first = int.Parse(Console.ReadLine());

				Console.WriteLine("Set second number");
				int second = int.Parse(Console.ReadLine());

				Console.WriteLine("Choose an action: add/minus/multiple");
				string action = Console.ReadLine();

				int result = 0;


				switch (action)
				{
					case "add":
						result = first + second;
						break;
					case "minus":
						result = first - second;
						break;
					case "multiple":
						result = first + second;
						break;
				}

				Console.WriteLine("result: {0}", result);
				
				Console.WriteLine("Exit? (yes)");
				string answer = Console.ReadLine();
				if (answer == "yes")
				{
					break;
				}
				
				ReWriteConsoleLine();
			}

			Console.WriteLine("Bye");
			Console.ReadLine();
		}
		
		private static void ReWriteConsoleLine()
		{
			Console.SetCursorPosition(0, Console.CursorTop - 1);
		}
	}
}