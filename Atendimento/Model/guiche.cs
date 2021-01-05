using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atendimento.Model
{
    public class guiche
    {
        //Atributos 
        public int idGuiche;
        private readonly Queue<senha> atendimentos;
        private static int proximoId = 0;

        //Construtores
        public guiche() {

            idGuiche = proximoId++;
            atendimentos = new Queue<senha>();
        }




        //



    }
}
