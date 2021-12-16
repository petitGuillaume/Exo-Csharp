﻿string[,] fujita = new string[6, 2]
{
    { "F0", "Dégâts légers : certains dommages sont subis par les cheminées, les antennes de télévision, les bardeaux, les arbres, les enseignes et les fenêtres." },
    { "F1", "Dégâts modérés : les automobiles sont renversées, les abris pour automobiles détruits et les arbres déracinés."},
    { "F2", "Dégâts importants : les toits sont arrachés par le vent, les hangars et les dépendances sont démolies et les maisons mobiles sont renversées." },
    { "F3", "Dégâts considérables : les murs extérieurs et les toits sont projetés dans les airs, les maisons et les bâtiments de métal s'effondrent ou subissent des dégâts| importants, les forêts et les récoltes sont abattues." },
    { "F4", "Dégâts dévastateurs : même dans les habitations solides, l'essentiel des murs, sinon tous, s'effondrent ; tels des missiles, de gros objets en acier ou en béton sont projetés à grandes distances." },
    { "F5", "Dégâts incroyables : les maisons sont rasées ou projetées sur de grandes distances. Les tornades F5 peuvent causer des dommages très importants à de grosses structures telles que les écoles et les motels et peuvent arracher les murs extérieurs et les toits (parfois surnommé « le doigt de Dieu »." },
};

Console.WriteLine("Veuiller renseigné le type de tornade parmis les types suivant : F0, F1, F2, F3, F4 ou F5");
string demand = Console.ReadLine();

switch (demand)
{
    case "F0":
        Console.WriteLine(fujita[0, 1]);
        break;

    case "F1":
        Console.WriteLine(fujita[1, 1]);
        break;

    case "F2":
        Console.WriteLine(fujita[2, 1]);
        break;

    case "F3":
        Console.WriteLine(fujita[3, 1]);
        break;

    case "F4":
        Console.WriteLine(fujita[4, 1]);
        break;

    case "F5":
        Console.WriteLine(fujita[5, 1]);
        break;
}