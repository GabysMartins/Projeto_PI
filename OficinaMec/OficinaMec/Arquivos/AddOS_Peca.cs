using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OficinaMec.Arquivos
{
    class AddOS_Peca
    {
        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();
        public String mensagem = "";
        
        public AddOS_Peca(String QTTD_PECA, String NUM_ORC, String COD_PECA)
        {
            cmd.CommandText = "insert into Consulta_Banco (QTTD_PECA,NUM_ORC,COD_PECA) values (@QTTD_PECA,@NUM_ORC,@COD_PECA)";
            cmd.Parameters.AddWithValue("@QTTD_PECA", QTTD_PECA);
            cmd.Parameters.AddWithValue("@NUM_ORC", NUM_ORC);
            cmd.Parameters.AddWithValue("@COD_PECA", COD_PECA);

            try
            {
                cmd.Connection = conexao.conectar();
                cmd.ExecuteNonQuery();
                conexao.desconectar();
                this.mensagem = "Cadastrado do carro efetuado com sucesso!!";
            }
            catch (SqlException e)
            {
                this.mensagem = "Carro ja cadastrado!!";
                // Console.WriteLine(e);
            }
        }

    }
}
