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
    public partial class frmAlterarCliente : Form
    {
        ClienteBLL cliente = new ClienteBLL();
        UsuarioBLL usuario = new UsuarioBLL();
        ValidaCPF cpf = new ValidaCPF();
        
        public frmAlterarCliente()
        {
            InitializeComponent();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtNome.Text.Trim() == "")
                {
                    MessageBox.Show("Nome Incompleto");
                    txtNome.Focus();
                    return;

                }
                else if (txtEnd.Text.Trim() == "")
                {
                    MessageBox.Show("Endereço Incompleto");
                    return;

                }
                else if (cpf.validação(mskCpf.Text.Replace("-", "").Replace(",", "").Replace("/", "")) == false)
                {
                    MessageBox.Show("CPF Inválido");
                    return;

                }
                else if (mskCep.Text.Replace("-", "").Length < 8)
                {

                    MessageBox.Show("CEP Incompleto");
                    return;

                }
                else if (txtEnd.Text.Trim() == "")
                {

                    MessageBox.Show("Endereço Incompleto");
                    return;

                }
                else if (txtEndNro.Text.Trim() == "")
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
                else if (mskTel.Text.Replace("(", "").Replace(")", "").Replace("-", "").Length < 10)
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

                else if (txtSenha.Text.Trim() == "")
                {

                    MessageBox.Show("Senha nula");
                    return;
                }

                else if (txtSenha.Text.Length < 8 )
                {

                    MessageBox.Show("A senha necessita de no mínimo 8 caracteres");
                    return;
                }

              /* else if (usuario.verifica_senha_cli(txtSenha.Text,txtEmail.Text))
                {

                    MessageBox.Show("Senha já cadastrada");
                    return;
                }*/
                                        

                else if (mskRg.Text.Replace("-", "").Replace(",", "").Trim().Length < 9)
                {

                    MessageBox.Show("RG Incompleto");
                    return;

                }

                if (cliente.atualizar_cliente(int.Parse(txtCliCod.Text), txtNome.Text, txtEnd.Text, txtEndNro.Text, mskTel.Text.Replace("(", "").Replace(")", "").Replace("-", ""), mskCpf.Text.Replace("-", "").Replace(",", "").Replace("/", ""), mskRg.Text.Replace("-", "").Replace(",", ""), txtCid.Text, cmbEst.Text, txtEmail.Text, mskCep.Text.Replace("-", ""), txtBairro.Text, txtBan.Text, txtFavo.Text, txtAgen.Text, txtCorren.Text,txtSenha.Text) == false)
                {
                    MessageBox.Show("Cliente já cadastrado");
                    return;

                }
                else
                {

                    MessageBox.Show("Cliente Alterado com Sucesso");
                    Variaveis.login = txtEmail.Text;
                    Variaveis.senha = txtSenha.Text;
                    this.Close();
                }
                // MessageBox.Show("Cliente atualizado com sucesso");
            }
            catch (Exception)
            {
                MessageBox.Show("Cliente não atualizado");

            }
        }

        private void frmAlterarCliente_Load(object sender, EventArgs e)
        {
            DataRow dados,senha;
            

            try
             {
                dados = cliente.selecionar_cliente(Variaveis.login).Rows[0];
                senha = cliente.selecionar_cliente(Variaveis.login, Variaveis.senha).Rows[0];
                txtCliCod.Text = dados["CliCod"].ToString();
                txtNome.Text = dados["CliNome"].ToString();
                txtEnd.Text = dados["CliEnd"].ToString();
                txtEndNro.Text = dados["CliEndNro"].ToString();
                //textBox4.Text = cliente.selecionar_cliente().Rows[0]["CliTel"].ToString();
                mskCpf.Text = dados["CliCpf"].ToString();
                mskRg.Text = dados["CliRg"].ToString();
                mskTel.Text = dados["CliTel"].ToString();
                txtCid.Text = dados["CliCid"].ToString();
                cmbEst.Text = dados["CliEst"].ToString();
                txtEmail.Text = dados["CliEmail"].ToString();
                mskCep.Text = dados["CliCep"].ToString().PadLeft(8, '0');
                txtBairro.Text = dados["CliBairro"].ToString();
                txtBan.Text = dados["CliBan"].ToString();
                txtFavo.Text = dados["CliFavo"].ToString();
                txtAgen.Text = dados["CliAgen"].ToString();
                txtCorren.Text = dados["CliCorren"].ToString();
                txtSenha.Text = senha["UsuSenha"].ToString();
                //txtFavo.Text = dados["CliFavo"].ToString();
            }
catch
            {

                MessageBox.Show("Não foi possível carregar os dados contate o administrador");
                //this.Close();

            }
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
                mskRg.Focus();
            }
        }

        private void mskRg_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)95)
            {
                e.KeyChar = (Char)0;
            }
            else if (e.KeyChar == (char)13)
            {
                mskCpf.Focus();
            }
        }

        private void mskCpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)95)
            {
                e.KeyChar = (Char)0;
            }
            else if (e.KeyChar == (char)13)
            {
                mskTel.Focus();
            }
        }

        private void mskTel_KeyPress(object sender, KeyPressEventArgs e)
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

        private void mskCep_KeyPress(object sender, KeyPressEventArgs e)
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
                txtEndNro.Focus();
            }
        }

        private void txtEndNro_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtBan_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtAgen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != (char)8 && e.KeyChar != (char)13)
            {
                e.KeyChar = (Char)0;
            }
            if (e.KeyChar == (char)13)
            {
                txtCorren.Focus();
            }
        }

        private void txtCorren_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != (char)8 && e.KeyChar != (char)13)
            {
                e.KeyChar = (Char)0;
            }
            else if (e.KeyChar == (char)13)
            {
               btnAlterar.Focus();
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

        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)39)
            {
                e.KeyChar = (Char)0;
            }
            else if (e.KeyChar == (char)13)
            {
                mskCep.Focus();
            }
        }

        private void cmbEst_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                txtBan.Focus();
            }
        }

         
                
           }
}
