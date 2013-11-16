using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Persona
    {
        private string _idPersona;
        private string _nombres;
        private string _apellidoPaterno;
        private string _apellidoMaterno;
        private int _dni;

        public string idPersona
        {
            get { return _idPersona; }
            set { _idPersona = value; }
        }
        public string nombres
        {
            get { return _nombres; }
            set { _nombres = value; }
        }
        public string apellidoPaterno
        {
            get { return _apellidoPaterno; }
            set { _apellidoPaterno = value; }
        }
        public string apellidoMaterno
        {
            get { return _apellidoMaterno; }
            set { _apellidoMaterno = value; }
        }
        public int dni
        {
            get { return _dni; }
            set { _dni = value; }
        }
    }

    public class Usuario
    {
        private Persona _persona;
        private string _username;
        private string _password;

        public Persona persona
        {
            get { return _persona; }
            set { _persona = value; }
        }
        public string username
        {
            get { return _username; }
            set { _username = value; }
        }
        public string password
        {
            get { return _password; }
            set { _password = value; }
        }
    }
    
    public class Terapeuta
    {
        private Persona _persona;
        private DateTime _fechaNacimiento;

        public Persona persona
        {
            get { return _persona; }
            set { _persona = value; }
        }
        public DateTime fechaNacimiento
        {
            get { return _fechaNacimiento; }
            set { _fechaNacimiento = value; }
        }
    }

    public class HorarioTerapeuta
    {
        private int _idHorarioTerapeuta;
        private DateTime _horaInicio;
        private DateTime _horaFin;
        private string _dia;
        private int _idPersona;

        public int idHorarioTerapeuta
        {
            get { return _idHorarioTerapeuta; }
            set { _idHorarioTerapeuta = value; }
        }
        public DateTime horaInicio
        {
            get { return _horaInicio; }
            set { _horaInicio = value; }
        }
        public DateTime horaFin
        {
            get { return _horaFin; }
            set { _horaFin = value; }
        }
        public string dia
        {
            get { return _dia; }
            set { _dia = value; }
        }
        public int idPersona
        {
            get { return _idPersona; }
            set { _idPersona = value; }
        }
    }

    public class Servicio
    {
        private int _idServicio;
        private string _nombreServicio;
        private int _esGrupal;
        private int _idPersona;
        private int _intervaloHora;
        private float _costo;

        public int idServicio
        {
            get { return _idServicio; }
            set { _idServicio = value; }
        }
        public string nombreServicio
        {
            get { return _nombreServicio; }
            set { _nombreServicio = value; }
        }
        public int esGrupal
        {
            get { return _esGrupal; }
            set { _esGrupal = value; }
        }
        public int idPersona
        {
            get { return _idPersona; }
            set { _idPersona = value; }
        }
        public int intervaloHora
        {
            get { return _intervaloHora; }
            set { _intervaloHora = value; }
        }
        public float costo
        {
            get { return _costo; }
            set { _costo = value; }
        }
    }

    public class Modalidad
    {
        private int _idModalidad;
        private string _nombreModalidad;
        private int _idServicio;

        public int idModalidad
        {
            get { return _idModalidad; }
            set { _idModalidad = value; }
        }
        public string nombreModalidad
        {
            get { return _nombreModalidad; }
            set { _nombreModalidad = value; }
        }
        public int idServicio
        {
            get { return _idServicio; }
            set { _idServicio = value; }
        }        
    }

    public class Paciente
    {
        private Persona _persona;
        private int _numeroHistoria;
        private DateTime _fechaNacimiento;
        private string _lugarNacimiento;
        private string _domicilio;
        private string _distrito;
        private int _telefonoCasa;
        private int _celular;
        private string _correo;
        private string _comoEntero;
        private string _obs;        

        public Persona persona
        {
            get { return _persona; }
            set { _persona = value; }
        }
        public int numeroHistoria
        {
            get { return _numeroHistoria; }
            set { _numeroHistoria = value; }
        }
        public DateTime fechaNacimiento 
        {
            get { return _fechaNacimiento; }
            set { _fechaNacimiento= value; }
        }
        public string lugarNacimiento
        {
            get { return _lugarNacimiento; }
            set { _lugarNacimiento = value; }
        }
        public string domicilio
        {
            get { return _domicilio; }
            set { _domicilio = value; }
        }
        public string distrito
        {
            get { return _distrito; }
            set { _distrito = value; }
        }
        public int telefonoCasa
        {
            get { return _telefonoCasa; }
            set { _telefonoCasa = value; }
        }
        public int celular
        {
            get { return _celular; }
            set { _celular= value; }
        }
        public string correo
        {
            get { return _correo; }
            set { _correo = value; }
        }
        public string comoEntero
        {
            get { return _comoEntero; }
            set { _comoEntero = value; }
        }
        public string obs
        {
            get { return _obs; }
            set { _obs = value; }
        }      
    }

    
}
