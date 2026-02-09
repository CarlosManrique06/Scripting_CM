using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3_Chance
{
   public class Sorteo
    {
        public static bool GanoSorteo(string ganador, string jugador)
        {
            return CalcularPremio(ganador, jugador, 1) > 0;
        }

        public static int CalcularPremio(string ganador, string jugador, int apuesta)
        {
            if (jugador == ganador)
                return apuesta * 4500;

            if (jugador.Length == 4 && ganador.Length == 4)
            {
                if (MismosDigitos(jugador, ganador))
                    return apuesta * 200;
            }

            if (ganador.Length >= 3 && jugador.Length >= 3)
            {
                if (UltimasNCifrasIguales(ganador, jugador, 3))
                    return apuesta * 400;
            }

            if (ganador.Length >= 2 && jugador.Length >= 2)
            {
                if (UltimasNCifrasIguales(ganador, jugador, 2))
                    return apuesta * 50;
            }

            if (ganador.Length >= 1 && jugador.Length >= 1)
            {
                if (ganador[ganador.Length - 1] == jugador[jugador.Length - 1])
                    return apuesta * 5;
            }

            return 0;
        }

        private static bool UltimasNCifrasIguales(string ganador, string jugador, int n)
        {
            for (int i = 1; i <= n; i++)
            {
                if (ganador[ganador.Length - i] != jugador[jugador.Length - i])
                    return false;
            }
            return true;
        }

        private static bool MismosDigitos(string num1, string num2)
        {
            int[] conteo1 = new int[10];
            for (int i = 0; i < num1.Length; i++)
            {
                int digito = num1[i] - '0';
                conteo1[digito]++;
            }

            int[] conteo2 = new int[10];
            for (int i = 0; i < num2.Length; i++)
            {
                int digito = num2[i] - '0';
                conteo2[digito]++;
            }

            for (int i = 0; i < 10; i++)
            {
                if (conteo1[i] != conteo2[i])
                    return false;
            }

            return true;
        }
    }
}
