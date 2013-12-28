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
        private List<Servicio> servicios;

        public TerapeutaFormulario(TerapeutaForm terapeutaForm, int modo, Terapeuta terapeuta, List<Servicio> servicios)
        {
            InitializeComponent();
            this.terapeuta = terapeuta;
            this.padre = terapeutaForm;
            this.servicios = servicios;
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

            foreach (Servicio s in terapeuta.servicios) {
                checkListServicios.Items.Add(s.nombreServicio, true);
            }            
        }

        private void bloqueaFormularioTerapeuta()
        {
            txtNombres.ReadOnly = true;
            txtApellidoPaterno.ReadOnly = true;
            txtApellidoMaterno.ReadOnly = true;
            dateFechaNacimiento.Enabled = false;
            txtDNI.ReadOnly = true;
            txtTelefono.ReadOnly = true;
            checkListServicios.Enabled = false;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (modo == 0)
            {
                Terapeuta terapeuta = new Terapeuta();                                
                Persona persona = new Persona();
                persona.nombres = txtNombres.Text;
                persona.apellidoPaterno = txtApellidoPaterno.Text;
                persona.apellidoMaterno = txtApellidoMaterno.Text;
                persona.dni = int.Parse(txtDNI.Text);
                persona.estado = "activo";
                terapeuta.persona = persona;
                terapeuta.fechaNacimiento = Convert.ToDateTime(dateFechaNacimiento.Text);
                terapeuta.telefono = txtTelefono.Text;

                if (controladorTerapeuta.agregarTerapeuta(terapeuta))
                {
                    MessageBox.Show("Terapeuta Agregado");
                    this.Dispose();
                    padre.llenarTerapeutas("", "", "", "");
                }
                else
                    MessageBox.Show("Ha ocurrido un error");
            }
            else
            {                
                terapeuta.persona.nombres = txtNombres.Text;
                terapeuta.persona.apellidoPaterno = txtApellidoPaterno.Text;
                terapeuta.persona.apellidoMaterno = txtApellidoMaterno.Text;
                terapeuta.persona.dni = int.Parse(txtDNI.Text);                                
                terapeuta.fechaNacimiento = Convert.ToDateTime(dateFechaNacimiento.Text);
                terapeuta.telefono = txtTelefono.Text;

                if (controladorTerapeuta.modificarTerapeuta(terapeuta))
                {
                    MessageBox.Show("Terapeuta Modificado");
                    this.Dispose();
                    padre.llenarTerapeutas("", "", "", "");
                }
                else
                    MessageBox.Show("Ha ocurrido un error");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
