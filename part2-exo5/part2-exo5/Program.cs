
Console.WriteLine("Ecrivez un mois");
String month = Console.ReadLine();


switch (month)
{
	case "Janvier": 
	case "Février": 
	case "Mars" :
	Console.WriteLine("La saison du mois saisi est l'HIVER.");
	break;

	case "Avril":	
	case "Mai": 
	case "Juin":
		Console.WriteLine("La saison du mois saisi est le PRINTEMPS.");
	break;

	case "Juillet": 
	case "Aout": 
	case "Septembre":
		Console.WriteLine("La saison du mois saisi est l'ÉTÉ.");
		break;

	case "Octobre": 
	case "Novembre": 
	case "Décembre":
		Console.WriteLine("La saison du mois saisi est l'HIVER.");
	break;

	default:
	Console.WriteLine("Ce mois est inconnu.");
	break;

}

			