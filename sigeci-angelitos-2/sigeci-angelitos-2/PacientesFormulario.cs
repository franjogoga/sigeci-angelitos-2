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
    public partial class PacientesFormulario : Office2007Form
    {
        private ControladorPaciente controladorPaciente = ControladorPaciente.Instancia();
        private PacientesForm padre;
        private int modo;
        private Paciente paciente;

        public PacientesFormulario(PacientesForm pacientesForm, int modo, Paciente paciente)
        {
            this.paciente = paciente;
            InitializeComponent();
            this.padre = pacientesForm;
            this.modo = modo;
            if (modo == 2) //modificar
            {
                llenaFormularioPaciente(paciente);
            }
            if (modo == 1) //ver
            {
                llenaFormularioPaciente(paciente);
                bloqueaFormularioPaciente();
                btnAceptar.Enabled = false;
            }
            else
                btnAceptar.Enabled = true;       
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (modo == 0)
            {                                
                Persona persona = new Persona();
                persona.nombres = txtNombres.Text;
                persona.apellidoPaterno = txtApellidoPaterno.Text;
                persona.apellidoMaterno = txtApellidoMaterno.Text;
                persona.dni = int.Parse(txtDNI.Text);
                persona.estado = "activo";
                Paciente paciente = new Paciente();
                //paciente.numeroHistoria = int.Parse(txtNumeroHistoria.Text);
                paciente.fechaNacimiento = Convert.ToDateTime(dateFechaNacimiento.Text);
                paciente.lugarNacimiento = txtLugarNacimiento.Text;
                paciente.domicilio = txtDomicilio.Text;
                paciente.distrito = txtDistrito.Text;
                paciente.telefonoCasa = txtTelefonoCasa.Text;
                paciente.correo = txtCorreo.Text;
                paciente.comoEntero = txtComoEntero.Text;
                MenorEdad menorEdad = new MenorEdad();
                menorEdad.nombrePadre = txtNombrePadre.Text;
                menorEdad.nombreMadre = txtNombreMadre.Text;
                menorEdad.celularPadre = txtCelularPadre.Text;
                menorEdad.celularMadre = txtCelularMadre.Text;
                menorEdad.nombreColegio = txtNombreColegio.Text;
                menorEdad.ubicacionColegio = txtUbicacionColegio.Text;
                if (rbSi.Checked) menorEdad.escolaridad = "si"; else menorEdad.escolaridad = "no";
                MayorEdad mayorEdad = new MayorEdad();
                mayorEdad.celular = txtCelular.Text;
                mayorEdad.gradoInstruccion = txtGradoInstruccion.Text;
                mayorEdad.ocupacion = txtOcupacion.Text;
                mayorEdad.lugarLaboral = txtLugarLaboral.Text;
                paciente.persona = persona;
                paciente.menorEdad = menorEdad;
                paciente.mayorEdad = mayorEdad;
                
                if (controladorPaciente.agregarPaciente(paciente))
                {
                    MessageBox.Show("Paciente Agregado");
                    this.Dispose();
                    padre.llenarPacientes("","", "", "", "");
                }
                else
                    MessageBox.Show("Ha ocurrido un error");
            }
            else
            {
                

                if (controladorPaciente.modificarPaciente(paciente))
                {
                    MessageBox.Show("Paciente Modificado");
                    this.Dispose();
                    padre.llenarPacientes("","", "", "", "");
                }
                else
                    MessageBox.Show("Ha ocurrido un error");
            }
        }

        private void bloqueaFormularioPaciente()
        {
            txtNumeroHistoria.ReadOnly = true;
            txtNombres.ReadOnly = true;
            txtApellidoPaterno.ReadOnly = true;
            txtApellidoMaterno.ReadOnly = true;
            txtDNI.ReadOnly = true;
            txtLugarNacimiento.ReadOnly = true;
            dateFechaNacimiento.Enabled = false;
            txtDomicilio.ReadOnly = true;
            txtDistrito.ReadOnly = true;
            txtTelefonoCasa.ReadOnly = true;
            txtCorreo.ReadOnly = true;
            txtNombrePadre.ReadOnly = true;
            txtNombreMadre.ReadOnly = true;
            txtCelularPadre.ReadOnly = true;
            txtCelularMadre.ReadOnly = true;
            rbSi.Enabled = false;
            rbNo.Enabled = false;            
            txtNombreColegio.ReadOnly = true;
            txtUbicacionColegio.ReadOnly = true;
            txtCelular.ReadOnly = true;
            txtOcupacion.ReadOnly = true;
            txtGradoInstruccion.ReadOnly = true;
            txtLugarLaboral.ReadOnly = true;
        }

        private void llenaFormularioPaciente(Paciente paciente)
        {

        }

    }
}
