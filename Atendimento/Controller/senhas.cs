using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Atendimento.Model;

namespace Atendimento.Controller
{
    class senhas
    {

        public int proximoAtendimento;
        private readonly Queue<senhas> filaSenhas;

        
        public senhas()
        {
            proximoAtendimento += 1;
            filaSenhas = new Queue<senhas>();
        }

        public void gerar_senha ()
        {
            senha ns = new senha();
            ns.id++;


        }

    }
}
