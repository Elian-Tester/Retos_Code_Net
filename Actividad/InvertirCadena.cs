using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practicas.Helpers;

namespace Practicas.Actividad
{
    public class InvertirCadena
    {
        public static void invertirCadena()
        {
            string cadena = Consola.leerCadena();
            //string cadenaInvertida = invertirConFor(cadena);
            string cadenaInvertida = invertirConRevert(cadena);
            Console.WriteLine(cadenaInvertida);
        }

        private static string invertirConFor(string cadena)
        {
            string cadenaInvertida = "";
            for (int i = cadena.Length - 1; i>=0; i--)
            {
                cadenaInvertida += cadena[i];
            }
            return cadenaInvertida;
        }

        private static string invertirConRevert(string cadena)
        {
            char[] chars = cadena.ToCharArray();
            Array.Reverse(chars);            
            return new string(chars);
        }
    }
}
