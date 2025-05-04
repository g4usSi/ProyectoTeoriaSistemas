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
    public class DetallesDeFacturaLogica
    {

        private static string cadena = ConfigurationManager.ConnectionStrings["cadena"].ConnectionString;

        private static DetallesDeFactura _instancia = null;


        public static DetallesDeFactura Instancia
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia = new DetallesDeFactura();
                }
                return _instancia;
            }
        }

        public bool Guardar(DetallesDeFactura obj)
        {
            bool respuesta = true;
            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();
                string query = "insert into DetalleFactura(IDFactura, IDArticulo, Cantidad, PrecioUnitario) values (@IDFactura, @IDArticulo, @Cantidad, @PrecioUnitario)";

                SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                cmd.Parameters.Add(new SQLiteParameter("@IDFactura", obj.IDFactura));
                cmd.Parameters.Add(new SQLiteParameter("@IDArticulo", obj.IDArticulo));
                cmd.Parameters.Add(new SQLiteParameter("@Cantidad", obj.Cantidad));
                cmd.Parameters.Add(new SQLiteParameter("@PrecioUnitario", obj.PrecioUnitario));
                cmd.CommandType = System.Data.CommandType.Text;

                if (cmd.ExecuteNonQuery() < 1)
                {
                    respuesta = false;
                }

            }
            return respuesta;
        }
        //metodo para leer y saber si estamos insertando datos 
        public List<DetallesDeFactura> Listar()
        {
            List<DetallesDeFactura> oLista = new List<DetallesDeFactura>();

            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();
                string query = "select * from DetalleFactura";
                SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                cmd.CommandType = System.Data.CommandType.Text;

                //este es el encargado de leer nuestras TUPLAS
                using (SQLiteDataReader dr = cmd.ExecuteReader())
                {
                    //mientras lee los agrega a la lista
                    while (dr.Read())
                    {
                        oLista.Add(new DetallesDeFactura()
                        {

                            IDDetalle = int.Parse(dr["IDDetalle"].ToString()),
                            IDFactura = int.Parse(dr["IDFactura"].ToString()),
                            IDArticulo = int.Parse(dr["IDArticulo"].ToString()),
                            Cantidad = int.Parse(dr["Cantidad"].ToString()),
                            PrecioUnitario = decimal.Parse(dr["PrecioUnitario"].ToString()),
                            
                        });
                    }
                }


            }
            return oLista;
        }

      
        //VER SI ESTO FUNCIONA, ESTO ME LO DIO CHAT, RECIBE EL ID DEL PRODUCTO Y EL STOCK QUE SE VA A QUITAR, PERO NO SE DONDE HAY QUE PONER
        //LO DE QUE NO PUEDE SER MENOR QUE 0

        //Si funciona pero lo hace por separado... primero actualiza el stock, luego verifica en el coso, lo voy a meter en la otra clase :V
        //ya manejo la excepcion directamente en el formulario NTP :3
        /*
        public bool ActualizarStock(int idProducto, int nuevoStock)
        {
            bool respuesta = true;

            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();

                string query = "UPDATE Articulo SET Stock = @Stock WHERE ID = @ID";

                using (SQLiteCommand cmd = new SQLiteCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@Stock", nuevoStock);
                    cmd.Parameters.AddWithValue("@ID", idProducto);

                    if (cmd.ExecuteNonQuery() < 1)
                    {
                        respuesta = false;
                    }
                }
            }

            return respuesta;
        }
        */
    }
}
