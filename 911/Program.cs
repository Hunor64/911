// 1. Feladat
using System.Security.Cryptography.X509Certificates;

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
