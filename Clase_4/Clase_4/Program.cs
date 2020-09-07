using System;

namespace Clase_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona jose = 231;
            int numero = 10;
            float num = 10.5f;

            num = numero;//conversion implicita
            numero =(int) num;//conversion explicita


            Console.ReadKey();
        }
    }
}
