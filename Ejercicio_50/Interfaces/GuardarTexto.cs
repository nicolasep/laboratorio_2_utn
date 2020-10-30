using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class GuardarTexto<T,V> : IGuardar<T,V>
    {
        public bool Guardar(T obj)
        {
            bool resultado = false;
            StreamWriter streamWriter = null;
            try
            {
                streamWriter = new StreamWriter("prueba", true);
                streamWriter.WriteLine(obj);
                resultado = true;
            }
            finally
            {
                if (streamWriter != null)
                {
                    streamWriter.Close();
                }
            }
            return resultado;
        }
        public V Leer()
        {
            StreamReader streamReader = null;
            try
            {
                streamReader = new StreamReader("prueba");
                string text = string.Empty;
                string newLine;
                
                while((newLine = streamReader.ReadLine())!= null)
                {
                    text += newLine + "\n";
                }
               
                
                return (V)Convert.ChangeType(text,typeof(V));
            }
            finally
            {
                streamReader.Close();
            }
        }
    }
}
