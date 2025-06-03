using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControlEdificios.Utilidades;
using Microsoft.Data.SqlClient;


namespace ControlEdificios.Forms
{
    public partial class FormReporteAccesos : Form
    {
        public FormReporteAccesos()
        {
            InitializeComponent();
            CargarFiltros();
        }

        private void CargarFiltros()
        {
            using (var conn = ConexionBD.ObtenerInstancia().ObtenerConexion())
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();

                //  Personas (Empleados + Visitantes)
                cmbPersona.Items.Clear();
                cmbPersona.Items.Add("Todos");

                // Empleados
                using (SqlCommand cmdEmp = new SqlCommand("SELECT EmpleadoID, Nombre AS NombreCompleto FROM Empleados", conn))
                using (SqlDataReader readerEmp = cmdEmp.ExecuteReader())
                {
                    while (readerEmp.Read())
                    {
                        cmbPersona.Items.Add(readerEmp["NombreCompleto"].ToString());
                    }
                }

                // Visitantes
                using (SqlCommand cmdVis = new SqlCommand("SELECT VisitanteID, Nombre AS NombreCompleto FROM Visitantes", conn))
                using (SqlDataReader readerVis = cmdVis.ExecuteReader())
                {
                    while (readerVis.Read())
                    {
                        cmbPersona.Items.Add(readerVis["NombreCompleto"].ToString());
                    }
                }

                cmbPersona.SelectedIndex = 0;

                // Zonas 
                cmbZona.Items.Clear();
                cmbZona.Items.Add("Todos");

                using (SqlCommand cmdZona = new SqlCommand("SELECT NombreZona FROM Zonas", conn))
                using (SqlDataReader readerZona = cmdZona.ExecuteReader())
                {
                    while (readerZona.Read())
                    {
                        cmbZona.Items.Add(readerZona.GetString(0));
                    }
                }

                cmbZona.SelectedIndex = 0;

                // Rol (Empleado o Visitante)
                cmbRol.Items.Clear();
                cmbRol.Items.Add("Todos");
                cmbRol.Items.Add("Empleado");
                cmbRol.Items.Add("Visitante");
                cmbRol.SelectedIndex = 0;
            }
        }


        private void FormReporteAccesos_Load(object sender, EventArgs e)
        {

        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            using (var conn = ConexionBD.ObtenerInstancia().ObtenerConexion())
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();

                // Base de la consulta con joins
                string query = @"SELECT A.AccesoID, ISNULL(E.Nombre, V.Nombre) AS Persona,Z.NombreZona AS Zona,A.FechaHoraEntrada,A.FechaHoraSalida,
                                    CASE 
                                    WHEN A.EmpleadoID IS NOT NULL THEN 'Empleado'
                                    WHEN A.VisitanteID IS NOT NULL THEN 'Visitante'
                                    ELSE 'Desconocido'
                                    END AS Rol
                                    FROM Accesos A
                                    LEFT JOIN Empleados E ON A.EmpleadoID = E.EmpleadoID
                                    LEFT JOIN Visitantes V ON A.VisitanteID = V.VisitanteID
                                    LEFT JOIN Zonas Z ON A.ZonaID = Z.ZonasID
                                    WHERE A.FechaHoraEntrada BETWEEN @Desde AND @Hasta";

                // Parámetros para filtrar
                var parametros = new List<SqlParameter>
                {
                new SqlParameter("@Desde", dtpDesde.Value),
                new SqlParameter("@Hasta", dtpHasta.Value)
                };

                //  Filtro por persona 
                if (cmbPersona.SelectedItem.ToString() != "Todos")
                {
                    query += " AND (E.Nombre = @Persona OR V.Nombre = @Persona)";
                    parametros.Add(new SqlParameter("@Persona", cmbPersona.SelectedItem.ToString()));
                }

                //  Filtro por zona 
                if (cmbZona.SelectedItem.ToString() != "Todos")
                {
                    query += " AND Z.NombreZona = @Zona";
                    parametros.Add(new SqlParameter("@Zona", cmbZona.SelectedItem.ToString()));
                }

                // Filtro por rol 
                if (cmbRol.SelectedItem.ToString() == "Empleado")
                {
                    query += " AND A.EmpleadoID IS NOT NULL";
                }
                else if (cmbRol.SelectedItem.ToString() == "Visitante")
                {
                    query += " AND A.VisitanteID IS NOT NULL";
                }

                // Ejecutar consulta y llenar DataGridView
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddRange(parametros.ToArray());

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable tabla = new DataTable();
                        adapter.Fill(tabla);
                        dgvReportes.DataSource = tabla;
                    }
                }

                conn.Close();
            }
        }
    }
}
