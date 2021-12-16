using System;

public class Program
{
	public static void Main()
	{
		Console.WriteLine("Veillez entrez un chiffre");
		int firstNumber = int.Parse(Console.ReadLine());

		Console.WriteLine("Veillez entrez un autre chiffre");
		int twoNumber = int.Parse(Console.ReadLine());

		firstNumber = firstNumber + 33;
		twoNumber = twoNumber++;

		float divNumber = (float)firstNumber / (float)twoNumber;
		Console.WriteLine("le résultat de la division est : " + divNumber);

	}
}
