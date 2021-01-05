using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atendimento.Model
{
    public class senha
    {
        public int id;
        public DateTime hrDataGerado { get; set; }
        public DateTime hrAtendimento { get; set; }
        
        //construtor 
        public senha()
        {
            id = this.id;
            hrDataGerado = DateTime.Now;
        }

        public string dadosParciais()
        {

            return $"{id} + {hrDataGerado.ToString("dd/MM/yyyy")} - {hrDataGerado.ToString("HH:mm:ss")}";
        }

        public void atualizarHrAtendimento()
        {
            hrAtendimento = DateTime.Now;
        }

        public string dadosCompletos()
        {
        return $"{dadosParciais()} - {hrAtendimento.ToString("dd/MM/yyyy")} - {hrAtendimento.ToString("HH:mm:ss")}";
        }

    }
}