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


namespace ControlEdificios.Forms
{
    public partial class FormRegistrarAcceso : Form
    {
        public FormRegistrarAcceso()
        {
            InitializeComponent();
        }

        private void bttAcceso_Click(object sender, EventArgs e)
        {
            int empleadoID = int.Parse(txtEmpleadoID.Text);
            int zonaID = int.Parse(txtZonaID.Text);

            var repo = new EmpleadoRepository();
            string resultado = repo.RegistrarAccesoEmpleado(empleadoID, zonaID);

            MessageBox.Show(resultado);

            txtEmpleadoID.Clear();
            txtZonaID.Clear();
        }
    }
}
