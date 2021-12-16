string[] Week = { "Lundi", "Mardi", "Mercredi", "Jedi", "Vendredi", "Samedi" };

Console.WriteLine(Week[1]);
Console.WriteLine(Week[4]);


Console.WriteLine(Week[0]);
Console.WriteLine(Week[3]);

Week[3] = "Jeudi";

string newElement = "Dimanche";
List<string> list = new List<string>(Week.ToList());
list.Add(newElement);
Week = list.ToArray();

for (int i = 0; i < Week.Length; i++)
{
    Console.WriteLine(Week[i]);
}