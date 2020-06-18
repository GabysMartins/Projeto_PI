using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OficinaMec.Arquivos
{
    class ExcluiPeca
    {
        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();
        public String mensagem = "";

        public ExcluiPeca(String COD_PECA)
        {

            cmd.CommandText = "delete from Pecas_estoque where COD_PECA = @COD_PECA";
            cmd.Parameters.AddWithValue("@COD_PECA", COD_PECA);

            try
            {
                cmd.Connection = conexao.conectar();
                cmd.ExecuteNonQuery();
                conexao.desconectar();
                this.mensagem = "Peca removida com sucesso!!";
            }
            catch (SqlException e)
            {
                this.mensagem = "Peça não existe!";
                Console.WriteLine(e);
            }
        }
    }
}
