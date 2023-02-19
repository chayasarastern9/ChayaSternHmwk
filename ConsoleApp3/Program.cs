// See https://aka.ms/new-console-template for more information
Console.WriteLine("N\tN^2\tN^3\tN^2+N^3");
int n = 10;
while (n != 60) 
{
    double n2 = Math.Pow(n, 2);
    double n3 = Math.Pow(n, 3);
    double n4 = n2 + n3;
    Console.WriteLine($"{n}\t{n2}\t{n3}\t{n4}");
    n += 10;

} 
Console.WriteLine("Press any key to continue...");
Console.ReadLine();

