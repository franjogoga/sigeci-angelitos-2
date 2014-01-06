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
    public partial class CitasFornulario : Office2007Form
    {
        private ControladorServicio controladorServicio = ControladorServicio.Instancia();
        private ControladorTerapeuta controladorTerapeuta = ControladorTerapeuta.Instancia();
        private ControladorModalidad controladorModalidad = ControladorModalidad.Instancia();
        private List<Terapeuta> terapeutas;
        private List<Servicio> servicios;
        private List<Turno> turnos;
        private List<Modalidad> modalidades;
        private Paciente paciente; 

        public CitasFornulario()
        {
            InitializeComponent();
            llenarServicios();
            llenarTurnos();            
        }

        private void btnBuscarPaciente_Click(object sender, EventArgs e)
        {
            BusquedaPacienteForm busquedaPacientesForm = new BusquedaPacienteForm(this);
            busquedaPacientesForm.ShowDialog();
        }

        public void llenarServicios()
        {
            servicios = controladorServicio.getListaServicios("");            
            comboServicios.DataSource = servicios;
            comboServicios.DisplayMember = "nombreServicio";
            comboServicios.ValueMember = "idServicio";            
        }

        public void llenarPaciente(Paciente paciente)
        {
            this.paciente = paciente;
            txtNumeroHistoria.Text = ""+paciente.numeroHistoria;
            txtNombres.Text = paciente.persona.nombres;
            txtApellidoPaterno.Text = paciente.persona.apellidoPaterno;
            txtApellidoMaterno.Text = paciente.persona.apellidoMaterno;
            txtDNI.Text = ""+paciente.persona.dni;            
        }

        public void llenarTurnos()
        {
            turnos = new List<Turno>();
            Turno turno0 = new Turno();
            turno0.idTurno = 0;
            turno0.nombreTurno = "Mañana";            
            Turno turno1 = new Turno();
            turno1.idTurno = 1;
            turno1.nombreTurno = "Tarde";

            turnos.Add(turno0);
            turnos.Add(turno1);

            comboTurno.DataSource = turnos;
            comboTurno.DisplayMember = "nombreTurno";
            comboTurno.ValueMember = "idTurno";            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void llenarTerapeutas(int idServicio)
        {
            terapeutas = controladorTerapeuta.getListaTerapeutasxServicio(idServicio);
            comboTerapeuta.Items.Clear();
            comboTerapeuta.DisplayMember = "nombres";
            comboTerapeuta.ValueMember = "idPersona";

            foreach (Terapeuta t in terapeutas)
            {
                comboTerapeuta.Items.Add(new { nombres = t.persona.nombres+" "+t.persona.apellidoPaterno+" "+t.persona.apellidoMaterno, idPersona = t.persona.idPersona });
            }
        }

        private void llenarModalidades(int idServicio)
        {
            modalidades = controladorModalidad.getListaModalidadesxServicio("", idServicio);
            comboModalidad.Items.Clear();                        
            comboModalidad.DisplayMember = "nombreModalidad";
            comboModalidad.ValueMember = "idModalidad";

            foreach (Modalidad m in modalidades)
            {
                comboModalidad.Items.Add(new { nombreModalidad = m.nombreModalidad, idModalidad=m.idModalidad});
            }
        }

        private void comboServicios_SelectedIndexChanged(object sender, EventArgs e)
        {            
            Servicio s = new Servicio();
            s = comboServicios.SelectedItem as Servicio;
            llenarTerapeutas(s.idServicio);            
            llenarModalidades(s.idServicio);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

        }

    }
}

