public class Program
{
	public static void Main()
	{
		Console.WriteLine(" Bonjour, êtes vous un homme ou une femme ?");
		string gender = Console.ReadLine();
		Console.WriteLine(" Bonjour, quel est votre age ?");
		int age = int.Parse(Console.ReadLine());

		if (gender == "homme")
		{
			if (age >= 18)
			{
				Console.WriteLine("Vous êtes un homme et vous êtes majeur.");
			}
			else
			{
				Console.WriteLine("Vous êtes un homme et vous êtes mineur.");
			}
		}
		else if (gender == "femme")
		{
			if (age >= 18)
			{
				Console.WriteLine("Vous êtes une femme et vous êtes majeur.");
			}
			else
			{
				Console.WriteLine("Vous êtes une femme et vous êtes mineur.");
			}
		}
		else
		{
			Console.WriteLine("Saisie non valide, veillez recommencer");
		}
	}
}