

Console.WriteLine("Bonjour, rentrez un nombre s'il vous plait");
int result = int.Parse(Console.ReadLine());

for (bool condition = false; condition != true; )
{
    Console.WriteLine("Voulez vous ajouté un nombre, oui ou non?");
    string Continued = Console.ReadLine();

    switch (Continued)
    {
        case "oui" :
        Console.WriteLine("Rentrez un nombres s'il vous plait");
        result = result + int.Parse(Console.ReadLine());
        break;

        case "non" :
        condition = true;
        break;
           
        default: break;
    }
}

Console.WriteLine("Le resultat est égale à " + result);


// priviligier un do while le for est une mauvaise idée ici
// try catch permet de géré les exeption.