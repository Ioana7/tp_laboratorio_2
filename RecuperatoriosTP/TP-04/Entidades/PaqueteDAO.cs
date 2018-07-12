using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Entidades
{
    public static class PaqueteDAO
    {

        #region Atributos

        static SqlConnection conexion;
        static SqlCommand comando;

        #endregion

        #region Constructor

        static PaqueteDAO()
        {

        }

        #endregion

        #region Método Insertar

        public static bool Insertar(Paquete paquete)
        {
            bool retorno = false;
            conexion = new SqlConnection("Data Source = .\\SQLEXPRESS; Initial Catalog=correo-sp-2017;Integrated Security=True");
            comando = new SqlCommand();
            comando.CommandType = System.Data.CommandType.Text;
            comando.Connection = conexion;

            try
            {
                conexion.Open();
                comando.CommandText = string.Format("INSERTAR EN Paquetes (direccionEntrega, trackingID, alumno) VALUES ('{0}','{1}', 'Ioana Darroza')", paquete.DireccionEntrega, paquete.TrackingID);
                comando.ExecuteNonQuery();
                conexion.Close();
                retorno = true;
            }
            catch (Exception)
            {

            }

            return retorno;
        }

        #endregion
    }
}