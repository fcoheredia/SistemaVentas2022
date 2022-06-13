using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.Data;
using System.Data.SqlClient;
using CapaEntidad;

namespace CapaDatos
{
    public class CD_Usuaio
    {
        //Metodo para listar todos los usuarios 
        public List<Usuaros> listar ()
        {
            List<Usuaros> lista = new List<Usuaros>();
            using(SqlConnection oConexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = "SELECT idUsuario, nombreCompleto, documento, correo, clave, estado FROM usuario";
                    SqlCommand cmd = new SqlCommand(query, oConexion);
                    cmd.CommandType = CommandType.Text;
                    oConexion.Open();
                    using(SqlDataReader dr= cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Usuaros()
                            {
                                IdUsuario=Convert.ToInt32(dr["idUsuario"]),
                                Documento= dr["documento"].ToString(),
                                NombreCompleto= dr["nombreCompleto"].ToString(),
                                Coreo = dr["correo"].ToString(),
                                Clave = dr["nombreCompleto"].ToString(),
                                Estado =Convert.ToBoolean(dr["estado"].ToString()),
                            });
                        }
                    }
                }
                catch(Exception ex)
                {
                    lista = new List<Usuaros>();
                }
                return lista;
            }
        }
    }
}