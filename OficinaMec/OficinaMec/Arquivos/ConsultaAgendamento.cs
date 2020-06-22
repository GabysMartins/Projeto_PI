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
    public class ConsultaAgendamento
    {

        public string ExibeData { get; set; }
        public string ExibeHora { get; set; }
        public string ExibeNumOrc { get; set; }


        Conexao conexao = new Conexao();
        public String mensagem = "";



        public ConsultaAgendamento(String DATA_AG)
        {

            string sql = "SELECT DATA_AG, HORA_AG,NUM_ORC FROM Agendamento where DATA_AG=@DATA_AG Order by HORA_AG ASC";
            SqlCommand cmd = new SqlCommand(sql, conexao.conectar());
            cmd.Parameters.AddWithValue("@DATA_AG", DATA_AG);
            SqlDataReader leitor = cmd.ExecuteReader();

            try
            {
                while (leitor.Read())
                {
                    ExibeData = leitor[0].ToString();
                    ExibeHora = leitor[1].ToString();
                    ExibeNumOrc = leitor[2].ToString();
                }
                conexao.desconectar();
            }
            catch (SqlException e)
            {
                this.mensagem = "Erro ao Cadastrar!!";
                // Console.WriteLine(e);
            }

        }
    }
}
