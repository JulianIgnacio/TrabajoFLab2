using System.Data.SqlClient;
using System.Windows.Forms;

namespace CapaDatos.BaseDatos
{
    public class ConexionDB
    {
        public SqlConnection _conexionDB = new SqlConnection(DatosDB.CadenaConexionConSA);

        public SqlConnection AbrirConexion()
        {
            try
            {
                if(_conexionDB.State == System.Data.ConnectionState.Closed) _conexionDB.Open();
                return _conexionDB;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show($"Error en AbrirConexion: {ex.Message}");
                return null;
                
            }
        }

        public SqlConnection CerrarConexion()
        {
            try
            {
                if (_conexionDB.State == System.Data.ConnectionState.Open) _conexionDB.Close();

                return _conexionDB;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show($"Error en cierre Conexion :{ex.Message}");
                return null;
            }
        }

        public SqlConnection EstadoConexion()
        {
            MessageBox.Show($"Conexion Exitosa; El estado de la conexion es : {_conexionDB.State}","Test de la conexion",MessageBoxButtons.OK,MessageBoxIcon.Information);
            return _conexionDB;
        }
        
    }
}
