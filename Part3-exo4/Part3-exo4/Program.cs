Random rnd = new Random();
int numberRandom = rnd.Next(1, 51);
int numberTry = 1;

Console.WriteLine("Essayez de deviner le nombre compris entre 1 et 50");
bool isFound = false;

while (!isFound)
{

    int numberTest = 0;
    // tant que l'utilisateur ne rentre pas un nombre, redemande un nombre
    while (!int.TryParse(Console.ReadLine(), out numberTest))
    {
        Console.WriteLine("Les lettres ne sont pas autorisé, écrivez juste des nombre");
    }

    if (numberTest < numberRandom)
    {
        Console.WriteLine("Plus grand!");
    }
    else if (numberTest > numberRandom)
    {
        Console.WriteLine("plus petit");
    }
    else
    {
        Console.WriteLine("bravo vous avez trouvé, il vous a fallu " + numberTry + " essais");
        isFound = true;
    }
    numberTry++;
}
