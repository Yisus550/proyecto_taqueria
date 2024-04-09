using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using MySql.Data.MySqlClient;

namespace proyecto_pos
{
    internal class Usuario
    {
        int clave;
        String nombre;
        String apellidoPaterno;
        String apellidoMaterno;
        String correo;
        String usuario;
        String password;
        String telefono;
        String perfil;
        DateTime fechaRegistro;
        int estado;

        private String buscarUsuarioSQL = "SELECT * FROM `usuarios` WHERE usuario = @usuario AND contrasena = @password;";
        private String insertarSQL = "insert into usuarios(nombre, apellido_paterno, apellido_materno, correo, usuario, contrasena, fecha_registro, perfil, estatus, telefono) " +
            "values(@nombre, @apellido_paterno, @apellido_materno, @correo, @usuario, @contrasena, @fecha_registro, @perfil, @estatus, @telefono)";
        private String buscarClaveSQL = "SELECT * FROM `usuarios` WHERE id=@clave;";
        private String actualizarUsuarioSQL = "UPDATE usuarios SET nombre = @nombre, apellido_paterno = @apellido_paterno, apellido_materno = @apellido_materno, correo = @correo, " + 
            "usuario = @usuario, contrasena = @contrasena, fecha_registro = @fecha_registro, perfil = @perfil, estatus = @estatus, telefono = @telefono WHERE id = @clave;";

        MySqlConnection connection = new MySqlConnection("Server=localhost;Database=punto_venta;User=root;Password=;");

        public void setClave(int clave)
        {
            this.clave = clave;
        }

        public int getClave()
        {
            return clave;
        }

        public void setNombre(String nombre)
        {
            this.nombre = nombre;
        }

        public String getNombre()
        {
            return nombre;
        }

        public void setApellidoPaterno(String apellidoPaterno)
        {
            this.apellidoPaterno = apellidoPaterno;
        }

        public String getApellidoPaterno()
        {
            return apellidoPaterno;
        }

        public void setApellidoMaterno(String apellidoMaterno)
        {
            this.apellidoMaterno = apellidoMaterno;
        }

        public String getApellidoMaterno()
        {
            return apellidoMaterno;
        }

        public void setCorreo(String correo)
        {
            this.correo = correo;
        }

        public String getCorreo()
        {
            return correo;
        }

        public void setUsuario(String usuario)
        {
            this.usuario = usuario;
        }

        public String getUsuario()
        {
            return usuario;
        }

        public void setPassword(String password)
        {
            this.password = password;
        }

        public String getPasswprd()
        {
            return password;
        }

        public void setTelefono(String telefono)
        {
            this.telefono = telefono;
        }

        public String getTelefono()
        {
            return telefono;
        }

        public void setFechaRegistro(DateTime fechaRegistro)
        {
            this.fechaRegistro = fechaRegistro;
        }

        public DateTime getFechaRegistro()
        {
            return fechaRegistro;
        }

        public void setEstado(int estado)
        {
            this.estado = estado;
        }

        public int getEstado()
        {
            return estado;
        }

        public void setPerfil(String perfil)
        {
            this.perfil = perfil;
        }

        public String getPerfil()
        {
            return perfil;
        }

