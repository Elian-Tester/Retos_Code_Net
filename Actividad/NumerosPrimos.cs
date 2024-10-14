
using Practicas.Helpers;

namespace Practicas.Actividad
{
    public class NumerosPrimos
    {
        public static void verificarNumerosPrimos()
        {
            int numero = Consola.leerNumero();
            bool primo = esPrimo(numero);

            if (primo)
            {
                Console.WriteLine("Es primo");
            }
            else
            {
                Console.WriteLine("No es primo");
            }
        }

        public static bool esPrimo(int numero)
        {
            if (numero <= 0) return false;

            for (int i = numero - 1; i > 1; i--)
            {
                if (numero % i == 0)
                    return false;
            }

            return true;
        }
    }
}
