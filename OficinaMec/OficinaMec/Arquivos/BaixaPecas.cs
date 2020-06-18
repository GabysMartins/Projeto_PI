using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OficinaMec.Arquivos
{
    class BaixaPecas
    {

        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();
        public String mensagem = "";
        public BaixaPecas(String COD_PECA, int QTTD_PECA)
        {

            cmd.CommandText = "UPDATE Pecas_estoque SET COD_PECA = @COD_PECA WHERE QTTD_PECA = @QTTD_PECA";
            cmd.Parameters.AddWithValue("@COD_PECA", COD_PECA);
            cmd.Parameters.AddWithValue("@QTTD_PECA", QTTD_PECA);

            try
            {
                cmd.Connection = conexao.conectar();
                cmd.ExecuteNonQuery();
                conexao.desconectar();
                this.mensagem = "Baixa efetuada com sucesso!!";
            }
            catch (SqlException e)
            {
                this.mensagem = "Erro ao dar baixa!!";
                // Console.WriteLine(e);
            }

        }
    }
}
