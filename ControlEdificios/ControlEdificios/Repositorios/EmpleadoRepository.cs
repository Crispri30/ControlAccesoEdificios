using Microsoft.Data.SqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControlEdificios.Modelos;
using ControlEdificios.Utilidades;
using System.Data;


namespace ControlEdificios.Repositorios
{
    public class EmpleadoRepository
    {
        //CRUD

        //Agregar Empleados
        public void AgregarEmpleado(int empleadoID, string nombre, RolEmpleado rol)
        {
            var conexion = ConexionBD.ObtenerInstancia().ObtenerConexion();

            using (SqlCommand verificar = new SqlCommand("SELECT COUNT (*) FROM Empleados WHERE EmpleadoID = @EmpleadoID", conexion))
            {
                verificar.Parameters.AddWithValue("@EmpleadoID", empleadoID);
                
                int cant = (int)verificar.ExecuteScalar();
                if (cant > 0) {
                    MessageBox.Show("Ya existe un empleado con este ID");
                }
            } 

            using (SqlCommand cmd = new SqlCommand("INSERT INTO Empleados (EmpleadoID,Nombre, Rol) VALUES (@EmpleadoID,@Nombre, @Rol)", conexion))
            {
                cmd.Parameters.AddWithValue("@EmpleadoID", empleadoID);
                cmd.Parameters.AddWithValue("@Nombre", nombre);
                cmd.Parameters.AddWithValue("@Rol", rol.ToString());
                cmd.ExecuteNonQuery();
            }

            using (SqlCommand proc = new SqlCommand ("SP_AsignarZona", conexion))
            {
                proc.CommandType = System.Data.CommandType.StoredProcedure;

                proc.Parameters.AddWithValue("@EmpleadoID", empleadoID);
                proc.Parameters.AddWithValue("@Rol", rol.ToString());

                proc.ExecuteNonQuery();
            }
            ConexionBD.ObtenerInstancia().CerrarConexion();
        }

        //Obtener Empleados
        public List<Modelos.Empleados> ObtenerEmpleados()
        {
            List<Modelos.Empleados> listaEmpleados = new List<Modelos.Empleados>();

            SqlConnection conexion = ConexionBD.ObtenerInstancia().ObtenerConexion();

            using (SqlCommand cmd = new SqlCommand("SELECT EmpleadoID, Nombre, Rol FROM Empleados", conexion))
            using (SqlDataReader reader = cmd.ExecuteReader())
            {

                while (reader.Read())
                {
                    listaEmpleados.Add(new Modelos.Empleados
                    {
                        EmpleadoID = reader.GetInt32(0),
                        Nombre = reader.GetString(1),
                        Rol = Enum.Parse<RolEmpleado>(reader.GetString(2))
                    });
                }
            }

            ConexionBD.ObtenerInstancia().CerrarConexion();

            return listaEmpleados;
        }

        //Actualizar Empleados
        public void ActualizarEmpleado(int empleadoID, string nombre, RolEmpleado rol)
        {
            var conexion = ConexionBD.ObtenerInstancia().ObtenerConexion();

            using (SqlCommand cmd = new SqlCommand("UPDATE Empleados SET Nombre=@Nombre, Rol=@Rol WHERE EmpleadoID=@EmpleadoID ", conexion))
            {
                cmd.Parameters.AddWithValue("@EmpleadoID", empleadoID);
                cmd.Parameters.AddWithValue("@Nombre", nombre);
                cmd.Parameters.AddWithValue("@Rol", rol.ToString());

                int filas_afectadas = cmd.ExecuteNonQuery();

                if (filas_afectadas == 0)
                {
                    MessageBox.Show("El empleado no existe");
                }
                else
                {
                    MessageBox.Show("Empleado actualizado correctamente");
                }
            }

            using (SqlCommand proc = new SqlCommand("SP_AsignarZona", conexion))
            {
                proc.CommandType = System.Data.CommandType.StoredProcedure;

                proc.Parameters.AddWithValue("@EmpleadoID", empleadoID);
                proc.Parameters.AddWithValue("@Rol", rol.ToString());

                proc.ExecuteNonQuery();
            }
            ConexionBD.ObtenerInstancia().CerrarConexion();

        }

