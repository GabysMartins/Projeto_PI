using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OficinaMec
{
    public class CadastroUsu
    {
        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();
        public String mensagem = "";
        public CadastroUsu(String COD_FUNC,String CPF_FUNC, String NOME_FUNC, String EMAIL_FUNC, String SENHA_FUNC, String PERMIS_FUNC)
        {

            cmd.CommandText = @"insert into Funcionario (COD_FUNC,CPF_FUNC,NOME_FUNC,EMAIL_FUNC,SENHA_FUNC,PERMIS_FUNC) values (@COD_FUNC,@CPF_FUNC,@NOME_FUNC,@EMAIL_FUNC,@SENHA_FUNC,@PERMIS_FUNC)";
            cmd.Parameters.AddWithValue("@COD_FUNC", COD_FUNC);
            cmd.Parameters.AddWithValue("@CPF_FUNC",CPF_FUNC);
            cmd.Parameters.AddWithValue("@NOME_FUNC", NOME_FUNC);
            cmd.Parameters.AddWithValue("@EMAIL_FUNC", EMAIL_FUNC);
            cmd.Parameters.AddWithValue("@SENHA_FUNC", SENHA_FUNC);
            cmd.Parameters.AddWithValue("@PERMIS_FUNC", PERMIS_FUNC);
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
