using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Clase_22
{
    class Program
    {
        static void Main(string[] args)
        {
            //Server=.;Database=ProductosDB;Trusted_Connection=True;
            Producto prod1;
            ProductoDAO productoDAO;
            try
            {
                prod1 = new Producto(1, "12asd", "Sprite", 23.2f, "slsads");
                productoDAO = new ProductoDAO();
                //productoDAO.InsertarProducto(prod1);
                //productoDAO.ModificarProducto(1,"Ernesto");
                //productoDAO.EliminarProducto(1);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
            try
            {
                Producto n;
                ProductoDAO a = new ProductoDAO();
                n = a.ListarProductoPorId(3);

                Console.WriteLine($"Id:{n.Id} Nombre:{n.Nombre} Precio:{n.Precio}");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            //
            Console.ReadKey();
        }
    }
}
