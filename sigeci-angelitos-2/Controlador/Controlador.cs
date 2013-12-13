using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.IO;
using Modelo;

namespace Controlador
{
    public class ControladorUsuario
    {
        private string cadenaConexion = @"PROVIDER=Microsoft.ACE.OLEDB.12.0;Data Source=./Data/terapiaDB_desarrollo.accdb;Persist Security Info=True";               
        private List<Usuario> usuarios;
        static ControladorUsuario controladorUsuario = null;

        private ControladorUsuario()
        {            
            usuarios = new List<Usuario>();
        }

        static public ControladorUsuario Instancia()
        {
            if (controladorUsuario == null)
                controladorUsuario = new ControladorUsuario();
            return controladorUsuario;
        }

        public bool agregarUsuario(Usuario usuario)
        {
            bool resultado = true;
            int idPersona=0;
            OleDbDataReader r = null;
            int numFilas = 0;
            int numFilas2 = 0;

            OleDbConnection conexion = new OleDbConnection(cadenaConexion);

            OleDbCommand comando = new OleDbCommand("insert into persona(nombres,apellidoPaterno,apellidoMaterno,dni,estado) "+
                                                        "values(@nombres,@apellidoPaterno,@apellidoMaterno,@dni,@estado)");

            OleDbCommand comando2 = new OleDbCommand("SELECT TOP 1 * FROM persona order by idPersona DESC");

            OleDbCommand comando3 = new OleDbCommand("insert into usuario(persona_idPersona,username,pass) " +
                                                        "values(@persona_idPersona,@username,@pass)");
            
            comando.Parameters.AddRange(new OleDbParameter[]
            {
                new OleDbParameter("@nombres",usuario.persona.nombres),
                new OleDbParameter("@apellidoPaterno",usuario.persona.apellidoPaterno),
                new OleDbParameter("@apellidoMaterno",usuario.persona.apellidoMaterno),
                new OleDbParameter("@dni",usuario.persona.dni),
                new OleDbParameter("@estado",usuario.persona.estado),                
            });

            comando.Connection = conexion;
            comando2.Connection = conexion;
                        
            try
            {                
                conexion.Open();                
                numFilas = comando.ExecuteNonQuery();                
                r = comando2.ExecuteReader();                

                while (r.Read())
                {                    
                    idPersona = r.GetInt32(0);                                                        
                }

                comando3.Parameters.AddRange(new OleDbParameter[]
                {
                    new OleDbParameter("@persona_idPersona",idPersona),
                    new OleDbParameter("@username",usuario.username),
                    new OleDbParameter("@pass",usuario.password), 
                });
                                
                comando3.Connection = conexion;               
                numFilas2 = comando3.ExecuteNonQuery();

                Console.WriteLine("Usuario Insertado: " + numFilas2);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                Console.WriteLine("Error!");
            }
            finally {
                r.Close();
                conexion.Close(); 
            }
            resultado = numFilas + numFilas2 == 2;
            return resultado;
        }

        public List<Usuario> getListaUsuarios(string username, string nombres, string apellidoPaterno, string apellidoMaterno)
        {            
            OleDbDataReader r = null;
            OleDbConnection conexion = new OleDbConnection(cadenaConexion);

            OleDbCommand comando = new OleDbCommand("select * from persona, usuario where usuario.username like @username and persona.nombres like @nombres and persona.apellidoPaterno like @apellidoPaterno and persona.apellidoMaterno like @apellidoMaterno and persona.estado='activo' and persona.idPersona = usuario.persona_idPersona");

            comando.Parameters.AddRange(new OleDbParameter[]
            {
                new OleDbParameter("@username","*"+username+"*"),
                new OleDbParameter("@nombres","*"+nombres+"*"),
                new OleDbParameter("@apellidoPaterno","*"+apellidoPaterno+"*"),
                new OleDbParameter("@apellidoMaterno","*"+apellidoMaterno+"*"),                
            });

            comando.Connection = conexion;

            try
            {
                conexion.Open();
                r = comando.ExecuteReader();
                while (r.Read())
                {
                    Persona persona = new Persona();
                    persona.idPersona = r.GetInt32(0);
                    persona.nombres = r.GetString(1);
                    persona.apellidoPaterno = r.GetString(2);
                    persona.apellidoMaterno = r.GetString(3);
                    persona.dni = r.GetInt32(4);
                    persona.estado = r.GetString(5);
                    Usuario usuario = new Usuario();
                    usuario.persona = persona;
                    usuario.username = r.GetString(7);
                    usuario.password = r.GetString(8);

                    usuarios.Add(usuario);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());                
            }
            finally
            {
                r.Close();
                conexion.Close();
            }

            return usuarios;
        }


    }
}