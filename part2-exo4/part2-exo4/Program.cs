using System;

public class Program
{
	public static void Main()
	{
		const string login = "guillaume";
		const string password = "Monkey";

		Console.WriteLine("Identifiant :");
		String loginUser = Console.ReadLine();

		Console.WriteLine("Mot de Passe :");
		String passWordUser = Console.ReadLine();

		switch (loginUser, passWordUser)
		{
			case (login, password):
			Console.WriteLine("Bienvenue à la Manu.");
			break;
			
			default:
			Console.WriteLine("Mauvais identifiant ou mauvais mot de passe.");
			break;
		}	
	}
}