        //Eliminar Empleado
        public void EliminarEmpleado(int empleadoID)
        {
            var conexion = ConexionBD.ObtenerInstancia().ObtenerConexion();
            using (SqlCommand cmd = new SqlCommand("DELETE FROM Empleados WHERE EmpleadoID = @ID", conexion))
            {
                cmd.Parameters.AddWithValue("@ID", empleadoID);

                int filas_afectadas = cmd.ExecuteNonQuery();

                if (filas_afectadas == 0)
                {
                    MessageBox.Show("El empleado no existe");
                }
                else
                {
                    MessageBox.Show("Empleado eliminado correctamente");
                }
            }
            ConexionBD.ObtenerInstancia().ObtenerConexion();
        }

        //Metodo para registrar el acceso del empleado
        public string RegistrarAccesoEmpleado(int empleadoID, int zonaID)
        {

            if (!TieneAcceso(empleadoID, zonaID))
            {
                return "Acceso denegado: no tiene permiso para entrar a esta zona";
            }

            if (!HorarioPermitido(zonaID))
            {
                return "Acceso denegado: fuera de horario permitido";
            }

            SqlConnection conexion = ConexionBD.ObtenerInstancia().ObtenerConexion();

            //Crear objeto SqlCommand indicando el nombre del procedimiento almacenado
            using (SqlCommand cmd = new SqlCommand("Sp_RegistrarAcceso", conexion))
            {
                //Indicar a SqlCommand que voy a utlizar un procedimiento almacenado
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                //Agregar parametros que el procedimiento almacenado va recibir
                cmd.Parameters.AddWithValue("@EmpleadoID", empleadoID);
                cmd.Parameters.AddWithValue("@VisitanteID", DBNull.Value);
                cmd.Parameters.AddWithValue("@ZonaID", zonaID);

                SqlParameter mensajeParam = new SqlParameter("@Mensaje", SqlDbType.NVarChar, 100)
                {
                    Direction = ParameterDirection.Output
                };
                cmd.Parameters.Add(mensajeParam);

                //Ejecutar el comando en la base de datos sin esperar un resultado
                cmd.ExecuteNonQuery();

                ConexionBD.ObtenerInstancia().CerrarConexion();

                return mensajeParam.Value.ToString();
            }

            
        }

        private bool TieneAcceso(int empleadoID, int zonaID)
        {
            SqlConnection conexion = ConexionBD.ObtenerInstancia().ObtenerConexion();

            using (SqlCommand cmd =  new SqlCommand ("SELECT COUNT (*) FROM EmpleadoZonas WHERE EmpleadoID = @EmpleadoID AND ZonasID = @ZonasID", conexion))
            {
                cmd.Parameters.AddWithValue("@EmpleadoID", empleadoID);
                cmd.Parameters.AddWithValue("@ZonasID", zonaID);

                int count = (int)cmd.ExecuteScalar();

                ConexionBD.ObtenerInstancia().CerrarConexion();
                return (count > 0);
            }
        }

        private bool HorarioPermitido(int zonaID)
        {
            SqlConnection conexion = ConexionBD.ObtenerInstancia().ObtenerConexion();

            using (SqlCommand cmd = new SqlCommand ("SELECT HoraInicio, HoraFin FROM Zonas WHERE ZonasID = @ZonasID ", conexion))
            {
                cmd.Parameters.AddWithValue("@ZonasID", zonaID);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read()) 
                    {
                        TimeSpan horaInicio = reader.GetTimeSpan(0);
                        TimeSpan horaFin = reader.GetTimeSpan(1);
                        TimeSpan ahora = DateTime.Now.TimeOfDay;

                        ConexionBD.ObtenerInstancia().CerrarConexion();
                        return ahora >= horaInicio && ahora <= horaFin;
                    }
                } 
            }
            ConexionBD.ObtenerInstancia().CerrarConexion();
            return false;

        }
    }
}
