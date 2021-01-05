using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Atendimento.Controller;

namespace Atendimento
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        senhas s = new senhas();

        private void btn_gerarSenha_Click(object sender, EventArgs e)
        {

            s.gerar_senha();


        }

        private void btn_listaSenha_Click(object sender, EventArgs e)
        {
            List<senhas> listSenhas = new List<senhas>();
            listSenha.View = View.Details;
            listSenha.Columns.Add("Id");
            listSenha.Columns.Add("Hora de atendimento");

            foreach(var item in listSenha)
            {

            }

        }
    }
}
