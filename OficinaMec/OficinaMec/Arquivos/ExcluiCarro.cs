using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OficinaMec.Arquivos
{
    class ExcluiCarro
    {
        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();
        public String mensagem = "";

        public ExcluiCarro(String PLACA_CAR)
        {

            cmd.CommandText = "delete from Carro where PLACA_CAR = @PLACA_CAR";
            cmd.Parameters.AddWithValue("@PLACA_CAR", PLACA_CAR);

            try
            {
                cmd.Connection = conexao.conectar();
                cmd.ExecuteNonQuery();
                conexao.desconectar();
                this.mensagem = "Carro removido com sucesso!!";
            }
            catch (SqlException e)
            {
                this.mensagem = "Carro não existe!";
                Console.WriteLine(e);
            }
        }
    }
}
