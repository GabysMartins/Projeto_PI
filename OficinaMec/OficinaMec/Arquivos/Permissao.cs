using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OficinaMec
{
    class Permissao
    {
        public bool tem = false;
        public string mensagem = "";
        public string per = "";
        SqlCommand cmd = new SqlCommand();
        Conexao con = new Conexao();
        SqlDataReader dr;

        public bool permissao(String permissao)
        {
            cmd.CommandText = "SELECT PERMIS_FUNC FROM Funcionario WHERE COD_FUNC =@PERMIS_FUNC";
            cmd.Parameters.AddWithValue("@PERMIS_FUNC", permissao);
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
                this.mensagem = "Erro com o Banco de dados";
            }

            return tem;


        }
    }
}

