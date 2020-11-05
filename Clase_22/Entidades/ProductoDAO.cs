using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ProductoDAO
    {
        /*
        private SqlConnection sqlConnection;
        public ProductoDAO()
        {
            string connectionString = "Server =.; Database = ProductosDB; Trusted_Connection = True"; //"Data Source=.;Initial Catalog=Sistema;Integrated Security=True";
            this.sqlConnection = new SqlConnection(connectionString);
        }
        public void InsertarProducto(Producto producto)
        {
            try
            {
                string command = "INSERT INTO Prioductos(nombre,precio,codigo) VALUES(@nombre,@precio,@codigo)";

                SqlCommand sqlCommand = new SqlCommand(command, this.sqlConnection);
                sqlCommand.Parameters.AddWithValue("nombre", producto.Nombre);
                sqlCommand.Parameters.AddWithValue("precio", producto.Precio);
                sqlCommand.Parameters.AddWithValue("codigo", producto.Codigo);
                //sqlCommand.Parameters.AddWithValue("descripcion", producto.Descripcion);
                this.sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();
            }
            finally
            {
                if(sqlConnection != null)
                {
                    this.sqlConnection.Close();
                }
            }*/
        private SqlConnection sqlConnection;
        private string connectionString;

        public ProductoDAO()
        {
            this.connectionString = "Server=.;Database=ProductosDB;Trusted_Connection=True;";
            this.sqlConnection = new SqlConnection(connectionString);
        }

        public void InsertarProducto(Producto producto)
        {
            try
            {
                string command = "INSERT INTO Productos2(nombre, precio, codigo) VALUES(@nombre, @precio, @codigo)";

                SqlCommand sqlCommand = new SqlCommand(command, this.sqlConnection);
                sqlCommand.Parameters.AddWithValue("nombre", producto.Nombre);
                sqlCommand.Parameters.AddWithValue("precio", producto.Precio);
                sqlCommand.Parameters.AddWithValue("codigo", producto.Codigo);

                this.sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();
            }
            finally
            {
                if (sqlConnection != null &&
                    sqlConnection.State == System.Data.ConnectionState.Open)
                {
                    this.sqlConnection.Close();
                }
            }
        }
        public void ModificarProducto(int id, string nombre)
        {
            try
            {
                string command = "UPDATE Productos2 SET nombre=@nombre WHERE id=" +id;

                SqlCommand sqlCommand = new SqlCommand(command, this.sqlConnection);
                sqlCommand.Parameters.AddWithValue("nombre", nombre);

                this.sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();
            }
            finally
            {
                if (sqlConnection != null &&
                    sqlConnection.State == System.Data.ConnectionState.Open)
                {
                    this.sqlConnection.Close();
                }
            }
        }
        public void EliminarProducto(int id)
        {
            try
            {
                string command = "DELETE FROM Productos2 WHERE id=" + id;

                SqlCommand sqlCommand = new SqlCommand(command, this.sqlConnection);
                //sqlCommand.Parameters.AddWithValue("nombre", nombre);

                this.sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();
            }
            finally
            {
                if (sqlConnection != null &&
                    sqlConnection.State == System.Data.ConnectionState.Open)
                {
                    this.sqlConnection.Close();
                }
            }
        }
        public List<Producto> ListarProductos()
        {
            using(SqlConnection sqlConnection = new SqlConnection(this.connectionString))
            {
                string command = "SELECT * FROM Productos2";
                SqlCommand sqlCommand = new SqlCommand(command, this.sqlConnection);
                this.sqlConnection.Open();
                SqlDataReader reader = sqlCommand.ExecuteReader();
                List<Producto> productos = new List<Producto>();

                while(reader.Read())
                {
                    int id = (int)reader["id"];
                    string nombre = (string)reader["nombre"];
                    string codigo = (string)reader["codigp"];
                    float precio = (float)reader["precio"];
                    string descripcion = null;
                    if (reader["descripcion"] != DBNull.Value)
                    {
                        descripcion = (string)reader["descripcion"];
                    }
                    
                    Producto producto = new Producto(id,codigo,nombre,precio,descripcion);
                    productos.Add(producto);
                }
                return productos;
            }
        }

        public Producto ListarProductoPorId(int idProd)
        {
            using (SqlConnection sqlConnection = new SqlConnection(this.connectionString))
            {
                string command = "SELECT * FROM Productos2 WHERE id=@id";
                SqlCommand sqlCommand = new SqlCommand(command, this.sqlConnection);
                this.sqlConnection.Open();
                SqlDataReader reader = sqlCommand.ExecuteReader();
                sqlCommand.Parameters.AddWithValue("id", idProd);
                Producto producto = null;
                if(reader.Read())
                {
                    int id = (int)reader["id"];
                    string nombre = (string)reader["nombre"];
                    string codigo = (string)reader["codigp"];
                    float precio = (float)reader["precio"];
                    string descripcion = null;
                    if (reader["descripcion"] != DBNull.Value)
                    {
                        descripcion = (string)reader["descripcion"];
                    }

                    producto = new Producto(id, codigo, nombre, precio, descripcion);
                }
                
                    
                
                return producto;
            }
        }

    }
 }

