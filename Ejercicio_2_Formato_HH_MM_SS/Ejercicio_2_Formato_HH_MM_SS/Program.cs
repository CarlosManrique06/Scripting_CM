namespace Ejercicio_2_Formato_HH_MM_SS
{
    namespace Ejercicio1_Fibonnaci
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                MostrarHora(3600);
            }


            static void MostrarHora(int totalSegundos)
            {
                int horas = totalSegundos / 3600;
                int minutos = (totalSegundos % 3600) / 60;
                int segundos = totalSegundos % 60;

                Console.WriteLine($"{horas:D2}:{minutos:D2}:{segundos:D2}");
            }


        }

    }

}
