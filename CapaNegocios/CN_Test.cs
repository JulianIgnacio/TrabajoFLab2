using CapaDatos.BaseDatos;

namespace CapaNegocios
{
    public class CN_Test
    {
        ConexionDB _conexionDB = new ConexionDB();

        public void TestDB()
        {
            _conexionDB.EstadoConexion();
        }
    }
}
