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
    public partial class frmCadastroCliente : Form
    {
        ClienteBLL bll = new ClienteBLL();
        ValidaCPF cpf = new ValidaCPF();
        CEP cep = new CEP();

        public frmCadastroCliente()
        {
            InitializeComponent();
        }
        private void CarregaCep()
        {
            try
            {

                DataSet dados = new DataSet();
                string Bairro, Cidade, Endereco;
                dados = cep.Completar_Cep(mtxtCep.Text);
                Bairro = dados.Tables[0].Rows[0]["bairro"].ToString().Trim();
                Cidade = dados.Tables[0].Rows[0]["cidade"].ToString().Trim();
                Endereco = dados.Tables[0].Rows[0]["tipo_logradouro"].ToString().Trim() + " " + dados.Tables[0].Rows[0]["logradouro"].ToString().Trim();

                if (Bairro.Equals("") || Cidade.Equals("") || Endereco.Equals(""))
                {
                   MessageBox.Show("Não foi possivel completar o CEP");
                   return;
                }else {

                txtBairro.Text = Bairro;
                txtCid.Text = Cidade;
                txtEnd.Text = Endereco;
                }

            }catch (Exception)
            
            {
                MessageBox.Show("Não foi possível completar CEP");

            }

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtNome.Text.Trim() == "")
                {
                    MessageBox.Show("Nome Incompleto");
                    txtNome.Focus();
                    return;

                }
                else if (mtxtRg.Text.Replace("-", "").Replace(",", "").Trim().Length < 9)
                {

                    MessageBox.Show("RG Incompleto");
                    return;

                }
               
                else if (cpf.validação(mtxtCpf.Text.Replace("-", "").Replace(",", "").Replace("/", "")) == false)
                {
                    MessageBox.Show("CPF Inválido");
                    return;

                }
                else if (mtxtTel.Text.Replace("(", "").Replace(")", "").Replace("-", "").Length < 10)
                {

                    MessageBox.Show("Telefone Incompleto");
                    return;
                }

                else if (txtEmail.Text.Trim() == "")
                {

                    MessageBox.Show("Email Incompleto");
                    return;


                }
                else if (txtEmail.Text.IndexOf("@") < 2 || txtEmail.Text.IndexOf(".COM") < 0)
                {
                    MessageBox.Show("Email Invalido");
                    return;

                }

                else if (mtxtCep.Text.Replace("-", "").Length < 8)
                {

                    MessageBox.Show("CEP Incompleto");
                    return;

                }
                else if (txtEnd.Text.Trim() == "")
                {

                    MessageBox.Show("Endereço Incompleto");
                    return;

                }

                else if (txtNum.Text.Trim() == "")
                {
                    MessageBox.Show("Número Incompleto");
                    return;

                }
                                       


                else if (txtBairro.Text.Trim() == "")
                {
                    MessageBox.Show("Bairro Incompleto");
                    return;

                }
                else if (txtCid.Text.Trim() == "")
                {

                    MessageBox.Show("Cidade Incompleto");
                    return;
                                                 
                }
              
                else if (cmbEst.Text.Trim() == "")
                {
                    MessageBox.Show("Estado Inválido");
                    return;


                }
              

             

                if (bll.inserir(txtNome.Text, mtxtRg.Text.Replace("-", "").Replace(",", ""), mtxtCpf.Text.Replace("-", "").Replace(",", "").Replace("/", ""), mtxtTel.Text.Replace("(", "").Replace(")", "").Replace("-", ""), txtEmail.Text, mtxtCep.Text.Replace("-", ""), txtEnd.Text, txtNum.Text, txtBairro.Text, txtCid.Text, cmbEst.Text, txtBanco.Text, txtFavo.Text, txtAgen.Text, txtContCor.Text) == false)
                {

                    MessageBox.Show("Cliente já cadastrado");
                    return;
                }
                else
                {

                    MessageBox.Show("Cliente cadastrado com sucesso");
                    limpa_tela();
                }

            }
            catch (Exception)
            {


                MessageBox.Show("Não foi possivel cadastrar o cliente, devido a falta de conexão ativa , contate o administrador");

            }
        }

        private void limpa_tela()
        {

            txtNome.Text = "";
            mtxtCpf.Text = "";
            txtNum.Text = "";
            txtEnd.Text = "";
            txtBairro.Text = "";
            txtCid.Text = "";
            mtxtTel.Text = "";
            mtxtCep.Text = "";
            cmbEst.SelectedIndex = -1;
            txtEmail.Text =  "";
            mtxtRg.Text = "";
            txtBanco.Text = "";
            txtFavo.Text = "";
            txtAgen.Text = "";
            txtContCor.Text = "";
            txtNome.Focus();


        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
          if ((e.KeyChar < 'a' || e.KeyChar > 'z') && (e.KeyChar < 'A' || e.KeyChar > 'Z') &&
                e.KeyChar != 'ã' && e.KeyChar != 'Ã' && e.KeyChar != 'õ' && e.KeyChar != 'Õ' &&
                e.KeyChar != 'ç' && e.KeyChar != 'Ç' && e.KeyChar != 'é' && e.KeyChar != 'É' && e.KeyChar != (char)8 && e.KeyChar != (char)32 && e.KeyChar != (char)13 || e.KeyChar == (char)39)
            {
               e.KeyChar = (Char)0;
            }

            if (e.KeyChar == (char)13)
            {
                mtxtRg.Focus();
            }

            
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)39 || e.KeyChar == (char)32)
            {
               e.KeyChar = (Char)0;
            }
            else if (e.KeyChar == (char)13)
            {
                mtxtCep.Focus();
            }
        }

        private void mtxtRg_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)95)
            {
                e.KeyChar = (Char)0;
            }
            else if (e.KeyChar == (char)13)
            {
                mtxtCpf.Focus();
            }
        }

        private void mtxtCpf_KeyPress(object sender, KeyPressEventArgs e)
        {
                if (e.KeyChar == (char)95)
                {
                    e.KeyChar = (Char)0;
                }
                else if (e.KeyChar == (char)13)
                {
                    mtxtTel.Focus();
                }
        }

        private void mtxtTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)95)
            {
                e.KeyChar = (Char)0;
            }
            else if (e.KeyChar == (char)13)
            {
                txtEmail.Focus();
            }
        }

        private void mtxtCep_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)95)
            {
                e.KeyChar = (Char)0;
            }
            else if (e.KeyChar == (char)13)
            {
                txtEnd.Focus();
            }
        }

        private void txtEnd_KeyPress(object sender, KeyPressEventArgs e)
        {

            if ((e.KeyChar < 'a' || e.KeyChar > 'z') && (e.KeyChar < 'A' || e.KeyChar > 'Z') &&
          e.KeyChar != 'ã' && e.KeyChar != 'Ã' && e.KeyChar != 'õ' && e.KeyChar != 'Õ' &&
          e.KeyChar != 'ç' && e.KeyChar != 'Ç' && e.KeyChar != (char)8 && e.KeyChar != (char)32 && e.KeyChar != (char)13)
            {
                e.KeyChar = (Char)0;
            }

            if (e.KeyChar == (char)13)
            {
                txtNum.Focus();
            }
                      
        }

        private void txtNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != (char)8 && e.KeyChar != (char)13)
            {
                e.KeyChar = (Char)0; 
            }
            if (e.KeyChar == (char)13)
            {
                txtBairro.Focus();
            }
      
        }

        private void txtBairro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 'a' || e.KeyChar > 'z') && (e.KeyChar < 'A' || e.KeyChar > 'Z') &&
          e.KeyChar != 'ã' && e.KeyChar != 'Ã' && e.KeyChar != 'õ' && e.KeyChar != 'Õ' &&
          e.KeyChar != 'ç' && e.KeyChar != 'Ç' && e.KeyChar != (char)8 && e.KeyChar != (char)32 && e.KeyChar != (char)13)
            {
                e.KeyChar = (Char)0;
            }

            if (e.KeyChar == (char)13)
            {
                txtCid.Focus();
            }
        }

        private void txtCid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 'a' || e.KeyChar > 'z') && (e.KeyChar < 'A' || e.KeyChar > 'Z') &&
         e.KeyChar != 'ã' && e.KeyChar != 'Ã' && e.KeyChar != 'õ' && e.KeyChar != 'Õ' &&
         e.KeyChar != 'ç' && e.KeyChar != 'Ç' && e.KeyChar != (char)8 && e.KeyChar != (char)32 && e.KeyChar != (char)13)
            {
                e.KeyChar = (Char)0;
            }
            else if (e.KeyChar == (char)13)
            {
                cmbEst.Focus();
            }          
        }
           

      
        private void txtBanco_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 'a' || e.KeyChar > 'z') && (e.KeyChar < 'A' || e.KeyChar > 'Z') &&
         e.KeyChar != 'ã' && e.KeyChar != 'Ã' && e.KeyChar != 'õ' && e.KeyChar != 'Õ' &&
         e.KeyChar != 'ç' && e.KeyChar != 'Ç' && e.KeyChar != (char)8 && e.KeyChar != (char)32 && e.KeyChar != (char)13)
            {
                e.KeyChar = (Char)0;
            }

            if (e.KeyChar == (char)13)
            {
                txtFavo.Focus();
            }
        }

        private void txtFavo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 'a' || e.KeyChar > 'z') && (e.KeyChar < 'A' || e.KeyChar > 'Z') &&
         e.KeyChar != 'ã' && e.KeyChar != 'Ã' && e.KeyChar != 'õ' && e.KeyChar != 'Õ' &&
         e.KeyChar != 'ç' && e.KeyChar != 'Ç' && e.KeyChar != (char)8 && e.KeyChar != (char)32 && e.KeyChar != (char)13)
            {
                e.KeyChar = (Char)0;
            }

            if (e.KeyChar == (char)13)
            {
                txtAgen.Focus();
            }
        }
             
        private void txtAgen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != (char)8 && e.KeyChar != (char)13)
            {
                e.KeyChar = (Char)0; 
            }
            if (e.KeyChar == (char)13)
            {
                txtContCor.Focus();
            }
              
        }

        private void txtContCor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != (char)8 && e.KeyChar != (char)13)
            {
                e.KeyChar = (Char)0;
            }
            else if (e.KeyChar == (char)13)
            {
               btnCadastrar.Focus();
            }
        }

        private void cmbEst_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                txtBanco.Focus();
            }
        }

        private void btnCompCep_Click(object sender, EventArgs e)
        {
            CarregaCep();
        }

        

          
                               
         
    }
}
