// See https://aka.ms/new-console-template for more information
using System;

public class Program
{
	public static void Main()
	{
		Console.WriteLine("Quel est votre nom ?");
		string lastName = Console.ReadLine();
		Console.WriteLine("Quel est votre prénom ?");
		string firstName = Console.ReadLine();
		DateTime thisDay = DateTime.Today;

		Console.WriteLine("Bonjour " + firstName + " " + lastName + " " + "nous sommes le " + thisDay.ToString("D") + ", comment allez-vous ?");


	}
}
