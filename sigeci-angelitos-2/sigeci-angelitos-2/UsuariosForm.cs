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
    public partial class UsuariosForm : Office2007Form
    {
        private ControladorUsuario controladorUsuario = ControladorUsuario.Instancia();
        private List<Usuario> usuarios;
        private PrincipalForm principalForm;
        public UsuariosForm(PrincipalForm principalForm)
        {
            InitializeComponent();
            this.principalForm = principalForm;
        }

        private void UsuariosForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }

        private void btnNuevoUsuario_Click(object sender, EventArgs e)
        {
            UsuariosFormulario usuariosFormulario = new UsuariosFormulario();
            usuariosFormulario.ShowDialog();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string[] fila;
            usuarios = controladorUsuario.getListaUsuarios(txtUsername.Text, txtNombre.Text, txtApellidoPaterno.Text, txtApellidoMaterno.Text);
            dgvUsuarios.Rows.Clear();
            foreach(Usuario usuario in usuarios){
                fila = new string[] { ""+usuario.persona.idPersona, usuario.username, usuario.persona.nombres, usuario.persona.apellidoPaterno +" "+usuario.persona.apellidoMaterno, ""+usuario.persona.dni};
                dgvUsuarios.Rows.Add(fila);
            }
        }
    }
}
