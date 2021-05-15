using System;

namespace ConsoleApp6
{
	class Program
	{
		static void Main(string[] args)
		{
			int i, j;
			Console.WriteLine("Введите число");
			try
			{
				int a = int.Parse(Console.ReadLine());
				int[] arr = new int[10];
				Random R = new Random();
				Console.Write("Неотсортированный массив: ");

				for (i = 0; i < arr.Length; i++)
				{
					arr[i] = R.Next(0, a+1);					
					Console.Write(arr[i] + " ");
				}
				for (i = 0; i < arr.Length; i++)
					for (j = 1; j < arr.Length - i; j++)
					{
						if (arr[j] < arr[j - 1])
						{
							int s = arr[j];
							arr[j] = arr[j - 1];
							arr[j - 1] = s;
						}
					}
				Console.WriteLine();
				Console.Write("Отсортированный массив: ");
				for (i = 0; i < arr.Length; i++)
				{
					Console.Write(arr[i] + "  ");
				}
			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
			}
				Console.ReadKey();
			

			
			
			
		}
	}
}
