// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Tarea1 {
    
       
   
    public static double calcularPromedio(double[] notas)
    {
        double promedio = 0;
        double total = 0;
        for (int i = 0; i < 5; i++)
        {
            promedio = promedio + notas[i];
        }

        total = promedio/ 5;
        // Console.WriteLine("El promedio de notas es: " + total);
        //Console.ReadLine(); 
        return total;
    }

    public static void calcularNotaMasAlta(double[] notas, string[] nombre)
    {
        double mayor = notas[0];
        string estudiante = nombre[0];
        for (int i = 0; i < 5; i++)
        {
            if (notas[i] > mayor)
            {
                mayor = notas[i];
                estudiante = nombre[i];
            }
        }
        Console.WriteLine("La nota mayor es: " + mayor + " perteneciente al estudiante: "+estudiante);
        Console.ReadLine();
    }

    public static void calcularEstudiantes(double[] notas, string[] nombre)
    {
        double promedio = calcularPromedio(notas);
        string estudianteMayor = "";
        string estudianteMenor = "";

        for (int i = 0; i < 5; i++)
        {
            if (notas[i] >= promedio)
                estudianteMayor += nombre[i] + ", ";
            else
                estudianteMenor += nombre[i] + ", ";
        }
        Console.WriteLine("L@s estudiantes que tienen una nota mayor al promedio son: " + estudianteMayor); 
        //Console.ReadLine();
        Console.WriteLine("L@s estudiantes que tienen una nota menor al promedio son: " + estudianteMenor);
        Console.ReadLine();
    }

    public static void Main(string[] args) {
        string[] nombre = new string[5];
        double[] notas = new double[5];
        
        for (int i = 0; i < 5; i++) {
            System.Console.WriteLine("Digite el nombre del estudiante");
            nombre[i] = Console.ReadLine();
            System.Console.WriteLine("Digite su nota");
            notas[i] = Double.Parse(Console.ReadLine());

        }

        calcularPromedio(notas);
        Console.WriteLine("El promedio de notas es: " + calcularPromedio(notas));
        Console.ReadLine();
        calcularNotaMasAlta(notas, nombre);
        calcularEstudiantes(notas, nombre);


    }


}