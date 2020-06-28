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
    public class ExibirCliente
    {

        public string ExibNome { get; set; }
        public string ExibTelefone { get; set; }


        Conexao conexao = new Conexao();
        public String mensagem = "";
 


        public ExibirCliente(String CPF_CNPJ_CLI)
        {
            SqlCommand cmd1 = new SqlCommand();
            string sql = $"select NOME_CLI,TELEFONE_CLI from Cliente where CPF_CNPJ_CLI='{CPF_CNPJ_CLI}'";
            //cmd1.Parameters.AddWithValue("@CPF_CNPJ_CLI", CPF_CNPJ_CLI);

            try
            {
                SqlCommand cmd = new SqlCommand(sql, conexao.conectar());
                SqlDataReader leitor = cmd.ExecuteReader();

                while (leitor.Read())
                {
                    ExibNome = leitor[0].ToString();
                    ExibTelefone = leitor[1].ToString();
                }
                conexao.desconectar();
            }
            catch (SqlException e)
            {
                this.mensagem = "Erro ao exibir!!";
                // Console.WriteLine(e);
            }

        }
    }
}
