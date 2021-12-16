List<int> calcul = new List<int>();
calcul.Add(5);
calcul.Add(54);
calcul.Add(8);
calcul.Add(29);

int result = 0;
int i = 0;
foreach (int calculs in calcul)
{
    result = result + calcul[i];
    i++;

}


i = 0;
Console.WriteLine("les nombre sont : ");
foreach (int calculs in calcul)
{
    Console.WriteLine(calcul[i]);
    i++;

}
Console.WriteLine("le résultat du calcul est: " + result);