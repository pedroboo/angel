using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atendimento.Model
{
    public class Senha
    {
        private readonly int id;
        private DateTime hrDataGerado { get; set; }
        private DateTime hrAtendimento { get; set; }
        
        //construtor 
        public Senha(int id)
        {
            this.id = id;
            hrDataGerado = DateTime.Now;
            hrAtendimento = new DateTime();
        }

        public string dadosparcial()
        {

            return 
                $"{id} + {hrDataGerado.ToString("dd/MM/yyyy")} - {hrDataGerado.ToString("HH:mm:ss")}";
        
        }

        public void atualizarHrAtendimento()
        {
            hrAtendimento = DateTime.Now;
        }

        public string dadosCompletos()
        {
        return $"{dadosparcial()} - {hrAtendimento.ToString("dd/MM/yyyy")} - {hrAtendimento.ToString("HH:mm:ss")}";
        }

    }
}