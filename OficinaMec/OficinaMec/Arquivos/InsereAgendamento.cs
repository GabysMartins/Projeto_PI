using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OficinaMec
{
    public class InsereAgendamento
    {
        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();
        public String mensagem = "";
        public InsereAgendamento(String NUM_Ag,String NUM_ORC, String DESC_ORC, String CPF_ORC, String PLACA_ORC, String NOME_ORC, String TEL_ORC, String ANO_FAB_ORC, String MOD_ORC, String DATA_AG, String HORA_AG)
        {

            cmd.CommandText = "insert into Agendamento (NUM_Ag,NUM_ORC,DESC_ORC,CPF_ORC,PLACA_ORC,NOME_ORC,TEL_ORC,ANO_FAB_ORC,MOD_ORC,DATA_AG,HORA_AG) values (@NUM_Ag,@NUM_ORC,@DESC_ORC,@CPF_ORC,@PLACA_ORC,@NOME_ORC,@TEL_ORC,@ANO_FAB_ORC,@MOD_ORC,@DATA_AG,@HORA_AG)";
            cmd.Parameters.AddWithValue("@NUM_Ag", NUM_Ag);
            cmd.Parameters.AddWithValue("@NUM_ORC", NUM_ORC);
            cmd.Parameters.AddWithValue("@DESC_ORC", DESC_ORC);
            cmd.Parameters.AddWithValue("@CPF_ORC", CPF_ORC);
            cmd.Parameters.AddWithValue("@PLACA_ORC", PLACA_ORC);
            cmd.Parameters.AddWithValue("@NOME_ORC", NOME_ORC);
            cmd.Parameters.AddWithValue("@TEL_ORC", TEL_ORC);
            cmd.Parameters.AddWithValue("@ANO_FAB_ORC", ANO_FAB_ORC);
            cmd.Parameters.AddWithValue("@MOD_ORC", MOD_ORC);
            cmd.Parameters.AddWithValue("@DATA_AG", DATA_AG);
            cmd.Parameters.AddWithValue("@HORA_AG", HORA_AG);

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
                Console.WriteLine(e);
            }

        }
    }
}
