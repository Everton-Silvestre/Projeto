using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BLL;


namespace GTA_PROJECT
{
    public partial class frmCotacao : Form
    {
        decimal valor;
        Planos completarplan = new Planos();
        public frmCotacao()
        {
            InitializeComponent();
        }
                          

     
        private void btnCalcular_Click(object sender, EventArgs e)
        {


            if (cmbTipoPlan.Text == "")
            {
                MessageBox.Show("Complete o campo de Tipo de Plano");
                return;
            }
            else if (cmbPlano.Text == "")
            {
                MessageBox.Show("Complete o campo de Planos");
                return;

            }
            else if (cmbDias.Text == "")
            {
                MessageBox.Show("Complete o campo de Dias");
                return;

            }
            else if (txtQuant.Text == "0" || txtQuant.Text.Trim() == "")
            {
                MessageBox.Show("Complete o campo de Quantidade");
                return;

            }

            if (cmbTipoPlan.FindStringExact(cmbTipoPlan.Text) < 0 || cmbPlano.FindStringExact(cmbPlano.Text) < 0 || cmbDias.FindStringExact(cmbDias.Text) < 0)
            {

                MessageBox.Show("Dados selecionados inválidos , selecione somente os itens da lista");
                


                return;

            }
                 



            if (lblTipPlan01.Text == "")
            {
              
                lblTipPlan01.Text = cmbTipoPlan.Text;
                lblPlan01.Text = cmbPlano.Text;
                lblDias01.Text = cmbDias.Text;
                lblQuant01.Text = txtQuant.Text;
                valor = Convert.ToDecimal(cmbDias.SelectedValue);
                lblVal01.Text = ((int.Parse(txtQuant.Text) * valor)).ToString();
                lblValRel01.Text = ((int.Parse(txtQuant.Text) * valor) * decimal.Parse(Variaveis.dolar.Replace(".", ","))).ToString("C3");

              

            }
            else
            {
              
                lblTipPlan03.Text = cmbTipoPlan.Text;
                lblPlan03.Text = cmbPlano.Text;
                lblDias03.Text = cmbDias.Text;
                lblQuant03.Text = txtQuant.Text;
                valor = Convert.ToDecimal(cmbDias.SelectedValue);
                lblValor03.Text = (int.Parse(txtQuant.Text) * valor).ToString();
                lblValResp03.Text = ((int.Parse(txtQuant.Text) * valor) * decimal.Parse(Variaveis.dolar.Replace(".", ","))).ToString("C3");
            }
                         
           
        }

    
        private void cmbTipoPlan_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                

