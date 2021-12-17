string[] Week = { "Lundi", "Mardi", "Mercredi", "Jedi", "Vendredi", "Samedi" };

Console.WriteLine(Week[1]);
Console.WriteLine(Week[4]);


Console.WriteLine(Week[0]);
Console.WriteLine(Week[3]);

Week[3] = "Jeudi";

// agrandir tableau puis rajouter une valeur dans la nouvelle case
Array.Resize(ref Week, 7);
Week[6] = "Dimanche";

foreach (string day in Week)
{
    Console.WriteLine(day);
}

/* for (int i = 0; i < Week.Length; i++)
{
    Console.WriteLine(Week[i]);
} */