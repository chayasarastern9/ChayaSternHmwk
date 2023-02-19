// See https://aka.ms/new-console-template for more information
int num = 10;
Console.WriteLine("N\tN^2\tN^3\tN^2+N^3");
while (num != 60) 
{
    double n2 = Math.Pow(num, 2);
    double n3 = Math.Pow(num, 3);
    double n4 = n2 + n3;
    Console.WriteLine($"{num}\t{n2}\t{n3}\t{n4}");
    num += 10;

} 
Console.WriteLine("Press any key to continue...");
Console.ReadLine();

