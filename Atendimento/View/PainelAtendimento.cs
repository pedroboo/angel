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
        private Senhas s;
        private Guiches g;
        public Form1()
        {
            InitializeComponent();

            Senhas s = new Senhas();

            Guiches g = new Guiches();
        }


        private void btn_gerarsenha_click(object sender, EventArgs e)
        {

            s.GerarSenhas();

        }

        private void btn_listaSenha_Click(object sender, EventArgs e)
        {
            lstSenhasGeradas.Items.Clear();
            int w = 0;
            while ( w > s.FilaSenhas.Count)
            {
                lstSenhasGeradas.Items.Add(s);
                w++;
            }

        }

        private void btn_chamaSenha_Click(object sender, EventArgs e)
        {
            int idGuiche;
            idGuiche = int.Parse(guicheChama.Text) - 1;
            if (!g.ListaGuiches[idGuiche].chamar(s.FilaSenhas))
                MessageBox.Show("Fila vazia");
        }

        private void btn_listaGuiche_Click(object sender, EventArgs e)
        {
            int idGuiche;
            idGuiche = int.Parse(guicheChama.Text) - 1;
            listaChamadaGuiche.Items.Clear();
            int w = 0;
            while (w > g.ListaGuiches.Count)
            {
                listaChamadaGuiche.Items.Add(g.ListaGuiches[idGuiche].Atendimentos);
                w++;
            }

        }

        private void btn_adcGuiche_Click(object sender, EventArgs e)
        {
            g.adicionarGuiche(new Model.Guiche(g.ListaGuiches.Count + 1));
            lbQtGuiches.Text = g.ListaGuiches.Count.ToString();
        }
    }
}
