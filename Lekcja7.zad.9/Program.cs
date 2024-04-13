using System;

class Program
{
	static void Main(string[] args)
	{
		// Pobieranie temperatury od użytkownika
		Console.WriteLine("Podaj temperaturę:");
		int temperatura = Convert.ToInt32(Console.ReadLine());

		// Sprawdzanie temperatury i zwracanie odpowiedniej nazwy
		if (temperatura < 0)
		{
			Console.WriteLine("Cholernie piździ");
		}
		else if (temperatura >= 0 && temperatura <= 10)
		{
			Console.WriteLine("Zimno");
		}
		else if (temperatura > 10 && temperatura <= 20)
		{
			Console.WriteLine("Chłodno");
		}
		else if (temperatura > 20 && temperatura <= 30)
		{
			Console.WriteLine("W sam raz");
		}
		else if (temperatura > 30 && temperatura <= 40)
		{
			Console.WriteLine("Zaczyna być słabo, bo gorąco");
		}
		else
		{
			Console.WriteLine("Temperatura jest bardzo wysoka!");
		}
	}
}