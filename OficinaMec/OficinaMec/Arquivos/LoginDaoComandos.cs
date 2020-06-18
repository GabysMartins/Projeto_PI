using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OficinaMec
{
    class LoginDaoComandos
    {
        public bool tem = false;
        public string mensagem = "";
        SqlCommand cmd = new SqlCommand();
        Conexao con = new Conexao();
        SqlDataReader dr;


        public bool verificarLogin(String Login, String Senha,String Per)
        {

            cmd.CommandText = "select * from Funcionario where COD_FUNC = @Login and SENHA_FUNC = @Senha and PERMIS_FUNC =@Per";
            cmd.Parameters.AddWithValue("@Login",Login);
            cmd.Parameters.AddWithValue("@Senha", Senha);
            cmd.Parameters.AddWithValue("@Per", Per);
            try
            {
                cmd.Connection = con.conectar();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    tem = true;
                }
                              
            }
            catch (SqlException)
            {
                this.mensagem="Erro com o Banco de dados";
            }

            return tem;
        }

    }
}
