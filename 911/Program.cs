// 1. Feladat
if (args.Length % 2 == 0 || args.Length <= 2)
{
    Console.WriteLine("Nem megfelelő argumentumszám!");
}
else
{
    if (Convert.ToInt32(args[(args.Length / 2) + 1]) > Convert.ToInt32(args[(args.Length / 2) - 1]))
    {
        Console.WriteLine($"Eredmény: {Math.Pow(Convert.ToInt32(args[args.Length / 2]), Convert.ToInt32(args[(args.Length / 2) + 1]) / Convert.ToInt32(args[(args.Length / 2) - 1]))}");
    }
    else
    {
        Console.WriteLine($"Eredmény: {Math.Pow(Convert.ToInt32(args[args.Length / 2]), Convert.ToInt32(args[(args.Length / 2) - 1]) / Convert.ToInt32(args[(args.Length / 2) + 1]))}");
    }
}

// 2. Feladat
List<string> szavak = File.ReadAllLines("szavak.txt").ToList();
char[] maganhangzok = ['A', 'E', 'I', 'O', 'U'];
int negySzotagnalTobbSzavak = 0;
int legnagyobbSzotag = 0;

foreach (var szo in szavak)
{
    int szotag = 0;

    foreach (var betu in szo)
    {
        if (maganhangzok.Contains(betu))
        {
            szotag++;
        }
    }
    if (szotag > 4)
    {
        negySzotagnalTobbSzavak++;
    }
    if (legnagyobbSzotag < szotag)
    {
        legnagyobbSzotag = szotag;
    }
}
Console.WriteLine($"A több, mint négy szótagból álló stavak száma: {negySzotagnalTobbSzavak}");
Console.WriteLine($"A legnagyo szótagszám: {legnagyobbSzotag}");

// 3. Feladat
int[,] matrix = new int[6,6];
for (int i = 0; i < 6; i++)
{
    for (int j = 0; j < 6; j++)
    {
        Random rnd = new();
        matrix[i,j] = rnd.Next(55,155);
    }
}
List<int> atlagolando = new();
for (int i = 0; i < 6; i++)
{
    for (int j = 0; j < 6; j++)
    {
        Console.Write(matrix[i, j] + "\t");
        if (i == 0 || i == 5)
        {
            atlagolando.Add(matrix[i,j]);
        }
        if (j == 0 && i != 0 && i!=5 || j == 5 && i != 0 && i != 5)
        {
            atlagolando.Add(matrix[i, j]);
        }
    }
    Console.WriteLine();
}
Console.WriteLine($"A szélső elemek átlaga: {atlagolando.Sum()/atlagolando.Count}");



//4. Feladat
List<string> kodok = File.ReadAllLines("kep.txt").ToList();
List<string> kekitett = new();
foreach (var kod in kodok)
{
    List<int> szamok = new List<int>();
    var felbontott = kod.Split(';');
    if (felbontott.Length != 0)
    {
        foreach (var item in felbontott)
        {
            szamok.Add(Convert.ToInt32(item));
        }
        if (szamok[2] < 100)
        {
            szamok[2] += 20;
        }
        kekitett.Add(string.Join(";", szamok.ToArray()));
    }
}
File.WriteAllLines("kekitett.txt", kekitett);
Console.WriteLine("#Kész!");
