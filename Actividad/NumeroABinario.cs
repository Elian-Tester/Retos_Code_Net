
using Practicas.Helpers;

namespace Practicas.Actividad
{
    public class NumeroABinario
    {
        public static void ConvetirNumeroABinario()
        {
            int numero = Consola.leerNumero();
            string binario = numeroABinaro(numero);
            Console.WriteLine(binario);
        }
        public static string numeroABinaro(int numero)
        {
            string binario="";
            while (numero > 0)
            {
                binario = (numero % 2).ToString() + binario;
                numero=numero / 2;
            }

            return binario;
        }
    }
}
