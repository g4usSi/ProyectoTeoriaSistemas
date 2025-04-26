using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SQLite;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoTeoriaSistemas.CodigoFuente;

namespace ProyectoTeoriaSistemas.inventarioModule
{
    public class ProveedorLogica
    {
        private static string cadena = ConfigurationManager.ConnectionStrings["cadena"].ConnectionString;

        private static ProveedorLogica _instancia = null;

        public ProveedorLogica()
        {

        }

        public static ProveedorLogica Instancia
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia = new ProveedorLogica();
                }
                return _instancia;
            }
        }

        public bool Guardar(Proveedor obj)
        {
            bool respuesta = true;
            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();
                string query = "insert into Proveedor(Nombre,NIT,Telefono,Contacto,Direccion,Correo) values (@Nombre,@NIT,@Telefono,@Contacto,@Direccion,@Correo)";

                SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                cmd.Parameters.Add(new SQLiteParameter("@Nombre", obj.Nombre));
                cmd.Parameters.Add(new SQLiteParameter("@NIT", obj.NIT));
                cmd.Parameters.Add(new SQLiteParameter("@Telefono", obj.Telefono));
                cmd.Parameters.Add(new SQLiteParameter("@Contacto", obj.Contacto));
                cmd.Parameters.Add(new SQLiteParameter("@Direccion", obj.Direccion));
                cmd.Parameters.Add(new SQLiteParameter("@Correo", obj.Correo));
                
                cmd.CommandType = System.Data.CommandType.Text;

                if (cmd.ExecuteNonQuery() < 1)
                {
                    respuesta = false;
                }

            }
            return respuesta;
        }

        //metodo para leer y saber si estamos insertando datos 
        public List<Proveedor> Listar()
        {
            List<Proveedor> oLista = new List<Proveedor>();

            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();
                string query = "select * from Proveedor";
                SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                cmd.CommandType = System.Data.CommandType.Text;

                //este es el encargado de leer nuestras TUPLAS
                using (SQLiteDataReader dr = cmd.ExecuteReader())
                {
                    //mientras lee los agrega a la lista
                    while (dr.Read())
                    {
                        oLista.Add(new Proveedor()
                        {
                            IDProveedor = int.Parse(dr["ID"].ToString()),
                            Nombre = dr["Nombre"].ToString(),
                            NIT = dr["Marca"].ToString(),
                            Telefono = int.Parse(dr["Telefono"].ToString()),
                            Contacto = dr["Contacto"].ToString(),
                            Direccion = dr["Direccion"].ToString(),
                            Correo = dr["Correo"].ToString(),
                            
                        });
                    }
                }


            }
            return oLista;
        }

        //ESTE ES EL METODO PARA EDITAR UNO DE LOS ELEMENTOS DE LA BASE DE DATOS 
        //SOLO SE CAMBIO LA SENTENCIA SQL Y BUSCA POR EL ID DEL OBJETO
        public bool Editar(Proveedor obj)
        {
            bool respuesta = true;

            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {

                conexion.Open();                                                                                                                     
                string query = "Update Proveedor set Nombre = @Nombre,NIT = @NIT,Telefono = @Telefono,Contacto = @Contacto,Direccion = @Direccion,Correo = @Correo where IDProveedor = @IDProveedor";

                SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                cmd.Parameters.Add(new SQLiteParameter("@ID", obj.IDProveedor));
                cmd.Parameters.Add(new SQLiteParameter("@Nombre", obj.Nombre));
                cmd.Parameters.Add(new SQLiteParameter("@NIT", obj.NIT));
                cmd.Parameters.Add(new SQLiteParameter("@Telefono", obj.Telefono));
                cmd.Parameters.Add(new SQLiteParameter("@Contacto", obj.Contacto));
                cmd.Parameters.Add(new SQLiteParameter("@Direccion", obj.Direccion));
                cmd.Parameters.Add(new SQLiteParameter("@Correo", obj.Correo));
                cmd.CommandType = System.Data.CommandType.Text;
                if (cmd.ExecuteNonQuery() < 1)
                {
                    respuesta = false;
                }

            }
            return respuesta;
        }

        //este metodo es para cuando insertando articulos, podemos jalar solo el nombre del proveedor en un combobox

        public List<Proveedor> ObtenerProveedores()
        {
            List<Proveedor> lista = new List<Proveedor>();
            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();
                string query = "SELECT IDProveedor, Nombre FROM Proveedor";
                SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                SQLiteDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    lista.Add(new Proveedor
                    {
                        IDProveedor = Convert.ToInt32(reader["IDProveedor"]),
                        Nombre = reader["Nombre"].ToString()
                    });
                }
            }
            return lista;
        }
        // metodo de eliminar DU'H 
        public bool Eliminar(Proveedor obj)
        {
            bool respuesta = true;

            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();

                string query = "delete from Proveedor where ID = @ID";
                SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                cmd.Parameters.Add(new SQLiteParameter("@ID", obj.IDProveedor));
                cmd.CommandType = System.Data.CommandType.Text;
                if (cmd.ExecuteNonQuery() < 1)
                {
                    respuesta = false;
                }

            }
            return respuesta;
        }

    }
}
