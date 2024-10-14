using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicas.Actividad
{
    public class ContarLetras
    {
        public static void countLetter()
        {
            string cadena = "agropecuario andando alejado";
            char letra = 'a';
            //int countLetter = countLetterWithFor(cadena,letra);
            int countLetter = countLetterWithLinq(cadena,letra);
            Console.WriteLine(countLetter);
        }
        public static int countLetterWithFor(string cadena, char letra)
        {            
            int contador = 0;
            foreach (char c in cadena)
            {
                if (c == letra)
                    contador++;                
            }

            return contador;
        }
        public static int countLetterWithLinq(string cadena, char letra)
        {                        
            return cadena.Where(c => c == letra).Count();
        }
    }
}
