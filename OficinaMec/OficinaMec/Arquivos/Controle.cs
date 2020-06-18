using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OficinaMec
{
    public class Controle
    {
        public bool tem;
        public String mensagem = "";
        public bool acessar(String Login, String Senha, String Per)
        {
            LoginDaoComandos loginDao = new LoginDaoComandos();
            tem = loginDao.verificarLogin(Login, Senha, Per);
            if (loginDao.mensagem.Equals(""))
            {
                this.mensagem = loginDao.mensagem;
            }
            
            return tem;
        }

    }
}
