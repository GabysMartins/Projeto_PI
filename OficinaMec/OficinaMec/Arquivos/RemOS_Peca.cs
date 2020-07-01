using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OficinaMec.Arquivos
{
    class RemOS_Peca
    {
        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();
        public String mensagem = "";

        public RemOS_Peca(String QTTD_PECA)
        {
            if (QTTD_PECA == "")
            {
                this.mensagem = "Insira uma peça!";
            }
            else
            {
                        cmd.CommandText = "delete from Consulta_Banco where QTTD_PECA = @QTTD_PECA ";
                        cmd.Parameters.AddWithValue("@QTTD_PECA", QTTD_PECA);

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
                    
                }
               
            }
        }

    

