namespace Ejercicio1_Fibonnaci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NumFibonacci(30);
        }

        static void NumFibonacci(int n)
        {
            int numActual = 0;
            int numSiguiente = 1;
            int siguiente;

            for (int i = 1; i <= n; i++)
            {
               
                bool esPrimo = numActual > 1;

                for (int j = 2; j * j <= numActual && esPrimo; j++)
                {
                    if (numActual % j == 0)
                        esPrimo = false;
                }

                if (esPrimo)
                    Console.WriteLine(numActual);

               
                siguiente = numActual + numSiguiente;
                numActual = numSiguiente;
                numSiguiente = siguiente;
            }
        }



    }

}
