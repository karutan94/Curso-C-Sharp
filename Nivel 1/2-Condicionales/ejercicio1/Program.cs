﻿/*
 * Hacer un programa para ingresar un número y luego se emita por pantalla un cartel aclaratorio 
 * si “Es mayor a 10” o “No es mayor a 10”
 */

int n;

Console.WriteLine("Ingrese un numero");

n = int.Parse(Console.ReadLine());

if (n > 10)
{
    Console.WriteLine("El numero es mayor a 10");
}
else
{ Console.WriteLine("El numero no es mayor a 10"); }

Console.ReadLine();