using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Negocio;

namespace Presentacion
{
    public partial class frmMedico : Form
    {
        public frmMedico()
        {
            InitializeComponent();
        }
        private void MostrarMedicos()
        {
            GridMedicos.DataSource = AdmMedico.Listar();
        }

        private void btinsertar_Click(object sender, EventArgs e)
        {
            Medico medico = new Medico() { Nombre = txtnombre.Text, Apellido = txtapellido.Text, Domicilio = txtdomicilio.Text, Telefono = Convert.ToInt32(txttelefono.Text), Email = txtemail.Text, Especialidad = txtespecialidad.Text, Matricula = Convert.ToInt32(txtmatricula.Text), };
            int filasAfectadas = AdmMedico.Insertar(medico);
            if (filasAfectadas > 0)
            {
                MessageBox.Show("Insert Ok");
                MostrarMedicos();
            }
        }

        private void frmMedico_Load(object sender, EventArgs e)
        {
            MostrarMedicos();
        }

        private void btid_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtid.Text);

            Medico medico = AdmMedico.TraerUno(id);
            MessageBox.Show(Convert.ToString("Nombre: " + medico.Nombre + "\nApellido: " + medico.Apellido + "\nDomicilio: " + medico.Domicilio + "\nTelefono: " + medico.Telefono + "\nEmail: " + medico.Email + "\nEspecialidad: " + medico.Especialidad + "\nMatricula: " + medico.Matricula));
        }

        private void bteliminar_Click(object sender, EventArgs e)
        {
            Medico medico = new Medico() { Id = Convert.ToInt32(txtid.Text) };

            int filasAfectadas = AdmMedico.Eliminar(medico.Id);

            if (filasAfectadas > 0)
            {
                MessageBox.Show("Delete ok");
                MostrarMedicos();
            }
        }
    }
}
