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
                Console.WriteLine(cadenaConexion);
                conexion.Open();
                Console.WriteLine("Conexion hecha");
                numFilas = comando.ExecuteNonQuery();
                Console.WriteLine("Usuario Insertado: "+ numFilas);
                r = comando2.ExecuteReader();
                Console.WriteLine("Seleccionar Usuario: ");

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
                conexion.Close(); 
            }
            resultado = numFilas + numFilas2 == 2;
            return resultado;
        }




    }
}