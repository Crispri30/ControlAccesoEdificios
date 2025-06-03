using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;


namespace ControlEdificios.Forms
{
    public partial class FormReporteAccesos : Form
    {
        private string connectionString = "Server=localhost\\SQLEXPRESS;Database=ControlEdificios;Trusted_Connection=True;TrustServerCertificate=True";
        public FormReporteAccesos()
        {
            InitializeComponent();
            CargarFiltros();
        }

        private void CargarFiltros()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // Cargar Personas
                SqlCommand cmdPersonas = new SqlCommand("SELECT DISTINCT Persona FROM Accesos", conn);
                SqlDataReader readerPersonas = cmdPersonas.ExecuteReader();
                cmbPersona.Items.Add("Todos");
                while (readerPersonas.Read())
                {
                    cmbPersona.Items.Add(readerPersonas.GetString(0));
                }
                readerPersonas.Close();
                cmbPersona.SelectedIndex = 0;

                // Cargar Zonas
                SqlCommand cmdZonas = new SqlCommand("SELECT DISTINCT Zona FROM Accesos", conn);
                SqlDataReader readerZonas = cmdZonas.ExecuteReader();
                cmbZona.Items.Add("Todos");
                while (readerZonas.Read())
                {
                    cmbZona.Items.Add(readerZonas.GetString(0));
                }
                readerZonas.Close();
                cmbZona.SelectedIndex = 0;

                // Cargar Roles
                SqlCommand cmdRoles = new SqlCommand("SELECT DISTINCT Rol FROM Accesos", conn);
                SqlDataReader readerRoles = cmdRoles.ExecuteReader();
                cmbRol.Items.Add("Todos");
                while (readerRoles.Read())
                {
                    cmbRol.Items.Add(readerRoles.GetString(0));
                }
                readerRoles.Close();
                cmbRol.SelectedIndex = 0;
            }
        }


        private void FormReporteAccesos_Load(object sender, EventArgs e)
        {

        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            string query = "SELECT Persona, Zona, FechaHora, Rol FROM Accesos WHERE 1=1";
            var parameters = new List<SqlParameter>();

            // Filtro por Persona
            if (cmbPersona.SelectedItem != null && cmbPersona.SelectedItem.ToString() != "Todos")
            {
                query += " AND Persona = @Persona";
                parameters.Add(new SqlParameter("@Persona", cmbPersona.SelectedItem.ToString()));
            }

            // Filtro por Zona
            if (cmbZona.SelectedItem != null && cmbZona.SelectedItem.ToString() != "Todos")
            {
                query += " AND Zona = @Zona";
                parameters.Add(new SqlParameter("@Zona", cmbZona.SelectedItem.ToString()));
            }

            // Filtro por Rol
            if (cmbRol.SelectedItem != null && cmbRol.SelectedItem.ToString() != "Todos")
            {
                query += " AND Rol = @Rol";
                parameters.Add(new SqlParameter("@Rol", cmbRol.SelectedItem.ToString()));
            }

            // Filtro por Fecha y Hora
            DateTime fechaDesde = dtpDesde.Value.Date + dtpHoraDesde.Value.TimeOfDay;
            DateTime fechaHasta = dtpHasta.Value.Date + dtpHoraHasta.Value.TimeOfDay;

            query += " AND FechaHora BETWEEN @FechaDesde AND @FechaHasta";
            parameters.Add(new SqlParameter("@FechaDesde", fechaDesde));
            parameters.Add(new SqlParameter("@FechaHasta", fechaHasta));

            // Ejecutar la consulta y cargar los resultados en el DataGridView
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddRange(parameters.ToArray());
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvReportes.DataSource = dt;
                }
            }
        }
    }
}
