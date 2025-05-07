using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Globalization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using System.Linq.Expressions;

namespace ProyectoTeoriaSistemas.CodigoFuente
{
    public class ProductoLogica
    {
        private static string cadena = ConfigurationManager.ConnectionStrings["cadena"].ConnectionString;

        private static ProductoLogica _instancia = null;

        public ProductoLogica()
        {

        }

        public static ProductoLogica Instancia
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia = new ProductoLogica();
                }
                return _instancia;
            }
        }

        public bool Guardar(Producto obj)
        {
            bool respuesta = true;
            //esta cosa pide una cadena de conexcion, la cadena de conexion la declaramos arribia, es la primera
            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                //"abrimos la cadena de conexion"
                conexion.Open();
                //un objeto llamado query, que ingresa los datos en nuestra "TABLA Articulo", en los campos
                //" ID, Nombre, Marca, Cantidad, Precio " se trabaja con parametros para evitar la Inyeccion SQL
                //EN RESUMEN AGREGA LOS DATOS QUE LE MANDO
                //string query = "insert into Articulo(ID,Nombre,Marca,Cantidad,Precio) values (@ID,@Nombre,@Marca,@Cantidad,@Precio)";
                string query = "insert into Articulo(Nombre, Marca, Stock, Precio, PrecioVenta, IDProveedores, Fecha) values (@Nombre, @Marca, @Stock, @Precio, @PrecioVenta, @IDProveedores, @Fecha)";

                //esto recibe nuestra query que creamos arriba y nuestra conexion, este CMD se encarga de ejecutar nuestra consulta
                //pero le tenemos que decir que envie unos parametros
                SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                //el nombre del parametro y el valor, le enviamos un objeto de tipo persona
                // cmd.Parameters.Add(new SQLiteParameter("@ID", obj.ID));
                cmd.Parameters.Add(new SQLiteParameter("@Nombre", obj.Nombre));
                cmd.Parameters.Add(new SQLiteParameter("@Marca", obj.Marca));
                cmd.Parameters.Add(new SQLiteParameter("@Stock", obj.Stock));
                cmd.Parameters.Add(new SQLiteParameter("@Precio", obj.Precio));
                cmd.Parameters.Add(new SQLiteParameter("@PrecioVenta", obj.PrecioVenta));
                cmd.Parameters.Add(new SQLiteParameter("@IDProveedores", obj.IDProveedor)); // <-- parametro obligatorio, es decir que ya debe haber un proveedor en otra tabla
                cmd.Parameters.Add(new SQLiteParameter("@Fecha", obj.Fecha.ToString("yyyy-MM-dd"))); //debe ser la fecha acutal
                //ahora le decimos que tipo va a ser 
                cmd.CommandType = System.Data.CommandType.Text;

                //si la cantidad de filas afectadas es menor que 1 significa que no se realizo bien 
                //el comando y que ninguna fila fue afectada
                if (cmd.ExecuteNonQuery() < 1)
                {
                    respuesta = false;
                }

            }
            return respuesta;
        }
        //metodo para leer y saber si estamos insertando datos 
        public List<Producto> Listar()
        {
            List<Producto> oLista = new List<Producto>();

            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();
                string query = "SELECT * FROM Articulo ORDER BY ID DESC"; // Orden descendente por ID
                SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                cmd.CommandType = System.Data.CommandType.Text;

                using (SQLiteDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        oLista.Add(new Producto()
                        {
                            ID = int.Parse(dr["ID"].ToString()),
                            Nombre = dr["Nombre"].ToString(),
                            Marca = dr["Marca"].ToString(),
                            Stock = int.Parse(dr["Stock"].ToString()),
                            Precio = int.Parse(dr["Precio"].ToString()),
                            PrecioVenta = int.Parse(dr["PrecioVenta"].ToString()),
                            IDProveedor = int.Parse(dr["IDProveedores"].ToString()),
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
        
        // metodo de eliminar DU'H 
        public bool Eliminar(Producto obj)
        {
            bool respuesta = true;

            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();

                string query = "delete from Articulo where ID = @ID";
                SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                cmd.Parameters.Add(new SQLiteParameter("@ID", obj.ID));
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



        /*
        public Producto ObtenerPorID(int id)
        {
            Producto articulo = null; // Inicializamos el objeto en null para manejar casos en los que no se encuentre el artículo.

            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();
                string query = "SELECT * FROM Articulo WHERE ID = @ID"; // Usamos un parámetro para evitar inyección SQL.
                SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@ID", id); // Agregamos el parámetro ID.

                // Ejecutamos el comando y leemos los resultados.
                using (SQLiteDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.Read()) // Si encuentra un registro.
                    {
                        articulo = new Producto()
                        {
                            ID = int.Parse(dr["ID"].ToString()),
                            Nombre = dr["Nombre"].ToString(),
                            Marca = dr["Marca"].ToString(),
                            Cantidad = int.Parse(dr["Cantidad"].ToString()),
                            Precio = int.Parse(dr["Precio"].ToString()),
                        };
                    }
                }
            }

            return articulo; // Devuelve el artículo encontrado o null si no existe.
        }
        */







    }
}
