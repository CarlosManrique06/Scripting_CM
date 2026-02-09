
namespace Ejercicio_3_Chance
{
    internal class Program
    {
        static void Main()
        {
           
            string numeroGanador = "1234";
            string numeroJugador = "6664";
            int apuesta = 1000;

         
            bool gano = Sorteo.GanoSorteo(numeroGanador, numeroJugador);
            Console.WriteLine("Ganó: " + gano);

         
            int premio = Sorteo.CalcularPremio(numeroGanador, numeroJugador, apuesta);
            Console.WriteLine("Premio: $" + premio);
        }

    }
}
