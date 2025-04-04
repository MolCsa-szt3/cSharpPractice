// See https://aka.ms/new-console-template for more information

using DolgozoKezelo.Console.Models;
using DolgozoKezelo.Console.Repos;

Console.WriteLine("1. feladat");

try
{
    DolgozoAdatok empty = new DolgozoAdatok("", "Null");
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}

Console.WriteLine("2. feladat");
DolgozoAdatok janos = new DolgozoAdatok("janos@ceg.hu", "Dolgozó János");
Console.WriteLine(janos);

Console.WriteLine("3. feladat");
try
{
    janos.IncreaseSalary(-300000);
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}

Console.WriteLine("4. feladat");
janos.IncreaseSalary(200000);
janos.IncreaseSalary(300000);
Console.WriteLine(janos);

DolgozoRepo repo = new DolgozoRepo();
Console.WriteLine($"Dolgozók száma: {repo.GetCount()}");
