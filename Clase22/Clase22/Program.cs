using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Clase22
{
    class Program
    {
        private static short numerosEmpleadosAtendiendo;
        private static Random random;
        private static short clientesSiendoAtendidos;
        private static string[] randomNames;
        
        static Program()
        {
            random = new Random();
            clientesSiendoAtendidos = 0;
            numerosEmpleadosAtendiendo = 5;
            randomNames = new string[] { "fede", "lucas", "eze", "flor", "maxi", "octavio" };
        }
        static void Main(string[] args)
        {
            while(true)
            {
                if(clientesSiendoAtendidos < numerosEmpleadosAtendiendo)
                {
                    //al delegado se le pasa el metodo para encapsular y al thread se le pasa el delegado
                    //forma larga
                    //ThreadStart threadStart = new ThreadStart(AtenderCliente); // es un delegado
                    //Thread thread = new Thread(threadStart);//resibe un delegado como argumento del constructor
                    //threadStart.Invoke(); lo hace internamente el thread

                    //forma intermedia 
                    //Thread thread = new Thread(new ThreadStart(AtenderCliente));// instancia un threadstart que es un delegado si el metodo no recibe nada

                    Thread thread = new Thread(new ParameterizedThreadStart(AtenderCliente));//cuando el metodo tiene un argumento

                    //forma corta

                    //Thread thread = new Thread(AtenderCliente);//internamente es como hacerlo de la forma larga
                    //thread.Start();
                   
                    thread.Start(5000); //internamente hace el .invoke le paso el argumento de la funcion dentro del start

                    Thread.Sleep(200);

                    if(thread != null && thread.IsAlive)
                    {
                        thread.Abort();
                    }
                }
            }
        }

        public static void AtenderCliente(object duracionMaxima)
        {
            int cliente = random.Next(0, 5);
            Thread.Sleep(200);
            string nombreCliente = randomNames[cliente];
            //int duracionAtencion = random.Next(2000, 5000);
            int duracionAtencion = random.Next(2000, (int)duracionMaxima);
            clientesSiendoAtendidos++;
            Console.WriteLine($"Atendiendo a {nombreCliente}...");

            Thread.Sleep(duracionAtencion);

            Console.WriteLine($"Finalizo la atencion del cliente {nombreCliente} despues de {duracionAtencion} milisegundos");
            clientesSiendoAtendidos--;
        }
    }
}
