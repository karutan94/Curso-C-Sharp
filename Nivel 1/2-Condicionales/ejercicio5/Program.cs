﻿/*
 * Hacer un programa para ingresar cuatro números 
 * y luego mostrar por pantalla cuáles son mayores a 100.
 */

int n1, n2, n3, n4, c;

c = 0;

Console.WriteLine("Ingrese numero 1");
n1 = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese numero 2");
n2 = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese numero 3");
n3 = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese numero 4");
n4 = int.Parse(Console.ReadLine());

if (n1 > 100)
{
    Console.Write(n1 + " ");
    c++;
}

if (n2 > 100)
{
    Console.Write(n2 + " ");
    c++;
}

if (n3 > 100)
{
    Console.Write(n3 + " ");
    c++;
}

if (n4 > 100)
{
    Console.Write(n4 + " ");
    c++;
}

if (c != 0)
{
    Console.Write("Son mayores a 100");
}
else
{
    Console.WriteLine("No hay mayores a 100");
}

Console.ReadLine();