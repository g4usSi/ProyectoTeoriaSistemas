using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoTeoriaSistemas.CodigoFuente;

namespace ProyectoTeoriaSistemas.ventasModule
{
    public class FacturaLogica
    {

        private static string cadena = ConfigurationManager.ConnectionStrings["cadena"].ConnectionString;

        private static FacturaLogica _instancia = null;

        public FacturaLogica()
        {

        }

        public static FacturaLogica Instancia
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia = new FacturaLogica();
                }
                return _instancia;
            }
        }

        public bool Guardar(Factura obj)
        {
            bool respuesta = true;
            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();
                string query = "insert into Factura(Cliente, NIT, Fecha) values (@Cliente, @NIT, @Fecha)";

                SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                //cmd.Parameters.Add(new SQLiteParameter("@ID", obj.ID));
                cmd.Parameters.Add(new SQLiteParameter("@Cliente", obj.Cliente));
                cmd.Parameters.Add(new SQLiteParameter("@NIT", obj.NIT));
                cmd.Parameters.Add(new SQLiteParameter("@Fecha", obj.Fecha.ToString("yyyy-MM-dd HH:mm:ss")));
                cmd.CommandType = System.Data.CommandType.Text;

                if (cmd.ExecuteNonQuery() < 1)
                {
                    respuesta = false;
                }

            }
            return respuesta;
        }
        //metodo para leer y saber si estamos insertando datos 
        public List<Factura> Listar()
        {
            List<Factura> oLista = new List<Factura>();

            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();
                string query = "select * from Factura";
                SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                cmd.CommandType = System.Data.CommandType.Text;

                //este es el encargado de leer nuestras TUPLAS
                using (SQLiteDataReader dr = cmd.ExecuteReader())
                {
                    //mientras lee los agrega a la lista
                    while (dr.Read())
                    {
                        oLista.Add(new Factura()
                        {
                            ID = int.Parse(dr["ID"].ToString()),
                            Cliente = dr["Cliente"].ToString(),
                            NIT = dr["NIT"].ToString(),
                            Fecha = DateTime.Parse(dr["Fecha"].ToString())
                        });
                    }
                }


            }
            return oLista;
        }

        //ESTE ES EL METODO PARA EDITAR UNO DE LOS ELEMENTOS DE LA BASE DE DATOS 
        //SOLO SE CAMBIO LA SENTENCIA SQL Y BUSCA POR EL ID DEL OBJETO
        public bool Editar(Producto obj)
        {
            bool respuesta = true;

            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {

                conexion.Open();

                string query = "Update Articulo set Nombre = @Nombre,Marca = @Marca,Stock = @Stock,Precio = @Precio,PrecioVenta = @PrecioVenta where ID = @ID";


                SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                cmd.Parameters.Add(new SQLiteParameter("@ID", obj.ID));
                cmd.Parameters.Add(new SQLiteParameter("@Nombre", obj.Nombre));
                cmd.Parameters.Add(new SQLiteParameter("@Marca", obj.Marca));
                cmd.Parameters.Add(new SQLiteParameter("@Stock", obj.Stock));
                cmd.Parameters.Add(new SQLiteParameter("@Precio", obj.Precio));
                cmd.Parameters.Add(new SQLiteParameter("@PrecioVenta", obj.PrecioVenta));
                cmd.CommandType = System.Data.CommandType.Text;
                if (cmd.ExecuteNonQuery() < 1)
                {
                    respuesta = false;
                }

            }
            return respuesta;
        }
     
        public List<string> MostrarProveedores()
        {
            List<string> listaProveedores = new List<string>();

            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();
                string query = "SELECT IDProveedor, Nombre FROM Proveedor";

                using (SQLiteCommand cmd = new SQLiteCommand(query, conexion))
                {
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int idProveedor = reader.GetInt32(0);
                            string nombre = reader.GetString(1);

                            // Formato: "IDProveedor - Nombre"
                            listaProveedores.Add($"{idProveedor} - {nombre}");
                        }
                    }
                }
            }

            return listaProveedores;
        }
        //al imprimir el combobox, esto se tiene que pasar a una lista como objeto(en caso de que no se haga la venta, solo se queda en la lista para ser eliminado leugo) y no guardado en el SQL
        public List<string> MostrarArticulosCombo()
        {
            List<string> listaArticulo = new List<string>();

            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();
                string query = "SELECT ID, Nombre FROM Articulo";

                using (SQLiteCommand cmd = new SQLiteCommand(query, conexion))
                {
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int idArticulo = reader.GetInt32(0);      
                            string nombre = reader.GetString(1);       

                            // Formato: "ID - Nombre"
                            listaArticulo.Add($"{idArticulo} - {nombre}");
                        }
                    }
                }
            }

            return listaArticulo;
        }


    }
}
