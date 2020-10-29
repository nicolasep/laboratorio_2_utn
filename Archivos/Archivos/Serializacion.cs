using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Xml;
using System.Xml.Serialization;

namespace Archivos
{
    public class Serializacion<T>
        where T : new()
    {
        //es un proceso para convertir un objeto en algo, puede ser convertirlo a xml
        //hace falta si o si un constructor publico sin parametros y tiene que haber propiedades de lec y esc publicos
        public void Serializar(T objeto, string rutaCompleta)
        {
            XmlTextWriter writer = null;
            XmlSerializer serializer = null;
            try
            {
                writer = new XmlTextWriter(rutaCompleta, Encoding.UTF8);
                writer.Formatting = Formatting.Indented;
                serializer = new XmlSerializer(typeof(T));
                serializer.Serialize(writer, objeto);

            }
            finally
            {
                if(writer != null)
                {
                    writer.Close();
                }
            }
        }
        public T Deserealizar(string rutaCompleta)
        {
            using (XmlTextReader reader = new XmlTextReader(rutaCompleta))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(T));
                return (T)serializer.Deserialize(reader);
            }
        }

    }
}
