
using System;

string nombre;
string apellido;
int edad;
double altura;

Console.Write("ingrese su nombre: ");
nombre = Console.ReadLine();

Console.Write("ingrese su apellido: ");
apellido = Console.ReadLine();

Console.Write("ingrese su edad: ");
edad = Convert.ToInt32(Console.ReadLine());

Console.Write("ingrese su altura: ");
altura = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("\n--- datos ingresados ---");
Console.WriteLine($"nombre:{nombre}");
Console.WriteLine($"apellido:{apellido}");
Console.WriteLine($"edad:{edad}");
Console.WriteLine($"altura:{altura} metros");

Console.WriteLine($" \nhola, mi nombre es:{nombre} {apellido}, tengo {edad} años y mido {altura} metros.");




 
 
