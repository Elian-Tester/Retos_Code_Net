
using Practicas.Actividad;

class Program
{
    static void Main(string[] args)
    {       
        while (true)
        {
            Console.WriteLine("\nIniciar? y/n");
            if (Console.ReadLine() == "y") {
                //NumerosPrimos.verificarNumerosPrimos();
                //NumeroABinario.ConvetirNumeroABinario();
                //InvertirCadena.invertirCadena();
                //ArraySinRepetidos.sinRepetidos();
                //ContarLetras.countLetter();
                //ContarPalabras.contarPalabras();
                ContarMatch.contarMatch();
            }

        }
    }    
}


