using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OficinaMec.Arquivos
{
    class Estoque
    {

        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();
        public String mensagem = "";
        public Estoque(String COD_PECA, int QTTD_PECA, String DESCR_PECA, String FABRIC_PECA,String PRECO_PECA, String MODELO_PECA)
        {

            cmd.CommandText = "insert into Pecas_estoque (COD_PECA,QTTD_PECA,DESCR_PECA,FABRIC_PECA,PRECO_PECA,MODELO_PECA) values (@COD_PECA,@QTTD_PECA,@DESCR_PECA,@FABRIC_PECA,@PRECO_PECA,@MODELO_PECA)";
            cmd.Parameters.AddWithValue("@COD_PECA", COD_PECA);
            cmd.Parameters.AddWithValue("@QTTD_PECA", QTTD_PECA);
            cmd.Parameters.AddWithValue("@DESCR_PECA", DESCR_PECA);
            cmd.Parameters.AddWithValue("@FABRIC_PECA", FABRIC_PECA);
            cmd.Parameters.AddWithValue("@PRECO_PECA", PRECO_PECA);
            cmd.Parameters.AddWithValue("@MODELO_PECA", MODELO_PECA);
            try
            {
                cmd.Connection = conexao.conectar();
                cmd.ExecuteNonQuery();
                conexao.desconectar();
                this.mensagem = "Peça cadastrada com sucesso!!";
            }
            catch (SqlException e)
            {
                this.mensagem = "Erro ao Cadastrar!!";
                Console.WriteLine(e);
            }

        }

    }
}

