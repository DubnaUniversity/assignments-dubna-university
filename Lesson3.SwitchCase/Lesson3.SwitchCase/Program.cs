using System;
using System.Collections.Generic;

/*
Дома:
1. Добавить деление
2. Разобраться и добавить TryParse
3. Используя if сделать вывод сообщений о некорректном вводе числа
*/

namespace Lesson3.SwitchCase
{
	internal class Program
	{
		public static void Main(string[] args)
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

			Console.ReadLine();
		}
	}
}