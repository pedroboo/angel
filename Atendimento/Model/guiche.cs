using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atendimento.Model
{
    public class Guiche
    {

        private int id;
        private Queue<Senha> atendimentos;

        
        public Guiche()
            : this(0)
        {
        }

        public Guiche(int id)
        {
            this.id = id;
            atendimentos = new Queue<Senha>();
        }

        public int Id { get => id; set => id = value; }
        public Queue<Senha> Atendimentos { get => atendimentos; set => atendimentos = value; }

        public bool chamar(Queue<Senha> filaSenhas)
        {
            bool chamaSenha;
            Senha senhaAtendida;

            chamaSenha = (filaSenhas.Count > 0);
            if (chamaSenha)
            {
                senhaAtendida = filaSenhas.Dequeue();
                senhaAtendida.dadosparcial() ;
                senhaAtendida.atualizarHrAtendimento();
                atendimentos.Enqueue(senhaAtendida);
            }
            return chamaSenha;
        }



    }
}