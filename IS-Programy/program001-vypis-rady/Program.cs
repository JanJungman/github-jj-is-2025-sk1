using System.Collections.Generic;
using System.Runtime.ExceptionServices;

string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("****************************");
    Console.WriteLine("***** Výpis řady čísel *****");
    Console.WriteLine("****************************");
    Console.WriteLine("******* Jungman Jan ********");
    Console.WriteLine("****************************");
    Console.WriteLine();

    // Vstup hodnoty do programu - špatně řešený
    //Console.Write("Zadejte první číslo řady: ");
    //int first = int.Parse(Console.ReadLine());

    //Vstup hodnoty do programu - řešený správně
    Console.Write("Zadejte první číslo řady (celé číslo): ");
    int first;



    while (!int.TryParse(Console.ReadLine(), out first))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte první číslo řady znovu: ");
    }


    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a.");
    again = Console.ReadLine();



}
//výpis vstupních hodnot
Console.WriteLine();
Console.WriteLine("==========================");
Console.WriteLine("zadali jste tyto hodnoty: ");
Console.WriteLine("první číslo řady: {0}", first);
Console.WriteLine("poslední číslo řady: {0}", last);
Console.WriteLine("diference: {0}", stop);

Console.WriteLine("==========================");
Console.WriteLine("první číslo: {0}; Poslední číslo: {1}; Diference: {2}", first, last, stop);
Console.WriteLine();

