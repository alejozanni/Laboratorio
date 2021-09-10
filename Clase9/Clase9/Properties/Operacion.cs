using System;

namespace Clase9.Properties
{
    public static class Operacion
    {
        private static string option;
        private static double a;
        public static double b;
        

        public static void Menu()
        {
            Console.WriteLine("Seleccione la operacion que desea realizar: ");
            Console.WriteLine("S. Suma");
            Console.WriteLine("R. Resta");
            option = Console.ReadLine();
        
            switch (option)
            {
                case "S":
                    Console.WriteLine("Elegiste la opcion Suma.");
                    Console.WriteLine("Ingrese el primer numero: ");
                    a=Double.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el segundo numero: ");
                    b=Double.Parse(Console.ReadLine());
                    Console.WriteLine("Suma igual a : " + suma(a,b));
                    break;
                
               case "R":
                   Console.WriteLine("Elegiste la opcion Resta.");
                   Console.WriteLine("Ingrese el primer numero: ");
                   a=Double.Parse(Console.ReadLine());
                   Console.WriteLine("Ingrese el segundo numero: ");
                   b=Double.Parse(Console.ReadLine());
                   Console.WriteLine("Resta igual a : " + resta(a,b));
                   break;
            }
        }
        



        public static double suma(double first, double second)
        {
            return first + second;
        }


        public static double resta(double first, double second)
        {
            return first - second;
        }

      
    }
}