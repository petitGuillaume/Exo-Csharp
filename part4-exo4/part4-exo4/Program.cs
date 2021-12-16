List<int> numbers = new List<int>();

Console.WriteLine("Donnez un nombre a multiplier");
int numberMulti = int.Parse(Console.ReadLine());
numbers.Add(numberMulti);

bool test = false;

while( test != true) 
{

    Console.WriteLine("voulez vous encore rajouté un nombre, oui ou non");
    string demand = Console.ReadLine();

    switch (demand)
    {

        case "oui" :
            Console.WriteLine("Donnez un nombre a multiplier");
            numbers.Add(int.Parse(Console.ReadLine()));
            
        break;


        case "non":

            test = true;
            break;
    }
}
int result = 1;
foreach (int number in numbers)
{
    result = result * number;

}

Console.WriteLine("Les nombres que vous avez donné sont : ");
    foreach (int number in numbers)
{
    Console.WriteLine(number);

}

Console.WriteLine("Le resultat de leur multiplication est " + result);



