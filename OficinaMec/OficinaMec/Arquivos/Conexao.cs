using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OficinaMec
{
    public class Conexao
    { 

        SqlConnection con = new SqlConnection();

        public Conexao()
        {
            con.ConnectionString  = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Bruno\source\repos\Projeto_PI\OficinaMec\OficinaMec\OficinaMec.mdf;Integrated Security=True;Connect Timeout=30";
       
        }
        public SqlConnection conectar()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }
        public void desconectar()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }

        }
    }
}