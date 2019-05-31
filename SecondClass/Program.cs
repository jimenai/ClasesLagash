using System;

namespace SecondClass
{
    class Program
    {   
        // Divide con un bucle aplicando las restas sucesivas
        static int DividirNumeros(int dividendo, int divisor)
        {   
            int i = 0;
            // Validamos que la division sea factible
            if(dividendo < divisor)
                return i;             
            
            for(i = 1; dividendo - divisor >= divisor; i++, dividendo -= divisor);

            return i;
        }

        static int DividirNumerosR(int dividendo, int divisor)
        {   
            // Llamada de corte a la recursividad
            if(dividendo < divisor)
                return 0;             
            
            return 1 + DividirNumerosR(dividendo - divisor, divisor);
        }
        static void Main(string[] args)
        {
            //diegoglagash.com
            var dividendo = 10;
            var divisor = 2;
            var resultado = DividirNumerosR(dividendo,divisor);
            Console.WriteLine(string.Format("El resultado de dividir {0} por {1} es {2} ", dividendo, divisor, resultado));
        }
    }
}
