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
    public partial class frmLogar : Form
    {
        AgenciaBLL bll = new AgenciaBLL();
        ClienteBLL cliente = new ClienteBLL();
        UsuarioBLL usuario = new UsuarioBLL();
        string nivel="";


        public frmLogar()
        {
            InitializeComponent();
        }

        private void frmLogar_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = bll.selecionar_agencia();
            comboBox1.DisplayMember = "AgenNomFant";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {

                groupBox3.Visible = false;
                groupBox2.Visible = true;


            }
        }


        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
            {

                lblTitu.Visible = true;
                lblSuplen.Visible = false;
                maskedTextBox1.Clear();
                maskedTextBox1.Visible = true;
                nivel = "R";


            }
        }
        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true) {

                lblTitu.Visible = false;
                lblSuplen.Visible = true;
                maskedTextBox1.Clear();
                maskedTextBox1.Visible = true;
                nivel = "S";

            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {

                groupBox3.Visible = true;
                groupBox2.Visible = false;

            }  
        

        }

      

        private void txtEmailCli_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)39 || e.KeyChar == (char)32)
            {
                e.KeyChar = (Char)0;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)39)
            {
                e.KeyChar = (Char)0;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)39)
            {
                e.KeyChar = (Char)0;
            }

        }

        private void txtEmailResp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)39 || e.KeyChar == (char)32)
            {
                e.KeyChar = (Char)0;
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)39)
            {
                e.KeyChar = (Char)0;
            }
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)39)
            {
                e.KeyChar = (Char)0;
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == false && radioButton2.Checked == false)
            {

                MessageBox.Show("Selecione uma das opções ");


            }

            if (radioButton2.Checked == true)
            {


                if (txtEmailCli.Text.IndexOf("@") < 2 || txtEmailCli.Text.IndexOf(".COM") < 0)
                {
                    MessageBox.Show("Email Invalido");
                    return;

                }

                else if (cliente.selecionar_email_cli(txtEmailCli.Text) == "")
                {
                    MessageBox.Show("Email não cadastrado na base de dados");
                    return;
                }

                else if (usuario.email_repetido(txtEmailCli.Text))
                {
                    MessageBox.Show("Email já cadastrado na base de dados");
                    return;
                }

                else if (textBox1.Text != textBox2.Text || (textBox2.Text == "" && textBox2.Text == ""))
                {

                    MessageBox.Show("Senhas incompativeis ou nulas");
                    return;
                }

                else if (textBox1.Text.Length < 8 || textBox2.Text.Length < 8)
                {

                    MessageBox.Show("A senha necessita de no mínimo 8 caracteres");
                    return;
                }

                else if (usuario.verifica_senha_agen(textBox1.Text))
                {

                    MessageBox.Show("Senha já cadastrada");
                    return;
                }


                MessageBox.Show(usuario.inserir_usuario_cli(txtEmailCli.Text, textBox1.Text, cliente.selecionar_email_cli(txtEmailCli.Text)));

                txtEmailCli.Clear();
                textBox1.Clear();
                textBox2.Clear();
                groupBox3.Visible = false;
                radioButton2.Checked = false;


            }
            else if (radioButton1.Checked == true)
            {

                if (txtEmailResp.Text.IndexOf("@") < 2 || txtEmailResp.Text.IndexOf(".COM") < 0)
                {
                    MessageBox.Show("Email Invalido");
                    return;

                }

                else if (bll.selecionar_email(txtEmailResp.Text, comboBox1.Text) == "")
                {
                    MessageBox.Show("Email incorreto pois não corresponde a agencia selecionada");
                    return;
                }


                else if (radioButton3.Checked == false && radioButton4.Checked == false)
                {
                    MessageBox.Show("Selecione uma opção de responsabilidade");
                    return;
                }

                else if (radioButton3.Checked == true && radioButton4.Checked == false && maskedTextBox1.Text.Replace("-", "").Replace(",", "").Trim().Length < 9)
                {
                    MessageBox.Show("Complete o RG do Responsavel");
                    return;
                }
                else if (radioButton3.Checked == false && radioButton4.Checked == true && maskedTextBox1.Text.Replace("-", "").Replace(",", "").Trim().Length < 9)
                {
                    MessageBox.Show("Complete o RG do Suplente");
                    return;
                }


                else if (usuario.nivel_repetido(txtEmailResp.Text, nivel))
                {

                    MessageBox.Show("Responsável/ Suplente já possui(em) um login e senha");
                    return;


                }


                else if (radioButton3.Checked == true && radioButton4.Checked == false && !usuario.verifica_rg_resp(maskedTextBox1.Text.Replace("-", "").Replace(",", "").Trim()))
                {

                    MessageBox.Show("RG do responsavel não compativel, verifique !!");
                    return;



                }


                else if (radioButton3.Checked == false && radioButton4.Checked == true && !usuario.verifica_rg_suplen(maskedTextBox1.Text.Replace("-", "").Replace(",", "").Trim()))
                {

                    MessageBox.Show("RG do Suplente não compativel, verifique !!");
                    return;



                }


                else if (textBox5.Text != textBox6.Text || (textBox6.Text == "" && textBox6.Text == ""))
                {

                    MessageBox.Show("Senhas incompativeis ou nulas");
                    return;
                }

                else if (textBox5.Text.Length < 8 || textBox6.Text.Length < 8)
                {

                    MessageBox.Show("A senha necessita de no mínimo 8 caracteres");
                    return;
                }

                else if (usuario.verifica_senha_agen(textBox5.Text))
                {

                    MessageBox.Show("Senha já cadastrada");
                    return;
                }

                MessageBox.Show(usuario.inserir_usuario_agen(txtEmailResp.Text, textBox5.Text, cliente.selecionar_email_agen(txtEmailResp.Text), nivel));

                txtEmailResp.Clear();
                comboBox1.SelectedIndex = -1;
                radioButton3.Checked = false;
                radioButton4.Checked = false;
                maskedTextBox1.Clear();
                textBox5.Clear();
                textBox6.Clear();
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                groupBox2.Visible = false;



            }
        }
             
    }
}
