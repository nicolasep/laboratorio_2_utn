namespace Entidades
{
    public class Producto
    {
        private int id;
        private string nombre;
        private string descripcion;
        private string codigo;
        private float precio;

        public Producto(int id, string codigo, string nombre, float precio, string descripcion)
        {
            this.id = id;
            this.codigo = codigo;
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.precio = precio;
        }
        public int Id
        {
            set
            {
                this.id = value;
            }
            get
            {
               return this.id;
            }
        }

        public string Nombre 
        { 
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;

            }
        }
        public float Precio 
        { 
            get
            {
                return this.precio;
            }
            set
            {
                this.precio = value;
            }
        }
        public string Codigo 
        { 
            get
            {
                return this.codigo;
            }
            set
            {
                this.codigo = value;
            }
        }
        public string Descripcion 
        { 
            get
            {
                return this.descripcion;
            }
            set
            {
                this.descripcion = value;
            }
        }
    }
}