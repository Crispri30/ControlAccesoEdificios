using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControlEdificios.Modelos;
using ControlEdificios.Repositorios;

namespace ControlAccesoPrueba.Forms
{
    public partial class FormSeguridad : Form
    {
        public FormSeguridad()
        {
            InitializeComponent();
        }

        private void FormSeguridad_Load(object sender, EventArgs e)
        {
            CargarAccesosActivos();
        }

        private void timerMonitoreo_Tick(object sender, EventArgs e)
        {
            CargarAccesosActivos();
        }

        private void CargarAccesosActivos()
        {
            try
            {
                List<AccesosActivos> accesos = SeguridadRepository.ObtenerAccesosActivos();
                dgvAccesosActivos.DataSource = accesos;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar accesos activos: " + ex.Message);
            }
        }

        private void dgvAccesosActivos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
