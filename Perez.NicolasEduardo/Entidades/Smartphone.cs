using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Importador
{
    public class Smartphone : Producto
    {
        public Smartphone(string nombre, int valorDeCompra, Origen origen): base(nombre, valorDeCompra,origen)
        {

        }

        public override int PorcentajeGanancia
        {
            get
            {//10%
                return base.PorcentajeGanancia;
            }
        }
        public override int PorcentajeImpuestoInterno
        {
            get
            {//21
                return base.PorcentajeImpuestoInterno;
            }
        }
        public override float ValorDeVenta
        {
            get
            {
                float total;
                if((Origen)this == Origen.Nacional)
                {
                    total = base.ValorDeVenta - (base.ValorDeVenta * 20) / 100;
                    return total;
                }
                return base.ValorDeVenta;
            }
        }
    }
}
