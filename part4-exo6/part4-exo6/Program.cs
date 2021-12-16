using System;

public class Program
{
	enum Week
	{
		Lundi,
		Mardi,
		Mercredi,
		Jeudi, 
		Vendredi, 
		Samedi,
		Dimanche,
	}
	public static void Main()
	{
		for (int i = 0; i < 7; i++)
        {
			Console.WriteLine((Week)i);
		}
		Console.WriteLine((Week)3);
	}
}