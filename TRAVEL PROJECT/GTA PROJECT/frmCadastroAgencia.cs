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
    public partial class frmCadastroAgencia : Form
    {
        AgenciaBLL bll = new AgenciaBLL();
        ValidaCNPJ cnpj = new ValidaCNPJ();
        CEP cep = new CEP();


        public frmCadastroAgencia()
        {
            InitializeComponent();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
          
            try
            {

                if (txtRazSoc.Text.Trim() == "")
                {
                    MessageBox.Show("Razão Social Incompleto");
                    txtRazSoc.Focus();
                    return;

                }
                else if (txtNomFant.Text.Trim() == "")
                {
                    MessageBox.Show("Nome Fantasia Incompleto");
                    return;

                }
                else if (cnpj.validação(mtxtCnpj.Text.Replace("-", "").Replace(",", "").Replace("/", "")) == false)
                {
                    MessageBox.Show("CNPJ Inválido");
                    return;

                }
                else if (mtxtCep.Text.Length < 8)
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
                else if (mtxtTel.Text.Length < 10)
                {

                    MessageBox.Show("Telefone Incompleto");
                    return;

                }
                else if (cmbEst.Text.Trim() == "")
                {
                    MessageBox.Show("Estado Inválido");
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

                else if (txtRespCad.Text.Trim() == "")
                {

                    MessageBox.Show("Responsável pelo cadastro Incompleto");
                    return;

                }

                else if (mskRgAt.Text.Replace("-", "").Replace(",", "").Trim().Length < 9)
                {

                    MessageBox.Show("RG do Responsável pelo cadastro Incompleto");
                    return;

                }

                if (bll.inserir(txtRazSoc.Text, txtNomFant.Text, mtxtCnpj.Text.Replace("-", "").Replace(",", "").Replace("/", ""), mtxtCep.Text.Replace("-", ""), txtEnd.Text, txtBairro.Text, txtCid.Text, mtxtTel.Text.Replace("(", "").Replace(")", "").Replace("-", ""), cmbEst.Text, txtEmail.Text, txtRespCad.Text, txtBanco.Text, txtFavo.Text, txtAgen.Text, txtContCor.Text, txtRespCad.Text, mskRgAt.Text.Replace("-", "").Replace(",", ""), txtSuplente.Text, mskRgSu.Text.Replace("-", "").Replace(",", ""),int.Parse(txtNum.Text)) == false)
                {

                    MessageBox.Show("Agência já cadastrada");
                    return;
                }
                else
                {

                    MessageBox.Show("Agência cadastrada com sucesso");
                    limpa_tela();
                }

            }
            catch (Exception)
            {


                MessageBox.Show("Não foi possivel cadastrar a agência, contate o administrador");

            }
        }
      
        private void limpa_tela()
        {

            txtRazSoc.Text = "";
            mtxtCnpj.Text = "";
            txtNomFant.Text = "";
            txtNum.Text = "";
            txtEnd.Text = "";
            txtBairro.Text="";
            txtCid.Text="";
            mtxtTel.Text = "";
            mtxtCep.Text = "";
            cmbEst.SelectedIndex = -1;
            txtEmail.Text = "";
            txtRespCad.Text = "";
            txtBanco.Text = "";
            txtFavo.Text= "";
            txtAgen.Text = "";
            txtContCor.Text = "";
            txtRespCad.Text = "";
       
                       
            txtRazSoc.Focus();
            mskRgAt.Text = "";
            txtSuplente.Text = "";
            mskRgSu.Text = "";
          
         
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
              

        private void btnComCep_Click(object sender, EventArgs e)
        {
            CarregaCep();
        }

        private void mtxtCnpj_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)95)
            {
                e.KeyChar = (Char)0;
            }
            else if (e.KeyChar == (char)13)
            {
                mtxtCep.Focus();
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
                cmbEst.Focus();
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

        private void txtRazSoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 'a' || e.KeyChar > 'z') && (e.KeyChar < 'A' || e.KeyChar > 'Z') &&
               e.KeyChar != 'ã' && e.KeyChar != 'Ã' && e.KeyChar != 'õ' && e.KeyChar != 'Õ' &&
               e.KeyChar != 'ç' && e.KeyChar != 'Ç' && e.KeyChar != (char)8 && e.KeyChar != (char)32 && e.KeyChar != (char)13 || e.KeyChar == (char)39)
            {
                e.KeyChar = (Char)0;
            }
            else if (e.KeyChar == (char)13)
            {
                txtNomFant.Focus();
            }
          
        }

        private void txtNomFant_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 'a' || e.KeyChar > 'z') && (e.KeyChar < 'A' || e.KeyChar > 'Z') &&
              e.KeyChar != 'ã' && e.KeyChar != 'Ã' && e.KeyChar != 'õ' && e.KeyChar != 'Õ' &&
              e.KeyChar != 'ç' && e.KeyChar != 'Ç' && e.KeyChar != (char)8 && e.KeyChar != (char)32 && e.KeyChar != (char)13 || e.KeyChar == (char)39)
            {
                e.KeyChar = (Char)0;
            }
            else if (e.KeyChar == (char)13)
            {
                mtxtCnpj.Focus();
            }

        }

        private void txtEnd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 'a' || e.KeyChar > 'z') && (e.KeyChar < 'A' || e.KeyChar > 'Z') &&
              e.KeyChar != 'ã' && e.KeyChar != 'Ã' && e.KeyChar != 'õ' && e.KeyChar != 'Õ' &&
              e.KeyChar != 'ç' && e.KeyChar != 'Ç' && e.KeyChar != (char)8 && e.KeyChar != (char)32 && e.KeyChar != (char)13 || e.KeyChar == (char)39)
            {
                e.KeyChar = (Char)0;
            }
            else if (e.KeyChar == (char)13)
            {
                txtNum.Focus();
            }

     
        }

        private void txtBairro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 'a' || e.KeyChar > 'z') && (e.KeyChar < 'A' || e.KeyChar > 'Z') &&
              e.KeyChar != 'ã' && e.KeyChar != 'Ã' && e.KeyChar != 'õ' && e.KeyChar != 'Õ' &&
              e.KeyChar != 'ç' && e.KeyChar != 'Ç' && e.KeyChar != (char)8 && e.KeyChar != (char)32 && e.KeyChar != (char)13 || e.KeyChar == (char)39)
            {
                e.KeyChar = (Char)0;
            }
            else if (e.KeyChar == (char)13)
            {
                txtCid.Focus();
            }
        }

        private void txtCid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 'a' || e.KeyChar > 'z') && (e.KeyChar < 'A' || e.KeyChar > 'Z') &&
              e.KeyChar != 'ã' && e.KeyChar != 'Ã' && e.KeyChar != 'õ' && e.KeyChar != 'Õ' &&
              e.KeyChar != 'ç' && e.KeyChar != 'Ç' && e.KeyChar != (char)8 && e.KeyChar != (char)32 && e.KeyChar != (char)13 || e.KeyChar == (char)39)
            {
                e.KeyChar = (Char)0;
            }
            else if (e.KeyChar == (char)13)
            {
                mtxtTel.Focus();
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
                txtRespCad.Focus();
            }

        }

        private void txtBanco_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 'a' || e.KeyChar > 'z') && (e.KeyChar < 'A' || e.KeyChar > 'Z') &&
              e.KeyChar != 'ã' && e.KeyChar != 'Ã' && e.KeyChar != 'õ' && e.KeyChar != 'Õ' &&
              e.KeyChar != 'ç' && e.KeyChar != 'Ç' && e.KeyChar != (char)8 && e.KeyChar != (char)32 && e.KeyChar != (char)13 || e.KeyChar == (char)39)
            {
                e.KeyChar = (Char)0;
            } if (e.KeyChar == (char)95)
            {
                e.KeyChar = (Char)0;
            }
            else if (e.KeyChar == (char)13)
            {
                txtFavo.Focus();
            }
                     
        }

        private void txtFavo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 'a' || e.KeyChar > 'z') && (e.KeyChar < 'A' || e.KeyChar > 'Z') &&
              e.KeyChar != 'ã' && e.KeyChar != 'Ã' && e.KeyChar != 'õ' && e.KeyChar != 'Õ' &&
              e.KeyChar != 'ç' && e.KeyChar != 'Ç' && e.KeyChar != (char)8 && e.KeyChar != (char)32 && e.KeyChar != (char)13 || e.KeyChar == (char)39)
            {
                e.KeyChar = (Char)0;
            } if (e.KeyChar == (char)95)
            {
                e.KeyChar = (Char)0;
            }
            else if (e.KeyChar == (char)13)
            {
                txtAgen.Focus();
            }
                                   
        }

        private void txtAgen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != ',' && e.KeyChar != (char)8 && e.KeyChar != (char)13)
            {
              
                e.KeyChar = (Char)0;
            } if (e.KeyChar == (char)95)
            {
                e.KeyChar = (Char)0;
            }
            else if (e.KeyChar == (char)13)
            {
                txtContCor.Focus();
            }
        
        }

        private void txtContCor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != ',' && e.KeyChar != (char)8 && e.KeyChar != (char)13)
            {
               e.KeyChar = (Char)0;
            } if (e.KeyChar == (char)95)
            {
                e.KeyChar = (Char)0;
            }
            else if (e.KeyChar == (char)13)
            {
                btnCadastrar.Focus();
            }
     
        }
                    

        private void txtRespCad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 'a' || e.KeyChar > 'z') && (e.KeyChar < 'A' || e.KeyChar > 'Z') &&
               e.KeyChar != 'ã' && e.KeyChar != 'Ã' && e.KeyChar != 'õ' && e.KeyChar != 'Õ' &&
               e.KeyChar != 'ç' && e.KeyChar != 'Ç' && e.KeyChar != (char)8 && e.KeyChar != (char)32 && e.KeyChar != (char)13 || e.KeyChar == (char)39)
            {
                e.KeyChar = (Char)0;
            }
            else if (e.KeyChar == (char)13)
            {
                mskRgAt.Focus();
            }
        }

        private void txtSuplente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 'a' || e.KeyChar > 'z') && (e.KeyChar < 'A' || e.KeyChar > 'Z') &&
               e.KeyChar != 'ã' && e.KeyChar != 'Ã' && e.KeyChar != 'õ' && e.KeyChar != 'Õ' &&
               e.KeyChar != 'ç' && e.KeyChar != 'Ç' && e.KeyChar != (char)8 && e.KeyChar != (char)32 && e.KeyChar != (char)13 || e.KeyChar == (char)39)
            {
                e.KeyChar = (Char)0;
            }  
            else if (e.KeyChar == (char)13)
            {
                mskRgSu.Focus();
            }
          
        }

        private void cmbEst_KeyPress(object sender, KeyPressEventArgs e)
        {
             if (e.KeyChar == (char)13)
            {
                txtEmail.Focus();
            }
        }

        private void mskRgAt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)95)
            {
                e.KeyChar = (Char)0;
            }
            else if (e.KeyChar == (char)13)
            {
                txtSuplente.Focus();
            }
        }

        private void mskRgSu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)95)
            {
                e.KeyChar = (Char)0;
            }
            else if (e.KeyChar == (char)13)
            {
                txtBanco.Focus();
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

        private void txtNum_TextChanged(object sender, EventArgs e)
        {

        }

        private void gpCadAgen_Click(object sender, EventArgs e)
        {

        }

      
                           
             
    }
}

