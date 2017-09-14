using System;
using System.Collections.Generic;

namespace Lesson2.BankApplication
{
	internal class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello!\r\nWhat's your name?");

			string name = Console.ReadLine();
			ReWriteConsoleLine("Name", name);

			Console.WriteLine("\r\nSet your age");
			int age = GetNumericLine();
			ReWriteConsoleLine("Age", age);

			
			Console.WriteLine("\r\nSet your income");
			int income = GetNumericLine();
			ReWriteConsoleLine("Income", income);

			
			Console.WriteLine("\r\nSet loan amount");
			int loanAmount = GetNumericLine();
			ReWriteConsoleLine("Loan amount", loanAmount);
			
			
			Console.WriteLine("\r\nSet the loan term (Months)");
			int loanTerm = GetNumericLine();
			ReWriteConsoleLine("Loan term (Months)", loanTerm);
			
			Console.Clear();
			if (income / 2 > loanAmount / loanTerm)
			{
				Console.WriteLine("Loan is approved");
			}
			else
			{
				Console.WriteLine("Application is rejected");
			}

			Console.ReadLine();
		}

		private static void ReWriteConsoleLine(string text, object loanTerm)
		{
			Console.SetCursorPosition(0, Console.CursorTop - 1);
			Console.WriteLine("{0}: {1}", text, loanTerm.ToString());
		}

		private static int GetNumericLine()
		{
			return Convert.ToInt32(Console.ReadLine());
		}
	}
}