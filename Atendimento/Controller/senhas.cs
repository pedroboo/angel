using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Atendimento.Model;

namespace Atendimento.Controller
{
    class Senhas
    {

        private int proximoAtendimento;
        private readonly Queue<Senha> filaSenhas;

        
        public Senhas()
        {
            proximoAtendimento = 1;
            filaSenhas = new Queue<Senha>();
        }
        public void GerarSenhas()
        {
            filaSenhas.Enqueue(new Senha(proximoAtendimento++));
        }

        public int ProximoAtendimento
        {
            get { return proximoAtendimento; }
        }

        public Queue<Senha> FilaSenhas
        {
            get { return filaSenhas; }
        }

    }
}
