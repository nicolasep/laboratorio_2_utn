using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
    public class Factura<TProducto> //creacion de lista generica propia
        where TProducto : Producto//se restringe a crear una lista pero solo de producto y clases que hereden //se limita el tipo TProducto a Producto, hereda de el
    {

        public string GenerarFactura(TProducto producto, int unidades)
        {
            double precioFinal = producto.Precio + producto.Precio * 0.21;
            return $"Compraste {unidades} unidades de {producto.ToString()}. Precio Final: {precioFinal}";
            
        }
    }
}
