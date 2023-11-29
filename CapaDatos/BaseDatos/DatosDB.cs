namespace CapaDatos.BaseDatos
{
    internal class DatosDB
    {
        private const string Servidor = "JULIAN";
        private const string BaseDatos = "Panaderia";
        private const string Usuario = "sa";
        private const string Password = "w/ss/m29";

        public static string CadenaConexionConSA = $"Server ={Servidor};Database={BaseDatos};User={Usuario};Password={Password}";

        public static string CadenaConexionsinSA = $"Data Source = {Servidor};Initial Catalog={BaseDatos};Integrated Security = True";
    }
}
