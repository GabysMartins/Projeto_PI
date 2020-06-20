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
    public class ExibirCarro
    {

        public string ExibAno { get; set; }
        public string ExibModelo { get; set; }

        Conexao conexao = new Conexao();
        public String mensagem = "";

        public ExibirCarro(String PLACA_CAR)
        {
            SqlCommand cmd1 = new SqlCommand();
            string sql = $"select ANO_CAR,MODELO_CAR from CARRO where PLACA_CAR='{PLACA_CAR}'";

            try
            {
                SqlCommand cmd = new SqlCommand(sql, conexao.conectar());
                SqlDataReader leitor = cmd.ExecuteReader();

                while (leitor.Read())
                {
                    ExibAno = leitor[0].ToString();
                    ExibModelo = leitor[1].ToString();
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
