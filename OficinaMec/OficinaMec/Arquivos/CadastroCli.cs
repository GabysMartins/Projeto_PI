using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OficinaMec
{
    public class AddCli
    {
        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();
        public String mensagem = "";
        public AddCli(String NOME_CLI, String CPF_CNPJ_CLI, String RG_CLI, String EMAIL_CLI, String ENDERECO_CLI,String TELEFONE_CLI)
        {

            cmd.CommandText = "insert into Cliente (NOME_CLI,CPF_CNPJ_CLI,RG_CLI,EMAIL_CLI,ENDERECO_CLI,TELEFONE_CLI) values (@NOME_CLI,@CPF_CNPJ_CLI,@RG_CLI,@EMAIL_CLI,@ENDERECO_CLI,@TELEFONE_CLI)";
            cmd.Parameters.AddWithValue("@NOME_CLI", NOME_CLI);
            cmd.Parameters.AddWithValue("@CPF_CNPJ_CLI", CPF_CNPJ_CLI);
            cmd.Parameters.AddWithValue("@RG_CLI", RG_CLI);
            cmd.Parameters.AddWithValue("@EMAIL_CLI", EMAIL_CLI);
            cmd.Parameters.AddWithValue("@ENDERECO_CLI", ENDERECO_CLI);
            cmd.Parameters.AddWithValue("@TELEFONE_CLI", TELEFONE_CLI);
            try
            {
                cmd.Connection = conexao.conectar();
                cmd.ExecuteNonQuery();
                conexao.desconectar();
                this.mensagem = "Cadastrado com sucesso!!";
            }
            catch (SqlException e)
            {
                this.mensagem = "Erro ao Cadastrar!!";
                // Console.WriteLine(e);
            }

        }
    }
}
