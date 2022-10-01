class Tarea2
{
    public static void calcularAguinaldo(String empleado, double salario) //metodo que calcula el aguinaldo
    {
        double total = salario * 12; //variable que almacena el calculo del aguinaldo
        Console.WriteLine("Empleado: " + empleado + "\n" + "Salario actual: "+ salario+ "\n"+ "Monto del aguinaldo: "+total+"\n");
        Console.WriteLine("---------------------------------");
        Console.ReadLine();
    }

    public static void Main(string[] args)
    {
        string[] empleado = { "Maria", "Jose", "Alejandra", "Roberto", "Sofia" }; //arreglo que guarda los nombres de los empleado
        double[] salario = {500000.14, 450000, 700000, 645000,777000 }; //arreglo que guarda el salario actual


        int posicion =0; //variable contador que se va usar para que el foreach recorra el arreglo empleado
        if (empleado.Length != salario.Length) //condicion para asegurar que ambos arreglos sean del mismo tamaño
        {
            Console.Write("Los arreglos deben de ser del mismo tamaño \n");
            Console.Write("fin");
            Console.Read();   
        }
        else
        {
            foreach (double item in salario) //ciclo foreach que recorre el arreglo salario
            {
                
                
                calcularAguinaldo(empleado[posicion], item); //llamada al metodo que calcula el aguinaldo segun la posicion en el arreglo
                posicion++;
                


            }
            Console.Write("fin");
            Console.Read();

        }
    }

}
