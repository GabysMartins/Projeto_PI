using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OficinaMec
{
    public class AddCarro
    {
        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();
        public String mensagem = "";
        public AddCarro(String PLACA_CAR, String COR_CAR, String ANO_CAR, String MODELO_CAR, String FABRIC_CAR)
        {

            cmd.CommandText = "insert into Carro (PLACA_CAR,COR_CAR,ANO_CAR,MODELO_CAR,FABRIC_CAR) values (@PLACA_CAR,@COR_CAR,@ANO_CAR,@MODELO_CAR,@FABRIC_CAR)";
            cmd.Parameters.AddWithValue("@PLACA_CAR", PLACA_CAR);
            cmd.Parameters.AddWithValue("@COR_CAR", COR_CAR);
            cmd.Parameters.AddWithValue("@ANO_CAR", ANO_CAR);
            cmd.Parameters.AddWithValue("@MODELO_CAR", MODELO_CAR);
            cmd.Parameters.AddWithValue("@FABRIC_CAR", FABRIC_CAR);
            try
            {
                cmd.Connection = conexao.conectar();
                cmd.ExecuteNonQuery();
                conexao.desconectar();
                this.mensagem = "Cadastrado do carro efetuado com sucesso!!";
            }
            catch (SqlException e)
            {
                this.mensagem = "Carro já cadastrado!!";
                // Console.WriteLine(e);
            }

        }
    }
}
