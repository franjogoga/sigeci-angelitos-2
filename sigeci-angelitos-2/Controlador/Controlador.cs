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
            int idPersona=0,numFilas = 0, numFilas2 = 0;
            OleDbDataReader r = null;            
            usuarios.Clear();

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
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());                
            }
            finally {
                r.Close();
                conexion.Close(); 
            }            
            return numFilas + numFilas2 == 2;
        }

        public List<Usuario> getListaUsuarios(string username, string nombres, string apellidoPaterno, string apellidoMaterno)
        {
            usuarios.Clear();
            OleDbDataReader r = null;
            OleDbConnection conexion = new OleDbConnection(cadenaConexion);

            OleDbCommand comando = new OleDbCommand("select * from persona, usuario where usuario.username like @username and persona.nombres like @nombres and persona.apellidoPaterno like @apellidoPaterno and persona.apellidoMaterno like @apellidoMaterno and persona.estado='activo' and persona.idPersona = usuario.persona_idPersona order by persona.idPersona ASC");

            comando.Parameters.AddRange(new OleDbParameter[]
            {
                new OleDbParameter("@username","%"+username+"%"),
                new OleDbParameter("@nombres","%"+nombres+"%"),
                new OleDbParameter("@apellidoPaterno","%"+apellidoPaterno+"%"),
                new OleDbParameter("@apellidoMaterno","%"+apellidoMaterno+"%"),                
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

        public bool modificarUsuario(Usuario usuario)
        {            
            int numFilas = 0, numFilas2 = 0;
            usuarios.Clear();
            OleDbConnection conexion = new OleDbConnection(cadenaConexion);
            OleDbCommand comando = new OleDbCommand("update persona set nombres=@nombres,apellidoPaterno=@apellidoPaterno,apellidoMaterno=@apellidoMaterno,dni=@dni " +
                                                    "where idPersona=@idPersona");
            OleDbCommand comando2 = new OleDbCommand("update usuario set username=@username,pass=@pass " +
                                                        "where persona_idPersona=@persona_idPersona");

            comando.Parameters.AddRange(new OleDbParameter[]
            {
                new OleDbParameter("@nombres",usuario.persona.nombres),
                new OleDbParameter("@apellidoPaterno",usuario.persona.apellidoPaterno),
                new OleDbParameter("@apellidoMaterno",usuario.persona.apellidoMaterno),
                new OleDbParameter("@dni",usuario.persona.dni),
                new OleDbParameter("@idPersona",usuario.persona.idPersona),                
            });

            comando2.Parameters.AddRange(new OleDbParameter[]
            {
                new OleDbParameter("@username",usuario.username),
                new OleDbParameter("@pass",usuario.password),                
                new OleDbParameter("@persona_idPersona",usuario.persona.idPersona),                
            });

            comando.Connection = conexion;
            comando2.Connection = conexion;

            try
            {
                conexion.Open();
                numFilas = comando.ExecuteNonQuery();
                numFilas2 = comando2.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                conexion.Close(); 
            }            
            return numFilas + numFilas2 == 2;
        }

        public bool eliminarUsuario(Usuario usuario)
        {            
            int numFilas = 0;
            usuarios.Clear();
            OleDbConnection conexion = new OleDbConnection(cadenaConexion);
            OleDbCommand comando = new OleDbCommand("update persona set estado=@estado " +
                                                    "where idPersona=@idPersona");

            comando.Parameters.AddRange(new OleDbParameter[]
            {
                new OleDbParameter("@estado","inactivo"),
                new OleDbParameter("@idPersona",usuario.persona.idPersona),                               
            });

            comando.Connection = conexion;

            try
            {
                conexion.Open();
                numFilas = comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                conexion.Close();
            }            
            return numFilas == 1;
        }
    }

    public class ControladorPaciente
    {
        private string cadenaConexion = @"PROVIDER=Microsoft.ACE.OLEDB.12.0;Data Source=./Data/terapiaDB_desarrollo.accdb;Persist Security Info=True";               
        private List<Paciente> pacientes;
        static ControladorPaciente controladorPaciente = null;

        private ControladorPaciente()
        {            
            pacientes = new List<Paciente>();
        }

        static public ControladorPaciente Instancia()
        {
            if (controladorPaciente == null)
                controladorPaciente = new ControladorPaciente();
            return controladorPaciente;
        }

        public List<Paciente> getListaPacientes(string strHistoria, string strDNI, string nombres, string apellidoPaterno, string apellidoMaterno)
        {
            pacientes.Clear();
            OleDbDataReader r = null;
            OleDbConnection conexion = new OleDbConnection(cadenaConexion);
            string hist = "", dn = "";
            int numeroHistoria=0, dni=0;

            if (!strHistoria.Equals(""))
            {
                hist = " and paciente.numeroHistoria = @numeroHistoria";
                numeroHistoria = int.Parse(strHistoria);
            }
            if (!strDNI.Equals(""))
            {
                dn = " and persona.dni = @dni";
                dni = int.Parse(strDNI);
            }
            
            OleDbCommand comando = new OleDbCommand("select * from persona, paciente, menorEdad, mayorEdad where persona.idPersona = paciente.persona_idPersona and paciente.persona_idPersona = menorEdad.paciente_persona_idPersona and paciente.persona_idPersona = mayorEdad.paciente_persona_idPersona and  persona.nombres like @nombres and persona.apellidoPaterno like @apellidoPaterno and persona.apellidoMaterno like @apellidoMaterno and persona.estado like 'activo' "+hist+dn+" order by paciente.numeroHistoria ASC");

            comando.Parameters.AddRange(new OleDbParameter[]
            {                
                new OleDbParameter("@nombres","%"+nombres+"%"),
                new OleDbParameter("@apellidoPaterno","%"+apellidoPaterno+"%"),
                new OleDbParameter("@apellidoMaterno","%"+apellidoMaterno+"%"),
            });

            if (!strHistoria.Equals("")) 
            {
                comando.Parameters.AddWithValue("@numeroHistoria", numeroHistoria);
            }
            if (!strDNI.Equals(""))
            {
                comando.Parameters.AddWithValue("@dni", dni);
            }

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
                    Paciente paciente = new Paciente();
                    paciente.numeroHistoria = r.GetInt32(7);
                    paciente.fechaNacimiento = r.GetDateTime(8);
                    paciente.lugarNacimiento = r.GetString(9);
                    paciente.domicilio = r.GetString(10);
                    paciente.distrito = r.GetString(11);
                    paciente.telefonoCasa = r.GetString(12);
                    paciente.correo = r.GetString(13);
                    paciente.comoEntero = r.GetString(14);
                    paciente.observacion = r.GetString(15);
                    MenorEdad menorEdad = new MenorEdad();
                    menorEdad.nombreMadre = r.GetString(17);
                    menorEdad.nombrePadre = r.GetString(18);
                    menorEdad.celularMadre = r.GetString(19);
                    menorEdad.celularPadre = r.GetString(20);
                    menorEdad.escolaridad = r.GetString(21);
                    menorEdad.nombreColegio = r.GetString(22);
                    menorEdad.ubicacionColegio = r.GetString(23);
                    MayorEdad mayorEdad = new MayorEdad();
                    mayorEdad.celular = r.GetString(25);
                    mayorEdad.ocupacion = r.GetString(26);
                    mayorEdad.gradoInstruccion = r.GetString(27);
                    mayorEdad.lugarLaboral = r.GetString(28);
                    paciente.persona = persona;
                    paciente.menorEdad = menorEdad;
                    paciente.mayorEdad = mayorEdad;

                    pacientes.Add(paciente);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                r.Close();
                conexion.Close();
            }
            return pacientes;
        }

        public bool agregarPaciente(Paciente paciente)
        {            
            int idPersona = 0, numeroHistoria =0,numFilas1 = 0, numFilas2 = 0, numFilas3=0, numFilas4=0;
            OleDbDataReader r = null;            
            pacientes.Clear();

            OleDbConnection conexion = new OleDbConnection(cadenaConexion);

            OleDbCommand comando = new OleDbCommand("insert into persona(nombres,apellidoPaterno,apellidoMaterno,dni,estado) " +
                                                        "values(@nombres,@apellidoPaterno,@apellidoMaterno,@dni,@estado)");

            OleDbCommand comando2 = new OleDbCommand("SELECT TOP 1 * FROM persona order by idPersona DESC");
            OleDbCommand comando4 = new OleDbCommand("SELECT TOP 1 * FROM paciente order by persona_idPersona DESC");

            OleDbCommand comando3 = new OleDbCommand("insert into paciente(persona_idPersona,numeroHistoria,fechaNacimiento,lugarNacimiento,domicilio,distrito,telefonoCasa,correo,comoEntero,observacion) " +
                                                        "values(@persona_idPersona,@numeroHistoria,@fechaNacimiento,@lugarNacimiento,@domicilio,@distrito,@telefonoCasa,@correo,@comoEntero,@observacion)");


            OleDbCommand comando5 = new OleDbCommand("insert into menorEdad(paciente_persona_idPersona,nombreMadre,nombrePadre,celularMadre,celularPadre,escolaridad,nombreColegio,ubicacionColegio) " +
                                                        "values(@paciente_persona_idPersona,@nombreMadre,@nombrePadre,@celularMadre,@celularPadre,@escolaridad,@nombreColegio,@ubicacionColegio)");

            OleDbCommand comando6 = new OleDbCommand("insert into mayorEdad(paciente_persona_idPersona,celular,ocupacion,gradoInstruccion,lugarLaboral) " +
                                                        "values(@paciente_persona_idPersona,@celular,@ocupacion,@gradoInstruccion,@lugarLaboral)");

            comando.Parameters.AddRange(new OleDbParameter[]
            {
                new OleDbParameter("@nombres",paciente.persona.nombres),
                new OleDbParameter("@apellidoPaterno",paciente.persona.apellidoPaterno),
                new OleDbParameter("@apellidoMaterno",paciente.persona.apellidoMaterno),
                new OleDbParameter("@dni",paciente.persona.dni),
                new OleDbParameter("@estado",paciente.persona.estado),                
            });

            comando.Connection = conexion;
            comando2.Connection = conexion;
            comando4.Connection = conexion;
            try
            {
                conexion.Open();
                numFilas1 = comando.ExecuteNonQuery();
                r = comando2.ExecuteReader();

                while (r.Read())
                {
                    idPersona = r.GetInt32(0);
                }

                r = comando4.ExecuteReader();
                while (r.Read())
                {
                    numeroHistoria = r.GetInt32(1)+1;
                }

                comando3.Parameters.AddRange(new OleDbParameter[]
                {
                    new OleDbParameter("@persona_idPersona",idPersona),
                    new OleDbParameter("@numeroHistoria",numeroHistoria),
                    new OleDbParameter("@fechaNacimiento",paciente.fechaNacimiento),
                    new OleDbParameter("@lugarNacimiento",paciente.lugarNacimiento),
                    new OleDbParameter("@domicilio",paciente.domicilio),
                    new OleDbParameter("@distrito",paciente.distrito),
                    new OleDbParameter("@telefonoCasa",paciente.telefonoCasa),                    
                    new OleDbParameter("@correo",paciente.correo), 
                    new OleDbParameter("@comoEntero",paciente.comoEntero),
                    new OleDbParameter("@observacion","-"),
                });
        
                comando5.Parameters.AddRange(new OleDbParameter[]
                {
                    new OleDbParameter("@paciente_persona_idPersona",idPersona),
                    new OleDbParameter("@nombreMadre",paciente.menorEdad.nombreMadre),
                    new OleDbParameter("@nombrePadre",paciente.menorEdad.nombrePadre),
                    new OleDbParameter("@celularMadre",paciente.menorEdad.celularMadre),
                    new OleDbParameter("@celularPadre",paciente.menorEdad.celularPadre),
                    new OleDbParameter("@escolaridad",paciente.menorEdad.escolaridad),
                    new OleDbParameter("@nombreColegio",paciente.menorEdad.nombreColegio),
                    new OleDbParameter("@ubicacionColegio",paciente.menorEdad.ubicacionColegio),
                });
                
                comando6.Parameters.AddRange(new OleDbParameter[]
                {
                    new OleDbParameter("@paciente_persona_idPersona",idPersona),
                    new OleDbParameter("@celular",paciente.mayorEdad.celular),
                    new OleDbParameter("@ocupacion",paciente.mayorEdad.ocupacion),
                    new OleDbParameter("@gradoInstruccion",paciente.mayorEdad.gradoInstruccion),
                    new OleDbParameter("@lugarLaboral",paciente.mayorEdad.lugarLaboral),
                });
                
                comando3.Connection = conexion;
                comando5.Connection = conexion;
                comando6.Connection = conexion;

                numFilas2 = comando3.ExecuteNonQuery();
                numFilas3 = comando5.ExecuteNonQuery();
                numFilas4 = comando6.ExecuteNonQuery();
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
            return numFilas1 + numFilas2 + numFilas3 + numFilas4 == 4;
        }

        public bool modificarPaciente(Paciente paciente)
        {            
            int numFilas1 = 0, numFilas2 = 0, numFilas3=0, numFilas4=0;
            pacientes.Clear();
            OleDbConnection conexion = new OleDbConnection(cadenaConexion);
            OleDbCommand comando1 = new OleDbCommand("update persona set nombres=@nombres,apellidoPaterno=@apellidoPaterno,apellidoMaterno=@apellidoMaterno,dni=@dni " +
                                                    "where idPersona=@idPersona");
            OleDbCommand comando2 = new OleDbCommand("update paciente set fechaNacimiento=@fechaNacimiento,lugarNacimiento=@lugarNacimiento,domicilio=@domicilio,distrito=@distrito,telefonoCasa=@telefonoCasa,correo=@correo,comoEntero=@comoEntero " +
                                                        "where persona_idPersona=@persona_idPersona");
            OleDbCommand comando3 = new OleDbCommand("update menorEdad set nombreMadre=@nombreMadre,nombrePadre=@nombrePadre,celularMadre=@celularMadre,celularPadre=@celularPadre,escolaridad=@escolaridad,nombreColegio=@nombreColegio,ubicacionColegio=@ubicacionColegio " +
                                                        "where paciente_persona_idPersona=@paciente_persona_idPersona");
            OleDbCommand comando4 = new OleDbCommand("update mayorEdad set celular=@celular,ocupacion=@ocupacion,gradoInstruccion=@gradoInstruccion,lugarLaboral=@lugarLaboral " +
                                                        "where paciente_persona_idPersona=@paciente_persona_idPersona");
            comando1.Parameters.AddRange(new OleDbParameter[]
            {
                new OleDbParameter("@nombres",paciente.persona.nombres),
                new OleDbParameter("@apellidoPaterno",paciente.persona.apellidoPaterno),
                new OleDbParameter("@apellidoMaterno",paciente.persona.apellidoMaterno),
                new OleDbParameter("@dni",paciente.persona.dni),
                new OleDbParameter("@idPersona",paciente.persona.idPersona),                
            });
                    
            comando2.Parameters.AddRange(new OleDbParameter[]
            {
                new OleDbParameter("@fechaNacimiento",paciente.fechaNacimiento),
                new OleDbParameter("@lugarNacimiento",paciente.lugarNacimiento),                
                new OleDbParameter("@domicilio",paciente.domicilio),
                new OleDbParameter("@distrito",paciente.distrito),
                new OleDbParameter("@telefonoCasa",paciente.telefonoCasa),                
                new OleDbParameter("@correo",paciente.correo),
                new OleDbParameter("@comoEntero",paciente.comoEntero),
                new OleDbParameter("@persona_idPersona",paciente.persona.idPersona),
            });
            
            comando3.Parameters.AddRange(new OleDbParameter[]
            {
                new OleDbParameter("@nombreMadre",paciente.menorEdad.nombreMadre),
                new OleDbParameter("@nombrePadre",paciente.menorEdad.nombrePadre),                
                new OleDbParameter("@celularMadre",paciente.menorEdad.celularMadre),
                new OleDbParameter("@celularPadre",paciente.menorEdad.celularPadre),
                new OleDbParameter("@escolaridad",paciente.menorEdad.escolaridad),
                new OleDbParameter("@nombreColegio",paciente.menorEdad.nombreColegio),
                new OleDbParameter("@ubicacionColegio",paciente.menorEdad.ubicacionColegio),                
                new OleDbParameter("@paciente_persona_idPersona",paciente.persona.idPersona),
            });
            
            comando4.Parameters.AddRange(new OleDbParameter[]
            {
                new OleDbParameter("@celular",paciente.mayorEdad.celular),
                new OleDbParameter("@ocupacion",paciente.mayorEdad.ocupacion),                
                new OleDbParameter("@gradoInstruccion",paciente.mayorEdad.gradoInstruccion),
                new OleDbParameter("@lugarLaboral",paciente.mayorEdad.lugarLaboral),                
                new OleDbParameter("@paciente_persona_idPersona",paciente.persona.idPersona),
            });

            comando1.Connection = conexion;
            comando2.Connection = conexion;
            comando3.Connection = conexion;
            comando4.Connection = conexion;

            try
            {
                conexion.Open();
                numFilas1 = comando1.ExecuteNonQuery();
                numFilas2 = comando2.ExecuteNonQuery();
                numFilas3 = comando3.ExecuteNonQuery();
                numFilas4 = comando4.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                conexion.Close();
            }            
            return numFilas1 + numFilas2 + numFilas3 + numFilas4== 4;
        }

        public bool eliminarPaciente(Paciente paciente)
        {            
            int numFilas = 0;
            pacientes.Clear();
            OleDbConnection conexion = new OleDbConnection(cadenaConexion);
            OleDbCommand comando = new OleDbCommand("update persona set estado=@estado " +
                                                    "where idPersona=@idPersona");

            comando.Parameters.AddRange(new OleDbParameter[]
            {
                new OleDbParameter("@estado","inactivo"),
                new OleDbParameter("@idPersona",paciente.persona.idPersona),                               
            });

            comando.Connection = conexion;

            try
            {
                conexion.Open();
                numFilas = comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                conexion.Close();
            }           
            return numFilas == 1;
        }
    }

    public class ControladorTerapeuta
    {
        private string cadenaConexion = @"PROVIDER=Microsoft.ACE.OLEDB.12.0;Data Source=./Data/terapiaDB_desarrollo.accdb;Persist Security Info=True";               
        private List<Terapeuta> terapeutas;
        static ControladorTerapeuta controladorTerapeuta = null;

        private ControladorTerapeuta()
        {            
            terapeutas = new List<Terapeuta>();
        }

        static public ControladorTerapeuta Instancia()
        {
            if (controladorTerapeuta == null)
                controladorTerapeuta = new ControladorTerapeuta();
            return controladorTerapeuta;
        }

        public List<Terapeuta> getListaTerapeutas(string nombres, string apellidoPaterno, string apellidoMaterno, string strDNI)
        {
            string dn = "";
            int dni = 0;
            terapeutas.Clear();
            OleDbDataReader r = null;
            OleDbConnection conexion = new OleDbConnection(cadenaConexion);

            if (!strDNI.Equals(""))
            {
                dn = " and persona.dni = @dni";
                dni = int.Parse(strDNI);
            }

            OleDbCommand comando = new OleDbCommand("select * from persona, terapeuta where persona.nombres like @nombres and persona.apellidoPaterno like @apellidoPaterno and persona.apellidoMaterno like @apellidoMaterno and persona.estado='activo' and "+dn+" persona.idPersona = terapeuta.persona_idPersona order by persona.idPersona ASC");

            comando.Parameters.AddRange(new OleDbParameter[]
            {
                new OleDbParameter("@nombres","%"+nombres+"%"),               
                new OleDbParameter("@apellidoPaterno","%"+apellidoPaterno+"%"),
                new OleDbParameter("@apellidoMaterno","%"+apellidoMaterno+"%"),                
            });

            if (!strDNI.Equals(""))
            {
                comando.Parameters.AddWithValue("@dni", dni);
            }

            comando.Connection = conexion;

            try
            {
                conexion.Open();
                r = comando.ExecuteReader();
                while (r.Read())
                {
                    Persona persona = new Persona();
                    List<Servicio> serviciosxTerapeuta = new List<Servicio>();
                    ControladorServicio controladorServicio = ControladorServicio.Instancia();
                    persona.idPersona = r.GetInt32(0);
                    serviciosxTerapeuta = controladorServicio.getListaServiciosxTerapeuta(persona.idPersona);                    
                    persona.nombres = r.GetString(1);
                    persona.apellidoPaterno = r.GetString(2);
                    persona.apellidoMaterno = r.GetString(3);
                    persona.dni = r.GetInt32(4);
                    persona.estado = r.GetString(5);
                    Terapeuta terapeuta = new Terapeuta();
                    terapeuta.persona = persona;
                    terapeuta.fechaNacimiento = r.GetDateTime(7);
                    terapeuta.telefono = r.GetString(8);
                    terapeuta.servicios = serviciosxTerapeuta;

                    terapeutas.Add(terapeuta);
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
            return terapeutas;
        }

        public bool agregarTerapeuta(Terapeuta terapeuta)
        {
            int idPersona = 0, numFilas = 0, numFilas2 = 0, numFilas4=0;
            OleDbDataReader r = null;
            terapeutas.Clear();

            OleDbConnection conexion = new OleDbConnection(cadenaConexion);

            OleDbCommand comando = new OleDbCommand("insert into persona(nombres,apellidoPaterno,apellidoMaterno,dni,estado) " +
                                                        "values(@nombres,@apellidoPaterno,@apellidoMaterno,@dni,@estado)");

            OleDbCommand comando2 = new OleDbCommand("SELECT TOP 1 * FROM persona order by idPersona DESC");

            OleDbCommand comando3 = new OleDbCommand("insert into terapeuta(persona_idPersona,fechaNacimiento,telefono) " +
                                                        "values(@persona_idPersona,@fechaNacimiento,@telefono)");                        

            comando.Parameters.AddRange(new OleDbParameter[]
            {
                new OleDbParameter("@nombres",terapeuta.persona.nombres),
                new OleDbParameter("@apellidoPaterno",terapeuta.persona.apellidoPaterno),
                new OleDbParameter("@apellidoMaterno",terapeuta.persona.apellidoMaterno),
                new OleDbParameter("@dni",terapeuta.persona.dni),
                new OleDbParameter("@estado",terapeuta.persona.estado),                
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
                    new OleDbParameter("@fechaNacimiento",terapeuta.fechaNacimiento),
                    new OleDbParameter("@telefono",terapeuta.telefono), 
                });                

                comando3.Connection = conexion;

                numFilas2 = comando3.ExecuteNonQuery();

                foreach (Servicio s in terapeuta.servicios)
                {
                    OleDbCommand comando4 = new OleDbCommand("insert into servicioxterapeuta(idServicio,persona_idPersona) " +
                                                        "values(@idServicio,@persona_idPersona)");

                    comando4.Parameters.AddRange(new OleDbParameter[]
                    {
                        new OleDbParameter("@idServicio",s.idServicio),
                        new OleDbParameter("@persona_idPersona",idPersona),                                                
                    });
                    comando4.Connection = conexion;
                    numFilas4 = numFilas4 + comando4.ExecuteNonQuery();
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
            return numFilas + numFilas2 == 2 && terapeuta.servicios.Count == numFilas4;
        }

        public bool modificarTerapeuta(Terapeuta terapeuta)
        {
            int numFilas = 0, numFilas2 = 0;
            terapeutas.Clear();
            OleDbConnection conexion = new OleDbConnection(cadenaConexion);
            OleDbCommand comando = new OleDbCommand("update persona set nombres=@nombres,apellidoPaterno=@apellidoPaterno,apellidoMaterno=@apellidoMaterno,dni=@dni " +
                                                    "where idPersona=@idPersona");
            OleDbCommand comando2 = new OleDbCommand("update terapeuta set fechaNacimiento=@fechaNacimiento,telefono=@telefono " +
                                                        "where persona_idPersona=@persona_idPersona");

            comando.Parameters.AddRange(new OleDbParameter[]
            {
                new OleDbParameter("@nombres",terapeuta.persona.nombres),
                new OleDbParameter("@apellidoPaterno",terapeuta.persona.apellidoPaterno),
                new OleDbParameter("@apellidoMaterno",terapeuta.persona.apellidoMaterno),
                new OleDbParameter("@dni",terapeuta.persona.dni),
                new OleDbParameter("@idPersona",terapeuta.persona.idPersona),                
            });

            comando2.Parameters.AddRange(new OleDbParameter[]
            {
                new OleDbParameter("@fechaNacimiento",terapeuta.fechaNacimiento),
                new OleDbParameter("@telefono",terapeuta.telefono),                
                new OleDbParameter("@persona_idPersona",terapeuta.persona.idPersona),                
            });

            comando.Connection = conexion;
            comando2.Connection = conexion;

            try
            {
                conexion.Open();
                numFilas = comando.ExecuteNonQuery();
                numFilas2 = comando2.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                conexion.Close();
            }
            return numFilas + numFilas2 == 2;
        }

        public bool eliminarTerapeuta(Terapeuta terapeuta)
        {
            int numFilas = 0;
            terapeutas.Clear();
            OleDbConnection conexion = new OleDbConnection(cadenaConexion);
            OleDbCommand comando = new OleDbCommand("update persona set estado=@estado " +
                                                    "where idPersona=@idPersona");

            comando.Parameters.AddRange(new OleDbParameter[]
            {
                new OleDbParameter("@estado","inactivo"),
                new OleDbParameter("@idPersona",terapeuta.persona.idPersona),                               
            });

            comando.Connection = conexion;

            try
            {
                conexion.Open();
                numFilas = comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                conexion.Close();
            }
            return numFilas == 1;
        }
    }

    public class ControladorServicio
    {
        private string cadenaConexion = @"PROVIDER=Microsoft.ACE.OLEDB.12.0;Data Source=./Data/terapiaDB_desarrollo.accdb;Persist Security Info=True";               
        private List<Servicio> servicios;
        static ControladorServicio controladorServicio = null;

        private ControladorServicio()
        {            
            servicios = new List<Servicio>();
        }

        static public ControladorServicio Instancia()
        {
            if (controladorServicio == null)
                controladorServicio= new ControladorServicio();
            return controladorServicio;
        }

        public List<Servicio> getListaServiciosxTerapeuta(int idTerapeuta)
        {
            List<Servicio> serviciosxTerapeuta = new List<Servicio>();
            OleDbDataReader r = null;
            OleDbConnection conexion = new OleDbConnection(cadenaConexion);

            OleDbCommand comando = new OleDbCommand("SELECT * from servicio, terapeuta, servicioxterapeuta where servicio.idServicio = servicioxterapeuta.idServicio and  servicioxterapeuta.persona_idPersona = terapeuta.persona_idPersona and terapeuta.persona_idPersona = @idTerapeuta order by servicio.idServicio ASC");

            comando.Parameters.AddRange(new OleDbParameter[]
            {
                new OleDbParameter("@idTerapeuta", idTerapeuta),
            });

            comando.Connection = conexion;

            try
            {
                conexion.Open();
                r = comando.ExecuteReader();
                while (r.Read())
                {
                    Servicio servicio = new Servicio();
                    servicio.idServicio = r.GetInt32(0);
                    servicio.nombreServicio = r.GetString(1);                    

                    serviciosxTerapeuta.Add(servicio);
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
            return serviciosxTerapeuta;
        }

        public List<Servicio> getListaServicios(string nombreServicio)
        {
            servicios.Clear();
            OleDbDataReader r = null;
            OleDbConnection conexion = new OleDbConnection(cadenaConexion);

            OleDbCommand comando = new OleDbCommand("select * from servicio where nombreServicio like @nombreServicio and estado='activo' order by idServicio ASC");

            comando.Parameters.AddRange(new OleDbParameter[]
            {
                new OleDbParameter("@nombreServicio","%" + nombreServicio + "%"),                
            });

            comando.Connection = conexion;

            try
            {
                conexion.Open();
                r = comando.ExecuteReader();
                while (r.Read())
                {
                    Servicio servicio = new Servicio();
                    servicio.idServicio = r.GetInt32(0);
                    servicio.nombreServicio = r.GetString(1);
                    servicio.intervaloHora = r.GetInt32(2);
                    servicio.costo = r.GetInt32(3);
                    servicio.maximoPacientes = r.GetInt32(4);
                    servicio.estado = r.GetString(5);                    

                    servicios.Add(servicio);
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
            return servicios;            
        }

        public bool agregarServicio(Servicio servicio)
        {                                
            int numFilas = 0;            
            servicios.Clear();

            OleDbConnection conexion = new OleDbConnection(cadenaConexion);

            OleDbCommand comando = new OleDbCommand("insert into servicio(nombreServicio,intervaloHora,costo,maximoPacientes,estado) " +
                                                        "values(@nombreServicio,@intervaloHora,@costo,@maximoPacientes,@estado)");            

            comando.Parameters.AddRange(new OleDbParameter[]
            {
                new OleDbParameter("@nombreServicio",servicio.nombreServicio),
                new OleDbParameter("@intervaloHora",servicio.intervaloHora),
                new OleDbParameter("@costo",servicio.costo),
                new OleDbParameter("@maximoPacientes",servicio.maximoPacientes),
                new OleDbParameter("@estado",servicio.estado),                
            });

            comando.Connection = conexion;            

            try
            {
                conexion.Open();
                numFilas = comando.ExecuteNonQuery();                                                
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            finally
            {                
                conexion.Close();
            }            
            return numFilas == 1;
        }

        public bool modificarServicio(Servicio servicio)
        {            
            int numFilas = 0;         
            servicios.Clear();
            OleDbConnection conexion = new OleDbConnection(cadenaConexion);
            OleDbCommand comando = new OleDbCommand("update servicio set nombreServicio=@nombreServicio,intervaloHora=@intervaloHora,costo=@costo,maximoPacientes=@maximoPacientes " +
                                                    "where idServicio=@idServicio");            

            comando.Parameters.AddRange(new OleDbParameter[]
            {
                new OleDbParameter("@nombreServicio",servicio.nombreServicio),
                new OleDbParameter("@intervaloHora",servicio.intervaloHora),
                new OleDbParameter("@costo",servicio.costo),
                new OleDbParameter("@maximoPacientes",servicio.maximoPacientes),
                new OleDbParameter("@idServicio",servicio.idServicio),                
            });
         
            comando.Connection = conexion;            

            try
            {
                conexion.Open();
                numFilas = comando.ExecuteNonQuery();                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                conexion.Close();
            }
            return numFilas == 1;
        }

        public bool eliminarServicio(Servicio servicio)
        {            
            int numFilas = 0;
            servicios.Clear();
            OleDbConnection conexion = new OleDbConnection(cadenaConexion);
            OleDbCommand comando = new OleDbCommand("update servicio set estado=@estado " +
                                                    "where idServicio=@idServicio");

            comando.Parameters.AddRange(new OleDbParameter[]
            {
                new OleDbParameter("@estado","inactivo"),
                new OleDbParameter("@idServicio",servicio.idServicio),
            });

            comando.Connection = conexion;

            try
            {
                conexion.Open();
                numFilas = comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                conexion.Close();
            }      
            return numFilas == 1;
        }

    }

}