using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Usuario
    {
        private string _idUsuario;
        private string _nombres;
        private string _apellidoPaterno;
        private string _apellidoMaterno;
        private int _dni;
        private string _username;
        private string _password;

        public string idUsuario 
        {
            get {return _idUsuario;}
            set {_idUsuario = value;}
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
        private string nombres;
        private string apellidoPaterno;
        private string apellidoMaterno;
        private int dni;
        
    }
}
