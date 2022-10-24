// See https://aka.ms/new-console-template for more information

using System.Reflection;

string[] nombre = new string[5];
int[] anio = new int[5];
int edad = 0;

string[] puesto = new string[5];
int[] salario = new int[5];

string variable;

Console.WriteLine("LABORATORIO 14");
Console.WriteLine("Ingrese el nùmero de una de las siguientes opciones a realizar");
Console.WriteLine("opciòn 1");
Console.WriteLine("opciòn 2");
Console.WriteLine("opciòn 3");

variable = Console.ReadLine();

switch (variable)
{

    case "1":
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Por favor, ingrese el nombre del empleados:");
            nombre[i] = Console.ReadLine();
            Console.WriteLine("Por favor, ingrese el año de nacimiento");
            anio[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < 5; i++)
        {
            edad = 2022 - anio[i];
            Console.WriteLine("la edad actual de: " + nombre[i] +  " es de: " + edad);
        }

        break;


    case "2":
        Console.WriteLine();
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Por favor, ingrese puesto de 5 empleados:");
            puesto[i] = Console.ReadLine();
            Console.WriteLine("Por favor, ingrese el salario a pagar del puesto");
            salario[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine();
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("para el puesto: " + puesto[i] + " el salario es de:" + salario[i]);
        }

        break;
    case "3":
        Console.WriteLine("salir");
        break;
    default:
        Console.WriteLine("Por favor, ingrese uno de los nùmeros indicados");
        break;

}
