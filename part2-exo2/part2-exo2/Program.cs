using System;

public class Program
{
	public static void Main()
	{
		Console.WriteLine(" Bonjour, quel est votre âge ?");
		int age = int.Parse(Console.ReadLine());

		if (age >= 18)
		{
			Console.WriteLine("Vous avez " + age + " ans, vous êtes donc majeur.e.");
		}
		else
		{
			Console.WriteLine("Vous avez " + age + " ans, vous êtes donc mineur.e.");
		}

	}
}