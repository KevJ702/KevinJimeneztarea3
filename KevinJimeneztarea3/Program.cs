internal class Program
{
    private static void Main(string[] args)
    {
        double v1, v2, res;

        int opt = 0;

        do
        {
            Console.WriteLine("Calculadora online");
            Console.WriteLine("Seleccione una opción");
            Console.WriteLine("1.Sumar");
            Console.WriteLine("2.Restar");
            Console.WriteLine("3.Multiplicar");
            Console.WriteLine("4.Dividir");
            Console.WriteLine("5.Salir");
            opt = int.Parse(Console.ReadLine());

            switch(opt)
            {
                case 1:

                   
                    break;
            }
        } while ((opt>0) && (opt<=4));
    }
}