              cmbPlano.DataSource = completarplan.selecionar_categ_planos(cmbTipoPlan.Text);
              cmbPlano.DisplayMember = "PlanNome";
              //cmbPlano.SelectedIndex = 0;
              //dataGridView1.DataSource = completarplan.selecionar_planos(cmbPlano.Text, cmbTipoPlan.Text);

               
              cmbDias.DataSource = completarplan.selecionar_planos(cmbPlano.Text, cmbTipoPlan.Text);
              cmbDias.ValueMember = "AtriValor";
              cmbDias.DisplayMember = "AtriDescri";
              //cmbDias.SelectedIndex = 0;
           
          }catch (Exception) {

              MessageBox.Show("Não foi possível carregar os dados dos planos, é necessário que a conexão com o banco esteje ativa");
           
            }
        
        }
        
        private void frmCotacao_Load(object sender, EventArgs e)
        {
            //Planos completarplan = new Planos();
            //cmbTipoPlan.SelectedIndex = 0;
        }

        private void btnEmiCota01_Click(object sender, EventArgs e)
        {
            if (Variaveis.logado == "não")
            {


                MessageBox.Show("É necessario logar no sistema para emitir a cotação");
                return;

            }



            if (Application.OpenForms.OfType<frmEmitir>().Count() > 0)
            {
                MessageBox.Show("FORMULÁRIO DE EMITIR COTAÇÃO JÁ ESTÁ ABERTO");
                return;

            }
            else if (lblTipPlan01.Text != "")
            {
                Planos_Detalhes.Dias = lblDias01.Text;
                Planos_Detalhes.TipoPlan = lblTipPlan01.Text;
                Planos_Detalhes.Plano = lblPlan01.Text;

                Planos_Detalhes.Quant = lblQuant01.Text;
                Planos_Detalhes.valor = Convert.ToDecimal(lblVal01.Text);

                frmEmitir frmEmitir = new frmEmitir();
           


                frmEmitir.ShowDialog();
            }
            else if (MessageBox.Show("Tipo de plano, plano, dias estão nulos deseja continuar mesmo assim ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                if (Application.OpenForms.OfType<frmEmitir>().Count() > 0)
                {
                    MessageBox.Show("FORMULÁRIO DE EMITIR COTAÇÃO JÁ ESTÁ ABERTO");
                    return;

                }
                else
                {                         
                

                    frmEmitir frmEmitir = new frmEmitir();
                      frmEmitir.ShowDialog();

                }
            }
        }

        private void btnEmiCota02_Click(object sender, EventArgs e)
        {
            if (Variaveis.logado == "não")
            {


                MessageBox.Show("É necessario logar no sistema para emitir a cotação");
                return;

            }



            if (Application.OpenForms.OfType<frmEmitir>().Count() > 0)
            {
                MessageBox.Show("FORMULÁRIO DE EMITIR COTAÇÃO JÁ ESTÁ ABERTO");
                return;

            }
            else if (lblTipPlan03.Text != "")
            {

                Planos_Detalhes.TipoPlan = lblTipPlan03.Text;
                Planos_Detalhes.Plano = lblPlan03.Text;
                Planos_Detalhes.Dias = lblDias03.Text;
                Planos_Detalhes.Quant = lblQuant03.Text;
                Planos_Detalhes.valor = Convert.ToDecimal(lblValor03.Text);

                frmEmitir frmEmitir = new frmEmitir();
            
                frmEmitir.ShowDialog();
            }
            else if (MessageBox.Show("Tipo de plano, plano, dias estão nulos deseja continuar mesmo assim ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {

                if (Application.OpenForms.OfType<frmEmitir>().Count() > 0)
                {
                    MessageBox.Show("FORMULÁRIO DE EMITIR COTAÇÃO JÁ ESTÁ ABERTO");
                    return;

                }
                else
                {                  

                    frmEmitir frmEmitir = new frmEmitir();
                    frmEmitir.ShowDialog();

                }
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            lblDias01.Text = "";
            lblTipPlan01.Text = "";
            lblPlan01.Text = "";
            lblQuant01.Text = "";
            lblVal01.Text = "";
            lblValRel01.Text = "";
            valor = 0;

            Planos_Detalhes.Dias = "";
            Planos_Detalhes.TipoPlan = "";
            Planos_Detalhes.Plano = "";
            Planos_Detalhes.Quant = "";
            Planos_Detalhes.valor = 0;
        }

        private void btnLimpar02_Click(object sender, EventArgs e)
        {
            lblDias03.Text = "";
            lblTipPlan03.Text = "";
            lblPlan03.Text = "";
            lblQuant03.Text = "";
            lblValor03.Text = "";
            lblValResp03.Text = "";
            valor = 0;
            Planos_Detalhes.Dias = "";
            Planos_Detalhes.TipoPlan = "";
            Planos_Detalhes.Plano = "";
            Planos_Detalhes.Quant = "";
            Planos_Detalhes.valor = 0;
        }

        private void cmbPlano_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPlano.FindStringExact(cmbPlano.Text) >= 0)
            {
                cmbDias.DataSource = completarplan.selecionar_planos(cmbPlano.Text, cmbTipoPlan.Text);
                cmbDias.ValueMember = "AtriValor";
                cmbDias.DisplayMember = "AtriDescri";
             //   cmbDias.SelectedIndex = 0;               
            
            
            }
        }

              
    }
}