        public int buscarUsuario()
        {
            int numRegistros = 0;
            try
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand();
                command.Connection = connection;
                command.CommandText = buscarUsuarioSQL;
                command.Parameters.Add("@usuario", MySqlDbType.String).Value = getUsuario();
                command.Parameters.Add("@password", MySqlDbType.String).Value = getPasswprd();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    numRegistros++;
                    reader.NextResult();
                }
            } 
            catch (MySqlException e)
            {
                MessageBox.Show(e.Message, "ERROR!");
            }
            finally
            {
                connection.Close();
            }
            return numRegistros;
        }

        public int insertarUsuario()
        {
            int numRegistros = 0;
            try
            {
                connection.Open();
                MySqlCommand comandoSQL = new MySqlCommand();
                comandoSQL.Connection = connection;
                comandoSQL.CommandText = insertarSQL;
                comandoSQL.Parameters.Add("@nombre", MySqlDbType.String).Value = getNombre();
                comandoSQL.Parameters.Add("@apellido_paterno", MySqlDbType.String).Value = getApellidoPaterno();
                comandoSQL.Parameters.Add("@apellido_materno", MySqlDbType.String).Value = getApellidoMaterno();
                comandoSQL.Parameters.Add("@correo", MySqlDbType.String).Value = getCorreo();
                comandoSQL.Parameters.Add("@usuario", MySqlDbType.String).Value = getUsuario();
                comandoSQL.Parameters.Add("@contrasena", MySqlDbType.String).Value = getPasswprd();
                comandoSQL.Parameters.Add("@fecha_registro", MySqlDbType.DateTime).Value = getFechaRegistro();
                comandoSQL.Parameters.Add("@perfil", MySqlDbType.String).Value = getPerfil();
                comandoSQL.Parameters.Add("@estatus", MySqlDbType.Int16).Value = getEstado();
                comandoSQL.Parameters.Add("@telefono", MySqlDbType.String).Value = getTelefono();

                numRegistros = comandoSQL.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "Error al insertar registro");
            }
            finally
            {
                connection.Close();
            }
            return numRegistros;
        }

        public void buscarClave()
        {
            try
            {
                connection.Open();
                MySqlCommand commandoSQL = new MySqlCommand();
                commandoSQL.Connection = connection;
                commandoSQL.CommandText = buscarClaveSQL;
                commandoSQL.Parameters.Add("@clave", MySqlDbType.Int32).Value = getClave();

                MySqlDataReader reader = commandoSQL.ExecuteReader();

                while(reader.Read())
                {
                    setNombre(reader.GetString(1));
                    setApellidoPaterno(reader.GetString(2));
                    setApellidoMaterno(reader.GetString(3));
                    setCorreo(reader.GetString(4));
                    setUsuario(reader.GetString(5));
                    setPassword(reader.GetString(6));
                    setFechaRegistro(reader.GetDateTime(7));
                    setPerfil(reader.GetString(8));
                    setEstado(reader.GetInt32(9));
                    setTelefono(reader.GetString(10));

                    reader.NextResult();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "Error al buscar usuario");
            }
            finally
            {
                connection.Close();
            }
        }

        public int actualizarUsuario()
        {
            int numRegistros = 0;
            try
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand();
                command.Connection = connection;
                command.CommandText = actualizarUsuarioSQL;
                command.Parameters.Add("@nombre", MySqlDbType.String).Value = getNombre();
                command.Parameters.Add("@apellido_paterno", MySqlDbType.String).Value = getApellidoPaterno();
                command.Parameters.Add("@apellido_materno", MySqlDbType.String).Value = getApellidoMaterno();
                command.Parameters.Add("@correo", MySqlDbType.String).Value = getCorreo();
                command.Parameters.Add("@usuario", MySqlDbType.String).Value = getUsuario();
                command.Parameters.Add("@contrasena", MySqlDbType.String).Value = getPasswprd();
                command.Parameters.Add("@fecha_registro", MySqlDbType.DateTime).Value = getFechaRegistro();
                command.Parameters.Add("@perfil", MySqlDbType.String).Value = getPerfil();
                command.Parameters.Add("@estatus", MySqlDbType.Int16).Value = getEstado();
                command.Parameters.Add("@telefono", MySqlDbType.String).Value = getTelefono();
                command.Parameters.Add("@calve", MySqlDbType.Int32).Value = getClave(); 

                numRegistros = command.ExecuteNonQuery();
            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.Message + " Error code: " + e.ErrorCode, "Error al actualizar usuario");
            }
            finally
            {
                connection.Close();
            }
            return numRegistros;
        }
    }
}
