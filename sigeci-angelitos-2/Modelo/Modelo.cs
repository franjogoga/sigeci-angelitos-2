﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Persona
    {
        private int _idPersona;
        private string _nombres;
        private string _apellidoPaterno;
        private string _apellidoMaterno;
        private int _dni;
        private string _estado;

        public int idPersona
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
        public string estado
        {
            get { return _estado; }
            set { _estado = value; }
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
        private List<Servicio> _servicios;
        private List<HorarioTerapeuta> _horarioTerapeuta;
        private DateTime _fechaNacimiento;
        private string _telefono;        

        public Persona persona
        {
            get { return _persona; }
            set { _persona = value; }
        }
        public List<Servicio> servicios
        {
            get { return _servicios; }
            set { _servicios = value; }
        }
        public List<HorarioTerapeuta> horarioTerapeuta
        {
            get { return _horarioTerapeuta; }
            set { _horarioTerapeuta = value; }
        }
        public DateTime fechaNacimiento
        {
            get { return _fechaNacimiento; }
            set { _fechaNacimiento = value; }
        }
        public string telefono
        {
            get { return _telefono; }
            set { _telefono = value; }
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
        private int _intervaloHora;
        private float _costo;
        private int _maximoPacientes;
        private string _estado;
        private List<Modalidad> _modalidades;

        public List<Modalidad> modalidades
        {
            get { return _modalidades; }
            set { _modalidades = value; }
        }
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
        public int maximoPacientes
        {
            get { return _maximoPacientes; }
            set { _maximoPacientes = value; }
        }
        public string estado
        {
            get { return _estado; }
            set { _estado = value; }
        }
    }

    public class Modalidad
    {
        private int _idModalidad;
        private string _nombreModalidad;
        private int _idServicio;
        private string _estado;

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
        public string estado
        {
            get { return _estado; }
            set { _estado = value; }
        }
    }

    public class Paciente
    {
        private Persona _persona;
        private MenorEdad _menorEdad;
        private MayorEdad _mayorEdad;
        private int _numeroHistoria;
        private DateTime _fechaNacimiento;
        private string _lugarNacimiento;
        private string _domicilio;
        private string _distrito;
        private string _telefonoCasa;        
        private string _correo;
        private string _comoEntero;
        private string _observacion;        

        public Persona persona
        {
            get { return _persona; }
            set { _persona = value; }
        }
        public MenorEdad menorEdad
        {
            get { return _menorEdad; }
            set { _menorEdad = value; }
        }
        public MayorEdad mayorEdad
        {
            get { return _mayorEdad; }
            set { _mayorEdad = value; }
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
        public string telefonoCasa
        {
            get { return _telefonoCasa; }
            set { _telefonoCasa = value; }
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
        public string observacion
        {
            get { return _observacion; }
            set { _observacion = value; }
        }      
    }

    public class MenorEdad
    {        
        private string _nombreMadre;
        private string _nombrePadre;
        private string _celularMadre;
        private string _celularPadre;
        private string _escolaridad;
        private string _nombreColegio;
        private string _ubicacionColegio;
        
        public string nombreMadre
        {
            get { return _nombreMadre; }
            set { _nombreMadre = value; }
        }
        public string nombrePadre
        {
            get { return _nombrePadre; }
            set { _nombrePadre = value; }
        }
        public string celularMadre
        {
            get { return _celularMadre; }
            set { _celularMadre = value; }
        }
        public string celularPadre
        {
            get { return _celularPadre; }
            set { _celularPadre = value; }
        }
        public string escolaridad
        {
            get { return _escolaridad; }
            set { _escolaridad = value; }
        }
        public string nombreColegio
        {
            get { return _nombreColegio; }
            set { _nombreColegio = value; }
        }
        public string ubicacionColegio
        {
            get { return _ubicacionColegio; }
            set { _ubicacionColegio = value; }
        }        
    }

    public class MayorEdad
    {
        private string _celular;
        private string _ocupacion;
        private string _gradoInstruccion;
        private string _lugarLaboral;

        public string celular
        {
            get { return _celular; }
            set { _celular = value; }
        }
        public string ocupacion
        {
            get { return _ocupacion; }
            set { _ocupacion = value; }
        }
        public string gradoInstruccion
        {
            get { return _gradoInstruccion; }
            set { _gradoInstruccion = value; }
        }
        public string lugarLaboral
        {
            get { return _lugarLaboral; }
            set { _lugarLaboral = value; }
        }
    }

    public class Cita
    {
        private int _idCita;
        private Persona _paciente;
        private DateTime _fechaCita;
        private DateTime _horaCita;
        private int _idServicio;
        private string _estado;
        private DateTime _fechaRegistro;
        private float _pago;
        private string _estadoEvaluacion;
        private Persona _terapeuta;

        public int idCita
        {
            get { return _idCita; }
            set { _idCita = value;}
        }
        public Persona paciente
        {
            get { return _paciente; }
            set { _paciente = value;}
        }
        public DateTime fechaCita
        {
            get { return _fechaCita; }
            set { _fechaCita = value;}
        }
        public DateTime horaCita
        {
            get { return _horaCita; }
            set { _horaCita = value;}
        }
        public int idServicio
        {
            get { return _idServicio; }
            set { _idServicio = value;}
        }
        public string estado
        {
            get { return _estado; }
            set { _estado = value;}
        }
        public DateTime fechaRegistro
        {
            get { return _fechaRegistro; }
            set { _fechaRegistro = value; }
        }
        public float pago
        {
            get { return _pago; }
            set { _pago = value; }
        }
        public string estadoEvaluacion
        {
            get { return _estadoEvaluacion; }
            set { _estadoEvaluacion = value; }
        }
        public Persona terapeuta
        {
            get { return _terapeuta; }
            set { _terapeuta = value; }
        }
    }
}
