using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Archivos;

namespace archivosPrueva
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // string texto = "hola mundo";
                // string nombreArchivo = "clase_19";

                // string ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

                // FileManager fileManager = new FileManager();
                //// fileManager.EscribirArchivoTexto(ruta, nombreArchivo, texto, false);

                // Console.WriteLine(fileManager.LeerArchivoTexto(ruta, nombreArchivo));
                List<Persona> personas = new List<Persona>();

                Persona persona = new Persona("Fede", "Davila", new DateTime(1984, 03, 14));
                Persona persona2 = new Persona("Mauricio", "Cerizza", new DateTime(1992, 02, 09));
                personas.Add(persona);
                personas.Add(persona2);


                Serializacion<List<Persona>> serializacion = new Serializacion<List<Persona>>();
                serializacion.Serializar(personas, "Profes.xml");

                Console.WriteLine(serializacion.Deserealizar("Profes.xml"));
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Ocurrio un error {ex.Message} \n {ex.ToString()}");
            }

            

            Console.ReadKey();
        }
    }
}
