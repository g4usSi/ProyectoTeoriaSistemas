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

        public Producto ObtenerProductoPorID(int id)
        {
            Producto producto = null;

            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();
                string query = "SELECT * FROM Articulo WHERE ID = @ID";

                using (SQLiteCommand cmd = new SQLiteCommand(query, conexion))
                {
                    cmd.Parameters.Add(new SQLiteParameter("@ID", id));

                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            producto = new Producto()
                            {
                                ID = reader.GetInt32(reader.GetOrdinal("ID")),
                                Nombre = reader.GetString(reader.GetOrdinal("Nombre")),
                                Marca = reader.GetString(reader.GetOrdinal("Marca")),
                                Stock = reader.GetInt32(reader.GetOrdinal("Stock")),
                                Precio = (double)reader.GetDecimal(reader.GetOrdinal("Precio")),
                                PrecioVenta = (double)reader.GetDecimal(reader.GetOrdinal("PrecioVenta"))
                            };
                        }
                    }
                }
            }

            return producto;
        }
        public bool GuardarConDetalles(Factura factura)
        {
            bool exito = true;

            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                // Abrimos la conexión
                conexion.Open();

                // Transacción para asegurarnos de que todo se guarde correctamente
                using (var transaction = conexion.BeginTransaction())
                {
                    try
                    {
                        // Guardar la factura principal
                        string queryFactura = "INSERT INTO Factura (Cliente, NIT, Fecha) VALUES (@Cliente, @NIT, @Fecha)";
                        SQLiteCommand cmdFactura = new SQLiteCommand(queryFactura, conexion);
                        cmdFactura.Parameters.Add(new SQLiteParameter("@Cliente", factura.Cliente));
                        cmdFactura.Parameters.Add(new SQLiteParameter("@NIT", factura.NIT));
                        cmdFactura.Parameters.Add(new SQLiteParameter("@Fecha", factura.Fecha.ToString("yyyy-MM-dd HH:mm:ss")));
                        cmdFactura.ExecuteNonQuery();

                        // Obtener el ID de la factura recién insertada
                        long idFactura = conexion.LastInsertRowId;

                        // Guardar los detalles de la factura
                        foreach (var detalle in factura.Detalles)
                        {
                            string queryDetalle = "INSERT INTO DetalleFactura (FacturaID, ProductoID, Cantidad, Precio) VALUES (@FacturaID, @ProductoID, @Cantidad, @Precio)";
                            SQLiteCommand cmdDetalle = new SQLiteCommand(queryDetalle, conexion);
                            cmdDetalle.Parameters.Add(new SQLiteParameter("@FacturaID", idFactura));
                            cmdDetalle.Parameters.Add(new SQLiteParameter("@ProductoID", detalle.Producto.ID)); // Suponiendo que 'Producto' tiene un campo 'ID'
                            cmdDetalle.Parameters.Add(new SQLiteParameter("@Cantidad", detalle.Cantidad));
                            cmdDetalle.Parameters.Add(new SQLiteParameter("@Precio", detalle.Producto.Precio)); // Suponiendo que 'Producto' tiene un campo 'Precio'
                            cmdDetalle.ExecuteNonQuery();
                        }

                        // Confirmamos la transacción
                        transaction.Commit();
                    }
                    catch (Exception)
                    {
                        // Si ocurre un error, revertimos la transacción
                        transaction.Rollback();
                        exito = false;
                    }
                }
            }

            return exito;
        }




    }
}
