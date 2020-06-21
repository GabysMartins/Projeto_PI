using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OficinaMec.Arquivos
{
    class RemOS_Peca
    {
        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();
        public String mensagem = "";

        public RemOS_Peca(String DESC_PECA)
        {
            cmd.CommandText = "delete from Orcamento_Pecas where DESC_PECA = @DESC_PECA";
            cmd.Parameters.AddWithValue("@DESC_PECA", DESC_PECA);

            try
            {
                cmd.Connection = conexao.conectar();
                cmd.ExecuteNonQuery();
                conexao.desconectar();
                this.mensagem = "Cadastrado do carro efetuado com sucesso!!";
            }
            catch (SqlException e)
            {
                this.mensagem = "Erro ao Cadastrar!!";
                // Console.WriteLine(e);
            }
        }

    }
}
