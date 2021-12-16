using System;

public class Program
{
	public static void Main()
	{
		Console.WriteLine("Veillez saisir votre nom ?");
		string LastName = Console.ReadLine();
		
		Console.WriteLine("Veillez saisir votre prénom ?");
		string firstName = Console.ReadLine();
		
		Console.WriteLine("Veillez saisir votre année de naissance ?");
		int year = int.Parse(Console.ReadLine());
		DateTime date1 = DateTime.Now;

		int yearNow = date1.Year;
		int age = yearNow - year;

		Console.WriteLine("Fiche de Renseignement: \n Nom : " + LastName + " \n Prénom : " + firstName + "\n Age : " + age);
	}
}
