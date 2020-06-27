using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OficinaMec.Arquivos
{
    class ExcluiPeca
    {
        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();
        public string mensagem = "";

        public ExcluiPeca(String Codigo)
        {
            if (Codigo == "")
            {
                this.mensagem = "Insira uma peça!";
            }
            else
            {
                string sql = $"select COD_PECA from Consulta_Banco where COD_PECA={Codigo}";
                try
                {
                    SqlCommand cmd1 = new SqlCommand(sql, conexao.conectar());
                    SqlDataReader leitor = cmd1.ExecuteReader();


                    if (leitor.Read())
                    {
                        String ExibeDesc = leitor[0].ToString();
                      
                        cmd.CommandText = "delete from Pecas_estoque where COD_PECA = @Codigo ";
                        cmd.Parameters.AddWithValue("@Codigo", Codigo);

                        try
                        {
                            cmd.Connection = conexao.conectar();
                            cmd.ExecuteNonQuery();

                            this.mensagem = ("Peça excluída com sucesso!");
                            conexao.desconectar();

                        }
                        catch (SqlException ex)
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
