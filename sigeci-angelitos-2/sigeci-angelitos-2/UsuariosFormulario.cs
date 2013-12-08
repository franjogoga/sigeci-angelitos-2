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
    public partial class UsuariosFormulario : Office2007Form
    {
        private ControladorUsuario controladorUsuario = ControladorUsuario.Instancia();

        public UsuariosFormulario()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            Persona persona = new Persona();
            persona.nombres = txtNombres.Text;
            persona.apellidoPaterno = txtApellidoPaterno.Text;
            persona.apellidoMaterno = txtApellidoMaterno.Text;
            persona.dni = int.Parse(txtDNI.Text);
            persona.estado = "activo";
            usuario.persona = persona;
            usuario.username = txtUsername.Text;
            usuario.password = txtPassword.Text;            

            if (controladorUsuario.agregarUsuario(usuario))
            {
                MessageBox.Show("Usuario Agregado");
                this.Dispose();
            }
            else
                MessageBox.Show("Ha ocurrido un error");
        }
    }
}
