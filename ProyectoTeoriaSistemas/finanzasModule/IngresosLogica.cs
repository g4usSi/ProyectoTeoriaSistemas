using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SQLite;


namespace ProyectoTeoriaSistemas.financieroModule
{
    public class IngresoLogica
    {
        private static string cadena = ConfigurationManager.ConnectionStrings["cadena"].ConnectionString;

        private static IngresoLogica _instancia = null;
        public static IngresoLogica Instancia
        {
            get
            {
                if (_instancia == null)
                    _instancia = new IngresoLogica();
                return _instancia;
            }
        }

        public bool GuardarIngreso(Ingreso ingreso)
        {
            bool respuesta = true;

            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();

                string query = "INSERT INTO Ingresos (Fecha, Descripcion, Total) VALUES (@Fecha, @Descripcion, @Total)";
                SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                cmd.Parameters.AddWithValue("@Fecha", ingreso.Fecha);
                cmd.Parameters.AddWithValue("@Descripcion", ingreso.Descripcion);
                cmd.Parameters.AddWithValue("@Total", ingreso.Total);

                if (cmd.ExecuteNonQuery() < 1)
                {
                    respuesta = false;
                }
            }

            return respuesta;
        }

        public List<Ingreso> ObtenerIngresosPorMes(int anio, int mes)
        {
            List<Ingreso> lista = new List<Ingreso>();

            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();

                string query = @"SELECT * FROM Ingresos
                                 WHERE strftime('%Y', Fecha) = @anio
                                 AND strftime('%m', Fecha) = @mes";

                SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                cmd.Parameters.AddWithValue("@anio", anio.ToString("D4"));
                cmd.Parameters.AddWithValue("@mes", mes.ToString("D2"));

                using (SQLiteDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        lista.Add(new Ingreso
                        {
                            ID = int.Parse(dr["ID"].ToString()),
                            Fecha = dr["Fecha"].ToString(),
                            Descripcion = dr["Descripcion"].ToString(),
                            Total = decimal.Parse(dr["Total"].ToString())
                        });
                    }
                }
            }

            return lista;
        }
    }

    public class Ingreso
    {
        public int ID { get; set; }
        public string Fecha { get; set; }
        public string Descripcion { get; set; }
        public decimal Total { get; set; }
    }
    


}

