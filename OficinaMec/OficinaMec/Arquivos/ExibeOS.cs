using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OficinaMec
{
    public class ExibeOS

    {
        public string ExibeOrd { get; set; }
        public string ExibeDescricao { get; set; }
        public string ExibeCPF { get; set; }
        public string ExibePlaca { get; set; }
        public string ExibeNome { get; set; }
        public string ExibeTel { get; set; }
        public string ExibeAno { get; set; }
        public string ExibeModelo { get; set; }
        public string ExibeKM { get; set; }
        public string ExibeValorPec { get; set; }
        public string ExibeValorMao { get; set; }
        public string ExibeValorTotal { get; set; }


        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();
        public String mensagem = "";
        public ExibeOS(String num)
        {
            string sql = $"select * from Orcamentos where NUM_ORC={num}";
            try
            {
                SqlCommand cmd = new SqlCommand(sql, conexao.conectar());
                SqlDataReader leitor = cmd.ExecuteReader();

                while (leitor.Read())
                {
                    ExibeOrd = leitor[0].ToString();
                    ExibeDescricao = leitor[1].ToString();
                    ExibeCPF = leitor[2].ToString();
                    ExibePlaca = leitor[3].ToString();
                    ExibeNome = leitor[4].ToString();
                    ExibeTel = leitor[5].ToString();
                    ExibeAno = leitor[6].ToString();
                    ExibeModelo = leitor[7].ToString();
                    ExibeKM = leitor[8].ToString();
                    ExibeValorPec = leitor[9].ToString();
                    ExibeValorMao = leitor[10].ToString();
                    ExibeValorTotal = leitor[11].ToString();
                }
                conexao.desconectar();
            }
            catch (SqlException e)
            {
                this.mensagem = "Erro ao Buscar OS!!";
                // Console.WriteLine(e);
            }

        }
    }
}
