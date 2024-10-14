using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Practicas.Actividad
{
    public class ContarPalabras
    {
        public static void contarPalabras()
        {
            string texto = "  hola muy   buenas    a     todos       ";
            texto = Regex.Replace(texto, @"\s+", " ").Trim();
            string[] palabras = texto.Split(' ');

            Console.WriteLine(palabras.Length);
        }
    }
}
