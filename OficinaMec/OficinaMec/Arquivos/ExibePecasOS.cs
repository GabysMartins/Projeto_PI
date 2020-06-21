using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OficinaMec.Arquivos
{
    public class ExibePecasOS
    {
        Conexao conexao = new Conexao();
        public String mensagem = "";

        public String desc { get; set; }
        public String quant { get; set; }

        public ExibePecasOS(String OS)
        {

            string sql = $"select QTTD_PECA,COD_PECA from Consulta_Banco where NUM_ORC='{OS}'";
            SqlCommand cmd = new SqlCommand(sql, conexao.conectar());
            SqlDataReader leitor = cmd.ExecuteReader();

            try
            {
                while (leitor.Read())
                {
                    desc = (leitor[0].ToString());
                    quant = (leitor[1].ToString());
                }
                conexao.desconectar();
            }
            catch (SqlException)
            {
                this.mensagem = "Erro ao Cadastrar!!";
                // Console.WriteLine(e);
            }
        }
    }
}
