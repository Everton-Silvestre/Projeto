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
    public partial class frmAlterarAgencia : Form
    {
        AgenciaBLL agencia = new AgenciaBLL();
        ValidaCNPJ cnpj = new ValidaCNPJ();


        public frmAlterarAgencia()
        {
            InitializeComponent();
        }

        private void frmAlterarAgencia_Load(object sender, EventArgs e)
        {
            
            DataRow dados,senha;

            try
            {
                dados = agencia.selecionar_agencia(Variaveis.login, Variaveis.senha).Rows[0];
                senha = agencia.selecionar_senha(Variaveis.login, Variaveis.senha).Rows[0];
                txtCod.Text = dados["AgenCod"].ToString();
                txtRazSoc.Text = dados["AgenRazSoc"].ToString();
                txtNomFant.Text = dados["AgenNomFant"].ToString();
                mtxtCnpj.Text = dados["AgenCnpj"].ToString();
                mtxtCep.Text = dados["AgenCep"].ToString().PadLeft(8, '0');
                txtNum.Text = dados["AgenEndNum"].ToString();
                //textBox4.Text = cliente.selecionar_cliente().Rows[0]["CliTel"].ToString();
                txtEnd.Text = dados["AgenEnd"].ToString();
                txtBairro.Text = dados["AgenBairro"].ToString();
                txtCid.Text = dados["AgenCid"].ToString();
                mtxtTel.Text = dados["AgenTel"].ToString();
                cmbEst.Text = dados["AgenEst"].ToString();
                txtEmail.Text = dados["AgenEmail"].ToString();
                txtRespCad.Text = dados["AgenRespCad"].ToString();
                mskRgAt.Text = dados["AgenRgResp"].ToString();
                txtSuplente.Text = dados["AgenNomSuple"].ToString();
                mskRgSu.Text = dados["AgenRgSuple"].ToString();
                txtBanco.Text = dados["AgenBan"].ToString();
                txtFavo.Text = dados["AgenFavo"].ToString();
                txtAgen.Text = dados["AgenNro"].ToString();
                txtContCor.Text = dados["AgenContCor"].ToString();
                txtSenha.Text = senha["UsuSen"].ToString();
                //txtFavo.Text = dados["CliFavo"].ToString();*/
            }
            catch
            {

                MessageBox.Show("Não foi possível carregar os dados contate o administrador");
                //this.Close();

            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
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

                else if (txtSenha.Text.Trim() == "")
                {

                    MessageBox.Show("Senha nula");
                    return;
                }

                else if (txtSenha.Text.Length < 8)
                {

                    MessageBox.Show("A senha necessita de no mínimo 8 caracteres");
                    return;
                }

                else if (mskRgAt.Text.Replace("-", "").Replace(",", "").Trim().Length < 9)
                {

                    MessageBox.Show("RG do Responsável pelo cadastro Incompleto");
                    return;

                }
             
                if (agencia.atualizar_agencia(int.Parse(txtCod.Text),txtRazSoc.Text, txtNomFant.Text, mtxtCnpj.Text.Replace("-", "").Replace(",", "").Replace("/", ""), mtxtCep.Text.Replace("-", ""), txtEnd.Text, txtBairro.Text, txtCid.Text, mtxtTel.Text.Replace("(", "").Replace(")", "").Replace("-", ""), cmbEst.Text, txtEmail.Text, txtRespCad.Text, txtBanco.Text, txtFavo.Text, txtAgen.Text, txtContCor.Text, txtRespCad.Text, mskRgAt.Text.Replace("-", "").Replace(",", ""), txtSuplente.Text, mskRgSu.Text.Replace("-", "").Replace(",", ""),txtSenha.Text,Variaveis.senha,int.Parse(txtNum.Text))== false)
                {
                    MessageBox.Show("Agência já cadastrado");
                    return;
                }
                else
                {
                    Variaveis.login = txtEmail.Text;
                    Variaveis.senha = txtSenha.Text;
                    MessageBox.Show("Agência Alterada com Sucesso");
                    this.Close();
                    
                }

            }
           catch (Exception)
            {


                MessageBox.Show("Não foi possivel atualizar a agência, contate o administrador");

           }
        }

        private void limpa_tela()
        {

            txtRazSoc.Text = "";
            mtxtCnpj.Text = "";
            txtNomFant.Text = "";
            txtEnd.Text = "";
            txtBairro.Text = "";
            txtCid.Text = "";
            mtxtTel.Text = "";
            mtxtCep.Text = "";
            cmbEst.SelectedIndex = -1;
            txtEmail.Text = "";
            txtRespCad.Text = "";
            txtBanco.Text = "";
            txtFavo.Text = "";
            txtAgen.Text = "";
            txtContCor.Text = "";
            txtRespCad.Text = "";


            txtRazSoc.Focus();
            mskRgAt.Text = "";
            txtSuplente.Text = "";
            mskRgSu.Text = "";


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

        private void cmbEst_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                txtEmail.Focus();
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
                txtSenha.Focus();
            }
        }

        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)39)
            {
                e.KeyChar = (Char)0;
            }
            else if (e.KeyChar == (char)13)
            {
                txtRespCad.Focus();
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
                btnAlterar.Focus();
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

            
        
    }
}
