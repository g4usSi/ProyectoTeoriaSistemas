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

//Esta clase se encarga de la conexion a la base de datos, para poder hacer las consultas y guardar los datos


//USA ESTA CLASE PARA MANEJAR TODA LA BASE DE DATOS, es estatica, puedes llamar sus metodos donde querras, solo comenta con "#", para marcar distintos puestos de trabajowo
namespace ProyectoTeoriaSistemas.CodigoFuente
{
    public class PlanillaLogica
    {
        private static string cadena = ConfigurationManager.ConnectionStrings[cadena].ConnectionString;

        private static PlanillaLogica _instancia = null;

        public PlanillaLogica()
        {

        }

        public static PlanillaLogica Instancia
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia = new PlanillaLogica();
                }
                return _instancia;
            }
        }

        

        public bool Guardar(Planilla obj)
        {
            bool respuesta = true;

            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {

                conexion.Open();
                string query = "insert into Planilla(SueldoNetoCalculado,HorasExtras,Comisiones,Bonificaciones,IGSS,Prestamos,Nombre,Cargo) values (@SueldoNetoCalculado,@HorasExtras,@Comisiones,@Bonificaciones,@IGSS,@Prestamos,@Nombre,@Cargo)";

                SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                
                cmd.Parameters.Add(new SQLiteParameter("@SueldoNetoCalculado", obj.SueldoNetoCalculado));
                cmd.Parameters.Add(new SQLiteParameter("@HorasExtras", obj.HorasExtras));
                cmd.Parameters.Add(new SQLiteParameter("@Comisiones", obj.Comisiones));
                cmd.Parameters.Add(new SQLiteParameter("@Bonificaciones", obj.Bonificaciones));
                cmd.Parameters.Add(new SQLiteParameter("@IGSS", obj.IGSS));
                cmd.Parameters.Add(new SQLiteParameter("@Prestamos", obj.Prestamos));
                cmd.Parameters.Add(new SQLiteParameter("@Nombre", obj.Nombre));
                cmd.Parameters.Add(new SQLiteParameter("@Cargo", obj.Cargo));

                cmd.CommandType = System.Data.CommandType.Text;

                if (cmd.ExecuteNonQuery() < 1)
                {
                    respuesta = false;
                }

            }
            return respuesta;
        }
        public List<Planilla> Listar()
        {
            List<Planilla> oLista = new List<Planilla>();

            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();
                string query = "SELECT * FROM Planilla";
                SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                cmd.CommandType = System.Data.CommandType.Text;

                using (SQLiteDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        // Crear objeto de planilla con los valores obtenidos
                        Planilla nuevaPlanilla = new Planilla()
                        {
                            IDPlanilla = int.Parse(dr["IDPlanilla"].ToString()),
                            SueldoNetoCalculado = decimal.Parse(dr["SueldoNetoCalculado"].ToString(), CultureInfo.InvariantCulture), //esta vaina ver si esta wena la chinga 
                            HorasExtras = int.Parse(dr["HorasExtras"].ToString()),
                            Comisiones = decimal.Parse(dr["Comisiones"].ToString(), CultureInfo.InvariantCulture),
                            Bonificaciones = decimal.Parse(dr["Bonificaciones"].ToString(), CultureInfo.InvariantCulture),
                            IGSS = decimal.Parse(dr["IGSS"].ToString(), CultureInfo.InvariantCulture),
                            Prestamos = decimal.Parse(dr["Prestamos"].ToString(), CultureInfo.InvariantCulture),
                            Nombre = dr["Nombre"].ToString(),
                            Cargo = dr["Cargo"].ToString(),
                        };

                        // No es necesario asignar SueldoNeto, se calculará automáticamente
                        oLista.Add(nuevaPlanilla);
                    }
                }
            }
            return oLista;
        }


    }
}

