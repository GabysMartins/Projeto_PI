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

            cmd.CommandText = "delete from Funcionario where COD_FUNC = @COD_FUNC";
            cmd.Parameters.AddWithValue("@COD_FUNC", COD_FUNC);
            
            try
            {
                cmd.Connection = conexao.conectar();
                cmd.ExecuteNonQuery();
                conexao.desconectar();
                this.mensagem = "Removido com sucesso!!";
            }
            catch (SqlException e)
            {
                this.mensagem = "Erro ao remover!!";
                 Console.WriteLine(e);
            }

        }
    }
}
