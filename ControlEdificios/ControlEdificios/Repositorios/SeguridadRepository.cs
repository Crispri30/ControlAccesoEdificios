using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using ControlEdificios.Modelos;
using ControlEdificios.Utilidades;

namespace ControlEdificios.Repositorios
{
    public class SeguridadRepository
    {
        public static List<AccesosActivos> ObtenerAccesosActivos()
        {
            List<AccesosActivos> accesos_activos = new List<AccesosActivos>();
            SqlConnection conexion = ConexionBD.ObtenerInstancia().ObtenerConexion();

            string query = @"SELECT AccesoID, EmpleadoID, VisitanteID, ZonaID, FechaHoraEntrada  
                         FROM Accesos 
                         WHERE FechaHoraEntrada IS NOT NULL AND FechaHoraSalida IS NULL";

            using (SqlCommand cmd = new SqlCommand(query, conexion))
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    accesos_activos.Add(new AccesosActivos
                    {
                        AccesoID = reader.GetInt32(0),
                        EmpleadoID = reader.IsDBNull(1) ? null : (int?)reader.GetInt32(1),
                        VisitanteID = reader.IsDBNull(2) ? null : (int?)reader.GetInt32(2),
                        ZonaID = reader.IsDBNull(3) ? null : (int?)reader.GetInt32(3),
                        FechaHoraEntrada = reader.GetDateTime(4)
                    });
                }
            }

            ConexionBD.ObtenerInstancia().CerrarConexion();
            return accesos_activos;
        }
    }
}
