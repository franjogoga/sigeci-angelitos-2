using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using DevComponents.DotNetBar;
using Controlador;
using Modelo;

namespace sigeci_angelitos_2
{
    public partial class PacientesForm : Office2007Form
    {
        private ControladorPaciente controladorPaciente = ControladorPaciente.Instancia();
        private List<Paciente> pacientes;
        public PacientesForm()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            PacientesFormulario pacientesFormulario = new PacientesFormulario();
            pacientesFormulario.ShowDialog();
        }

        private void PacientesForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }

        public void llenarPacientes(string strHistoriaClinica, string strDNI, string nombres, string apellidoPaterno, string apellidoMaterno)
        {
            string[] fila;
            pacientes = controladorPaciente.getListaPacientes(strHistoriaClinica, strDNI, nombres, apellidoPaterno, apellidoMaterno);
            dgvPacientes.Rows.Clear();
            foreach (Paciente paciente in pacientes)
            {
                fila = new string[] { ""+paciente.numeroHistoria, paciente.persona.nombres, paciente.persona.apellidoPaterno+" "+paciente.persona.apellidoMaterno, ""+paciente.persona.dni, paciente.telefonoCasa};
                dgvPacientes.Rows.Add(fila);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            llenarPacientes(txtHistoriaClinica.Text, txtDNI.Text, txtNombres.Text, txtApellidoPaterno.Text, txtApellidoMaterno.Text);
        }


    }
}
