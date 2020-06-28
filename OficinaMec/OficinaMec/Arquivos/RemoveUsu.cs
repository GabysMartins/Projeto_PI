using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OficinaMec
{
    public class RemoveUsu
    {
Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();
        public String mensagem = "";
        public RemoveUsu(String COD_FUNC)
        {

            if (COD_FUNC == "")
            {
                this.mensagem = "Insira um usuario!";
            }
            else
            {
                string sql = $"select COD_FUNC from Funcionario where COD_FUNC={COD_FUNC}";
                try
                {
                    SqlCommand cmd1 = new SqlCommand(sql, conexao.conectar());
                    SqlDataReader leitor = cmd1.ExecuteReader();


                    if (leitor.Read())
                    {
                        String ExibeDesc = leitor[0].ToString();

                        cmd.CommandText = "delete from Funcionario where COD_FUNC = @COD_FUNC ";
                        cmd.Parameters.AddWithValue("@COD_FUNC", COD_FUNC);

                        try
                        {
                            cmd.Connection = conexao.conectar();
                            cmd.ExecuteNonQuery();

                            this.mensagem = ("Funcionario(a) excluído(a) com sucesso!");
                            conexao.desconectar();

                        }
                        catch (SqlException ex)
                        {
                            this.mensagem = ("Funcionario(a) não existe! ");
                        }


                    }
                    else
                    {
                        this.mensagem = ("Funcionario(a) não cadastrado!");

                    }
                }
                catch (SqlException e)
                {
                    this.mensagem = ("Funcionario(a) não existe! ");
                    //Console.WriteLine(e);
                }
            }


        }
    }
}
