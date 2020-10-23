using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Importador
{
    public class LineaBlanca : Producto
    {
        private bool aplicaDescuento;

        public LineaBlanca(string nombre, int valorDeCompra, Origen origen):this(nombre,valorDeCompra,origen,false)
        {

        }
        public LineaBlanca(string nombre, int valorDeCompra, Origen origen, bool aplicaDescuento):base(nombre,valorDeCompra,origen)
        {
            this.aplicaDescuento = aplicaDescuento;
        }
        public int Descuento
        {
            get
            {
                if(this.aplicaDescuento)
                {
                    return 10;
                }
                return 0;
            }
        }
        public override int PorcentajeGanancia
        {
            get
            {
                return 0;
            }
        }
        public override int PorcentajeImpuestoInterno
        {
            get
            {
                return 0;
            }
        }
        public override float ValorDeVenta
        {
            get
            {
                if(this.Descuento != 0)
                {
                    return base.ValorDeVenta - (base.ValorDeVenta * this.Descuento) / 100;
                }
                return base.ValorDeVenta;
            }
        }
        public override string Etiqueta()
        {
            string aplica;
            if(this.aplicaDescuento)
            {
                aplica = "Si";
            }
            else
            {
                aplica = "No";
            }
            StringBuilder sb = new StringBuilder();
            sb.Append($"{base.Etiqueta()} aplica descuento: {aplica}");

            return sb.ToString();
        }
    }
}
