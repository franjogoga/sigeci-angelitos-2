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
using Modelo;
using Controlador;

namespace sigeci_angelitos_2
{
    public partial class TerapeutaForm : Office2007Form
    {
        private ControladorTerapeuta controladorTerapeuta = ControladorTerapeuta.Instancia();
        private List<Terapeuta> terapeutas;
        public TerapeutaForm()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        public void llenarTerapeutas(string nombres, string apellidoPaterno, string apellidoMaterno, string strDNI)
        {
            string[] fila;
            terapeutas = controladorTerapeuta.getListaTerapeutas(nombres, apellidoPaterno, apellidoMaterno, strDNI);
            dgvTerapeutas.Rows.Clear();
            foreach (Terapeuta terapeuta in terapeutas)
            {
                fila = new string[] { "" + usuario.persona.idPersona, usuario.username, usuario.persona.nombres, usuario.persona.apellidoPaterno + " " + usuario.persona.apellidoMaterno, "" + usuario.persona.dni };
                dgvTerapeutas.Rows.Add(fila);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            llenarTerapeutas(txtNombres.Text,txtApellidoPaterno.Text, txtApellidoMaterno.Text,txtDNI.Text);            
        }

        private void dgvTerapeutas_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }
    }
}
