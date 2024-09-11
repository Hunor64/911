// 1. Feladat
using System.Security.Cryptography.X509Certificates;

if (args.Length%2 == 0 || args.Length <= 2)
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
    if (legnagyobbSzotag<szotag)
    {
        legnagyobbSzotag = szotag;
    }
}
Console.WriteLine($"A több, mint négy szótagból álló stavak száma: {negySzotagnalTobbSzavak}");
Console.WriteLine($"A legnagyo szótagszám: {legnagyobbSzotag}");

// 3. Feladat