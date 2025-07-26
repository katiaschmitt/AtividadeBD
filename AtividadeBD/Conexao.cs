
using System.Data.SqlClient;

namespace AtividadeBD
{
    public class Conexao
    {
        public SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\katia.pollheim\\MeuBanco\\MeuBanco.mdf;Integrated Security=True;Connect Timeout=30");

        public void Conectar()
        {
            conn.Open();
        }

        public void Desconectar()
        {
            conn.Close();   
        }
    }
}
