using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_33
{
    public class Libro
    {
        private List<string> paginas = new List<string>();

        public void Mostrar()
        {


            foreach (string palabra in paginas)
            {
                Console.WriteLine(palabra);
            }
        }
        public string this[int i]
        {
            get
            {
                
                if( i > paginas.Count)
                {
                    return " ";

                }
                else
                {
                    return paginas[i];
                }
                
            }
            set
            {
                if(i >= paginas.Count )
                {
                    paginas.Add(value);
                    
                }
                else
                {
                    paginas[i] = value;
                }
            }

        }
            



    }
}
