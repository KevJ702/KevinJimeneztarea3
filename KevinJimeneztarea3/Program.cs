﻿internal class Program
{
    private static void Main(string[] args)
    {
        double n1, n2, res;

        int opt = 0;

        do
        {
            Console.Clear();
            Console.WriteLine("Calculadora online\n");
            Console.WriteLine("Seleccione una opción\n");
            Console.WriteLine("1.Sumar");
            Console.WriteLine("2.Restar");
            Console.WriteLine("3.Multiplicar");
            Console.WriteLine("4.Dividir");
            Console.WriteLine("5.Salir\n");
            opt = int.Parse(Console.ReadLine());

            switch(opt)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("Opción sumar");
                    Console.WriteLine("Inserte el primer número");
                    n1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Inserte el segundo número");
                    n2 = Convert.ToDouble(Console.ReadLine());
                    res = n1 + n2;
                    Console.WriteLine($"El resultado de la suma es: {res}/n");
                    Console.ReadLine();

                    break;
            }
            Console.ReadLine();
        } while ((opt>0) && (opt<=4));
    }
}