using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace minimarket.datos
{
    public class Conexion
    {
        private string Base;
        private string Servidor;
        private string Usuario;
        private string clave;
        private bool Seguridad;
        private static Conexion con = null;

        private Conexion()
        {
            this.Base = "BD_MINIMARKET";
            this.Servidor = "EC001SIS016\\SQLEXPRESS";
            this.Usuario = "user_minimarket";
            this.clave = "mini1234";
            this.Seguridad = false;
        }

        public SqlConnection CrearConexion()
        {
            SqlConnection cadena = new SqlConnection();
            try
            {
                cadena.ConnectionString = "Server=" + this.Servidor + "; Database=" + this.Base + ";";
                if (this.Seguridad)
                {
                    cadena.ConnectionString = cadena.ConnectionString + "Integrated Security = SSPI";
                }
                else
                {
                    cadena.ConnectionString = cadena.ConnectionString + "User Id="+this.Usuario + "; Password="+this.clave+";";
                }
            }catch (Exception ex)
            {
                cadena = null;
                throw ex;
            }
            return cadena;
        }

        public static Conexion getInstancia()
        {
            if (con == null)
            {
                con = new Conexion();
            }
            return con;
        }
    }
}
