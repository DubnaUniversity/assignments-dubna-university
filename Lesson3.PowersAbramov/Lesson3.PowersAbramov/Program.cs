using System;
using System.Collections.Generic;

namespace Lesson3.PowersAbramov
{
	internal class Program
	{
		public static void Main(string[] args)
		{
			int a = 2;

			int a2 = a * a; //1

			int a3 = a2 * a; //2

			int a6 = a3 * a3; //3

			int a12 = a6 * a6; //4

			int a15 = a12 * a3; //5
		}
	}
}


/*
Дано действительное число a. Не пользуясь никакими другими арифметическими операциями, кроме умножения, получить:

a^4 за две операции
a^5 за три операции
a^7 за четыре операции
a^8 за три операции
a^9 за четыре операции
a^13 за пять операций
a^15 за пять операций
a^21 за шесть операций
a^28 за шесть операций
a^64 за шесть операций
*/
