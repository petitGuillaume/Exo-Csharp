List<string> langage = new List<string>();
langage.Add("HTML");
langage.Add("CSS");
langage.Add("Javacrit");
langage.Add("jQuery");
langage.Add("PHP");
langage.Add("Bootstap");
langage.Add("Java");

langage.ForEach(Console.WriteLine);


string element3 = langage[3];
Console.WriteLine(element3);


string element4 = langage[4];
Console.WriteLine(element4);





langage.Remove("Bootstap");

langage.Remove("Javacrit");
langage.Insert(2, "Javascript");
langage.Add("C");

langage.ForEach(Console.WriteLine);
