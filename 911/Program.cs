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