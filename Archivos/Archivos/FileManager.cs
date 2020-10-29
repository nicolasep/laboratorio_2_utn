using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Archivos
{
    public class FileManager
    {
        public void EscribirArchivoTexto(string ruta, string nombre, string texto, bool anexar)
        {

            StreamWriter streamWriter = null;
            try
            {//en ves de usar \\ se puede usar @"\"  al usar el arroba no toma los caracteres de escape
                string rutaCompleta = ruta +"\\"+ nombre + ".txt";
                streamWriter = new StreamWriter(rutaCompleta, anexar);//si anexar esta en true no pisa el contenido del archivo
                streamWriter.WriteLine(texto);
            }
            finally
            {
                if(streamWriter != null)
                {
                    streamWriter.Close();
                }
                
            }
            
            

        }
        public string LeerArchivoTexto(string ruta, string nombre)
        {

            StreamReader streamReader = null;
            try
            {//en ves de usar \\ se puede usar @"\"  al usar el arroba no toma los caracteres de escape
                string rutaCompleta = ruta + "\\" + nombre + ".txt";
                streamReader = new StreamReader(rutaCompleta);

                string text = string.Empty;

                string newLine;

                while((newLine = streamReader.ReadLine())!= null)
                {
                    text += newLine + "\n";

                }
                return text;
            }
            finally
            {
                if (streamReader != null)
                {
                    streamReader.Close();
                }

            }
        }

    }
}
