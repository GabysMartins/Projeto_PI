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
    public class ConsultaOS
    {

        public string ExibCod { get; set; }
        public string ExibQTTD { get; set; }


        Conexao conexao = new Conexao();
        public String mensagem = "";



        public ConsultaOS(String numos)
        {

            string sql = @"select * from Consulta_Banco where NUM_ORC=@numos";
            SqlCommand cmd = new SqlCommand(sql, conexao.conectar());
            cmd.Parameters.AddWithValue("@numos", numos);
            SqlDataReader leitor = cmd.ExecuteReader();

            try
            {
                while (leitor.Read())
                {
                    ExibCod = leitor[0].ToString();
                    ExibQTTD = leitor[1].ToString();
                }
                conexao.desconectar();
            }
            catch (SqlException e)
            {
                this.mensagem = "Orcamento não Cadastrado!!";
                // Console.WriteLine(e);
            }

        }
    }
}
