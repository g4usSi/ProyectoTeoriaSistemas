using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
//Esta clase se encarga de la conexion a la base de datos, para poder hacer las consultas y guardar los datos


//USA ESTA CLASE PARA MANEJAR TODA LA BASE DE DATOS, es estatica, puedes llamar sus metodos donde querras, solo comenta con "#", para marcar distintos puestos de trabajowo
namespace ProyectoTeoriaSistemas.CodigoFuente
{
    public static class PlanillaDB
    {
        private static string connectionString = "your_connection_string_here";

        //Me lo dio Chat, solo lo llamas al metodo y se conecta a la base de datos equise :V
        public static void GuardarPlanillaEnSQL(Planilla trabajador)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Consulta SQL para insertar datos en la tabla Planilla
                string query = @"INSERT INTO Planilla (DPI, Nombre, Cargo, TotalDevengado, TotalDescuentos, SueldoNeto) 
                         VALUES (@DPI, @Nombre, @Cargo, @TotalDevengado, @TotalDescuentos, @SueldoNeto)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Agregar parámetros con valores de la instancia `trabajador`
                    command.Parameters.AddWithValue("@DPI", trabajador.Empleado.DPI); // DPI del empleado
                    command.Parameters.AddWithValue("@Nombre", trabajador.Empleado.Nombre); // Nombre del empleado
                    command.Parameters.AddWithValue("@Cargo", trabajador.Empleado.Cargo); // Cargo del empleado

                    // Totales calculados en la clase Planilla
                    command.Parameters.AddWithValue("@TotalDevengado", trabajador.TotalDevengado);
                    command.Parameters.AddWithValue("@TotalDescuentos", trabajador.TotalDescuentos);
                    command.Parameters.AddWithValue("@SueldoNeto", trabajador.SueldoNeto);

                    // Abrir conexión con la base de datos y ejecutar la consulta
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

    }
}

