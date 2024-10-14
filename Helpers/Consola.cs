namespace Practicas.Helpers
{
    public class Consola
    {
        public static int leerNumero()
        {
            string? num;
            bool valido = false;
            int numero = 0;

            while (!valido)
            {
                Console.WriteLine("\nIngresa numero:");
                num = Console.ReadLine();
                valido = int.TryParse(num, out numero);
                if (!valido)
                {
                    Console.WriteLine("No valido");
                }

            }
            return numero;
        }

        public static string leerCadena()
        {
            string? cadena="";
            while (cadena == null || cadena.Length==0)
            {
                Console.Write("\nIngresar texto:");
                cadena = Console.ReadLine();
            }
            return cadena;
        }
    }
}
