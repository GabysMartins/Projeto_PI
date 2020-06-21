using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OficinaMec
{
    public class Salva_OS
    {
        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();
        public String mensagem = "";
        public Salva_OS(String NUM_ORC, String DESC_ORC, String CPF_ORC, String PLACA_ORC, String NOME_ORC, String TEL_ORC,String ANO_FAB_ORC,String MOD_ORC, String KM_ORC,String VALOR_PECAS_ORC, String VALOR_MAO_ORC,String VALOR_TOTAL_ORC)
        {

            cmd.CommandText = "insert into OrcamentoS (NUM_ORC,DESC_ORC,CPF_ORC,PLACA_ORC,NOME_ORC,TEL_ORC,ANO_FAB_ORC,MOD_ORC,KM_ORC,VALOR_PECAS_ORC,VALOR_MAO_ORC,VALOR_TOTAL_ORC) values (@NUM_ORC,@DESC_ORC,@CPF_ORC,@PLACA_ORC,@NOME_ORC,@TEL_ORC,@ANO_FAB_ORC,@MOD_ORC,@KM_ORC,@VALOR_PECAS_ORC,@VALOR_MAO_ORC,@VALOR_TOTAL_ORC)";
            cmd.Parameters.AddWithValue("@NUM_ORC", NUM_ORC);
            cmd.Parameters.AddWithValue("@DESC_ORC", DESC_ORC);
            cmd.Parameters.AddWithValue("@CPF_ORC", CPF_ORC);
            cmd.Parameters.AddWithValue("@PLACA_ORC", PLACA_ORC);
            cmd.Parameters.AddWithValue("@NOME_ORC", NOME_ORC);
            cmd.Parameters.AddWithValue("@TEL_ORC", TEL_ORC);
            cmd.Parameters.AddWithValue("@ANO_FAB_ORC", ANO_FAB_ORC);
            cmd.Parameters.AddWithValue("@MOD_ORC", MOD_ORC);
            cmd.Parameters.AddWithValue("@KM_ORC", KM_ORC);
            cmd.Parameters.AddWithValue("@VALOR_PECAS_ORC", VALOR_PECAS_ORC);
            cmd.Parameters.AddWithValue("@VALOR_MAO_ORC", VALOR_MAO_ORC);
            cmd.Parameters.AddWithValue("@VALOR_TOTAL_ORC", VALOR_TOTAL_ORC);
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
