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

namespace sigeci_angelitos_2
{
    public partial class PrincipalForm : Office2007Form
    {
        public PrincipalForm()
        {
            InitializeComponent();
        }

        private void PrincipalForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnCitas_Click(object sender, EventArgs e)
        {
            CitasForm citasForm = new CitasForm();
            citasForm.ShowDialog();
        }

        private void btnPacientes_Click(object sender, EventArgs e)
        {

        }

        private void btnServicios_Click(object sender, EventArgs e)
        {

        }

        private void btnTerapeutas_Click(object sender, EventArgs e)
        {

        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            UsuariosForm usuariosForm = new UsuariosForm(this);
            usuariosForm.ShowDialog();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {

        }
    }
}
