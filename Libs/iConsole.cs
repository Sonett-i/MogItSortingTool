using System;

namespace Libs.ConsoleUtils
{
	public abstract class iConsole
	{

		public static void Print(string message)
		{
			Console.WriteLine(message);
		}


		public static void Print(params object[] args)
		{
			string output = "";

			for (int i = 0; i < args.Length; i++)
			{
				output += args[i].ToString();
			}

			Print(output);
		}

		public static string PrintArray(int[] array)
		{
			string output = "";
			for (int i = 0; i < array.Length; i++)
			{
				output += array[i].ToString() + ", ";
				if (i % 8 == 0)
				{
					output += "\n";
				}
			}
			return output;
		}

		public static void Clear()
		{
			Console.Clear();
		}
		public static string Prompt(string message)
		{
			iConsole.Print(message);
			string? input = "";

			input = Console.ReadLine();

			if (input == null)
				input = "";
			return input;
		}
	}
}