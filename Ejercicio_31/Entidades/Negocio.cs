using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Negocio
    {
        private PuestoAtencion caja;
        private Queue<Cliente> clientes;
        private string nombre;

        public Cliente Cliente
        {
            get
            {
                return this.clientes.ElementAt(1);
            }
            set
            {
                if(this != value)
                {
                    bool i = this + value;
                }
                
                
            }
        }
        public int ClientesPendientes
        {
            get
            {
                return this.clientes.Count;
            }
        }
        private Negocio()
        {
            this.clientes = new Queue<Cliente>();
            this.caja = new PuestoAtencion(PuestoAtencion.Puesto.Caja1);
        }
        public Negocio(string nombre):this()
        {

        }
        public static bool operator ==(Negocio n, Cliente c)
        {
            foreach(Cliente cli in n.clientes)
            {
                if(cli == c)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool operator !=(Negocio n, Cliente c)
        {
            return !(n == c);
        }
        public static bool operator ~(Negocio n)
        {

            if(n.caja.Atender(n.Cliente))
            {
                return true;
            }

            return false;
        }
        public static bool operator +(Negocio n, Cliente c)
        {
            foreach(Cliente l in n.clientes)
            {
                if(l == c)
                {
                    return false;
                }
            }
            n.clientes.Enqueue(c);
            return true;
        }
    }
}
