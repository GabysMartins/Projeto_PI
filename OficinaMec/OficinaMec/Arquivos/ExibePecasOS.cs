using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OficinaMec
{
    public class ExibePecasOS

    {
        public string ExibeDesc { get; set; }
        public string ExibePreco { get; set; }
       

        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();
        public String mensagem = "";
        public ExibePecasOS(String num)
        {
            string sql = $"select * from Consulta_Banco where NUM_ORC={num}";
            try
            {
                SqlCommand cmd = new SqlCommand(sql, conexao.conectar());
                SqlDataReader leitor = cmd.ExecuteReader();

                while (leitor.Read())
                {
                    ExibeDesc = leitor[0].ToString();
                    ExibePreco = leitor[2].ToString();
                   
                }
                conexao.desconectar();
            }
            catch (SqlException e)
            {
                this.mensagem = "Erro ao Buscar Itens!!";
                // Console.WriteLine(e);
            }

        }
    }
}
