using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GTA_PROJECT
{
    public partial class frmPlanoNacional : Form
    {
        public frmPlanoNacional()
        {
            InitializeComponent();
        }

        private void btnCondGer_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmCondicoesGerais>().Count() > 0)
            {
                MessageBox.Show("FORMULÁRIO DE LOGIN JÁ ESTÁ ABERTO");
                return;

            }
            else
            {

                string url;
                url = "http://www.gtaassist.com.br/sitev2/biblioteca/cg/Condicoes_Gerais.pdf";
                frmCondicoesGerais f = new frmCondicoesGerais(url);
                f.ShowDialog();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmCondicoesGerais>().Count() > 0)
            {
                MessageBox.Show("FORMULÁRIO DE LOGIN JÁ ESTÁ ABERTO");
                return;

            }
            else
            {

                string url;
                url = "http://www.gtaassist.com.br/sitev2/biblioteca/cg/Condicoes_Gerais.pdf";
                frmCondicoesGerais f = new frmCondicoesGerais(url);
                f.ShowDialog();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmCotacao>().Count() > 0)
            {
                MessageBox.Show("FORMULÁRIO DE COTAÇÃO JÁ ESTÁ ABERTO");
                return;

            }
            else
            {

                frmCotacao frmCotar = new frmCotacao();
                frmCotar.ShowDialog();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmCotacao>().Count() > 0)
            {
                MessageBox.Show("FORMULÁRIO DE COTAÇÃO JÁ ESTÁ ABERTO");
                return;

            }
            else
            {

                frmCotacao frmCotar = new frmCotacao();
                frmCotar.ShowDialog();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Variaveis.logado == "não")
            {


                MessageBox.Show("É necessario logar no sistema para emitir a cotação");
                return;

            }
            frmEmitir emitir = new frmEmitir();
            emitir.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Variaveis.logado == "não")
            {
                
                MessageBox.Show("É necessario logar no sistema para emitir a cotação");
                return;

            }
            frmEmitir emitir = new frmEmitir();
            emitir.ShowDialog();
        }            
        
    }
}
