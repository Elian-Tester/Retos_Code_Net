using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Practicas.Actividad
{
    public class ContarMatch
    {
        public static void contarMatch()
        {
            string cadena = "123asd354ADdd3231aw8ASado";
            string pattern = @"[0-9]";
            string pattern2 = @"[a-zA-Z]";
            int findCount = Regex.Matches(cadena, pattern2).Count();
            Console.WriteLine("Encontrados: "+ findCount);
        }
    }
}
