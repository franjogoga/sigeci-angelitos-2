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
    public partial class TerapeutaFormulario : Office2007Form
    {
        private ControladorTerapeuta controladorTerapeuta = ControladorTerapeuta.Instancia();
        private TerapeutaForm padre;
        private int modo;
        private Terapeuta terapeuta;

        public TerapeutaFormulario(TerapeutaForm terapeutaForm, int modo, Terapeuta terapeuta)
        {
            InitializeComponent();
            this.terapeuta = terapeuta;
            this.padre = terapeutaForm;
            this.modo = modo;
            if (modo == 2) //modificar
            {
                llenaFormularioTerapeuta(terapeuta);
            }
            if (modo == 1) //ver
            {
                llenaFormularioTerapeuta(terapeuta);
                bloqueaFormularioTerapeuta();
                btnAceptar.Enabled = false;
            }
            else
                btnAceptar.Enabled = true;
        }

        private void llenaFormularioTerapeuta(Terapeuta terapeuta)
        {
            txtNombres.Text = terapeuta.persona.nombres;
            txtApellidoPaterno.Text = terapeuta.persona.apellidoPaterno;
            txtApellidoMaterno.Text = terapeuta.persona.apellidoMaterno;
            dateFechaNacimiento.Text = ""+terapeuta.fechaNacimiento;
            txtDNI.Text = ""+terapeuta.persona.dni;
            txtTelefono.Text = terapeuta.telefono;
        }

        private void bloqueaFormularioTerapeuta()
        {
            txtNombres.ReadOnly = true;
            txtApellidoPaterno.ReadOnly = true;
            txtApellidoMaterno.ReadOnly = true;
            dateFechaNacimiento.Enabled = false;
            txtDNI.ReadOnly = true;
            txtTelefono.ReadOnly = true;
        }
    }
}
