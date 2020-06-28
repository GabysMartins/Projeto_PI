using OficinaMec.Arquivos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlServerCe;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OficinaMec
{
    public class AdicionarPecaOrcamento
    {

        public string ExibeDescricao { get; set; }
        public string ExibeQuantidade { get; set; }
        public string ExibePreco { get; set; }


        Conexao conexao = new Conexao();
        public String mensagem = "";



        public AdicionarPecaOrcamento(String COD_PECA)
        {
            SqlCommand cmd1 = new SqlCommand();
            string sql = $"select DESCR_PECA,QTTD_PECA,PRECO_PECA from Pecas_estoque where COD_PECA='{COD_PECA}'";
            //cmd1.Parameters.AddWithValue("@CPF_CNPJ_CLI", CPF_CNPJ_CLI);

            try
            {
                SqlCommand cmd = new SqlCommand(sql, conexao.conectar());
                SqlDataReader leitor = cmd.ExecuteReader();

                while (leitor.Read())
                {
                    ExibeDescricao = leitor[0].ToString();
                    ExibeQuantidade = leitor[1].ToString();
                    ExibePreco = leitor[2].ToString();
                }
                conexao.desconectar();
            }
            catch (SqlException e)
            {
                this.mensagem = "Orcamento não existe!!";
                Console.WriteLine(e);
            }

        }
    }
}
