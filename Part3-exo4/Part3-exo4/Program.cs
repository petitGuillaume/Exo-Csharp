Random rnd = new Random();
int numberRandom = rnd.Next(0, 50);
int i = 1;

Console.WriteLine("Esayez de déviner le nombre compris entre 0 et 50");

for (bool condition = false; condition != true;)
{

    int numberTest = 0;

    while (!int.TryParse(Console.ReadLine(), out numberTest))
    {
        Console.WriteLine("Les lettres ne sont pas autorisé, écrivez juste des nombre");
    }

        if (numberTest < numberRandom)
        {
            Console.WriteLine("Plus grand!");
            i++;
        }
        else if (numberTest > numberRandom)
        {
            Console.WriteLine("plus petit");
            i++;
        }
        else
        {
            Console.WriteLine("bravo vous avez trouvez, il vous a fallu " + i + " essais");
            condition = true;
        }
}
