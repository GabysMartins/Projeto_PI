using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OficinaMec.Arquivos
{
    class AlterarValorPeca
    {

        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();
        public string mensagem = "";

        public AlterarValorPeca(int QTTD_PECA,String Codigo)
        {
            if (Codigo == "")
            {
                this.mensagem = "Insira uma peça!";
            }
            else
            {
                string sql = $"select QTTD_PECA from Pecas_estoque where COD_PECA={Codigo}";
                try
                {
                    SqlCommand cmd1 = new SqlCommand(sql, conexao.conectar());
                    SqlDataReader leitor = cmd1.ExecuteReader();


                    if (leitor.Read())
                    {
                        String ExibeDesc = leitor[0].ToString();

                        cmd.CommandText = "update Pecas_estoque set QTTD_PECA=@QTTD_PECA where COD_PECA = @Codigo ";
                        cmd.Parameters.AddWithValue("@QTTD_PECA", QTTD_PECA);
                        cmd.Parameters.AddWithValue("@COD_PECA", Codigo);

                        try
                        {
                            cmd.Connection = conexao.conectar();
                            cmd.ExecuteNonQuery();

                            this.mensagem = ("Peça alterada com sucesso!");
                            conexao.desconectar();

                        }
                        catch (SqlException)
                        {
                            this.mensagem = ("Peça não existe!! ");
                        }


                    }
                    else
                    {
                        this.mensagem = ("Peça não existe!! ");

                    }
                }
                catch (SqlException e)
                {
                    this.mensagem = ("Peça não existe!! ");
                    Console.WriteLine(e);
                }
            }

        }
    }
}