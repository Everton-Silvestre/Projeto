using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using BLL;
using System;


namespace GTA_PROJECT
{

    public partial class frmMenu : Form
    {

        string url;
        UsuarioBLL usuario = new UsuarioBLL();
        ClienteBLL cliente = new ClienteBLL();


        public frmMenu()
        {
/*Thread t = new Thread(new ThreadStart(SplashScreen));
            t.Start();

            try
            {
              /*  ServiceReference.FachadaWSSGSClient webservice = new ServiceReference.FachadaWSSGSClient();
                var valores_dor_venda = webservice.getUltimosValoresSerieVO(1, 1);
                var valores_dor_compra = webservice.getUltimosValoresSerieVO(10813, 1);
                var ultimo = valores_dor_venda.valores[0];
                var ultimo2 = valores_dor_compra.valores[0];
                InitializeComponent();
                menubar.Visible = true;
                labelItem2.Text = "R$" + ultimo.svalor.ToString();
                labelItem1.Text = "R$" + ultimo2.svalor.ToString();
                Variaveis.dolar = ultimo.svalor;
                Thread.Sleep(3000);
                t.Abort();

            }
            catch (Exception)
            {

                InitializeComponent();
                menubar.Visible = true;
                Variaveis.dolar = "0";
                Thread.Sleep(3000);
                t.Abort();
                MessageBox.Show("Erro ao conectar-se a internet , devido a falta dela algumas funções do sistema não seram realizadas");
            }

            finally {

            
            }
           /* InitializeComponent();
            menubar.Visible = true;
            Thread.Sleep(5000);
            t.Abort(); */
            InitializeComponent();
            menubar.Visible = true;
        }


        public void SplashScreen()
        {


            Application.Run(new frmSplashScreen());


        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
try
            {
                ServiceReference.FachadaWSSGSClient webservice = new ServiceReference.FachadaWSSGSClient();
                var valores_dor_venda = webservice.getUltimosValoresSerieVO(1, 1);
                var valores_dor_compra = webservice.getUltimosValoresSerieVO(10813, 1);
                var ultimo = valores_dor_venda.valores[0];
                var ultimo2 = valores_dor_compra.valores[0];
                labelItem2.Text = "R$" + ultimo.svalor.ToString();
                labelItem1.Text = "R$" + ultimo2.svalor.ToString();
                Variaveis.dolar = ultimo.svalor; 

            }
            catch (Exception)
            {

                MessageBox.Show("Erro ao conectar-se a internet , devido a falta dela algumas funções do sistema não seram realizadas");
                Variaveis.dolar = "0"; 
            }

       

        }


        private void tsbtnOk_Click(object sender, EventArgs e)
        {

            if (tstxtLogin.Text.Trim() == "")
            {
                MessageBox.Show("Informar o Login");
                return;
            }

            else if (tstxtLogin.Text.IndexOf("@") < 2 || tstxtLogin.Text.IndexOf(".COM") < 0)
            {
                MessageBox.Show("Login Invalido");
                return;

            }
            else if (tstxtSenha.Text.Trim() == "")
            {
                MessageBox.Show("Informar a Senha");
                return;
            }
            else if (tstcmbMod.Text.Trim() == "" || (tstcmbMod.Text.Trim() != "Cliente" && tstcmbMod.Text.Trim() != "Agência"))
            {
                MessageBox.Show("Modo de acesso incorreto, verifique ");

                return;


            }

            if (tstcmbMod.Text == "Cliente")
            {
                if (usuario.logarcli(tstxtLogin.Text, tstxtSenha.Text))
                {
                    frmCadastroCliente frmcli = new frmCadastroCliente();
                    ClienteBLL cliente = new ClienteBLL();
                    frmPlanoInternacinal internacional = new frmPlanoInternacinal();
                    usuario.inserir_controle_log(tstxtLogin.Text, tstxtSenha.Text);
                    StatusStripIni.Visible = true;
                    btnLogOff.Enabled = true;
                    Cadastro.Enabled = false;
                    expandablePanel2.Visible = false;
                    Variaveis.logado = "sim";
                    Variaveis.login = tstxtLogin.Text;
                    Variaveis.senha = tstxtSenha.Text;
                    Variaveis.modacesso = tstcmbMod.Text;
                    btnAlterar.Enabled = true;
                    btnAltCli.Enabled = true;
                    MessageBox.Show("Logado com Sucesso");

                }
                else MessageBox.Show("Login / Senha Invalidos , ou modo de acesso errado");

            }
            else if (tstcmbMod.Text == "Agência")
            {

                if (usuario.logar_agen(tstxtLogin.Text, tstxtSenha.Text))
                {
                    frmCadastroCliente frmcli = new frmCadastroCliente();
                    usuario.inserir_controle_log(tstxtLogin.Text, tstxtSenha.Text);
                    Variaveis.login = tstxtLogin.Text;
                    Variaveis.senha = tstxtSenha.Text;
                    Variaveis.modacesso = tstcmbMod.Text;
                    Variaveis.logado = "sim";                    
                    StatusStripIni.Visible = true;
                    btnLogOff.Enabled = true;
                    btnAlterar.Enabled = true;
                    btnAltAgen.Enabled = true;
                    Cadastro.Enabled = false;
                    expandablePanel2.Visible = false;
                    MessageBox.Show("Logado com Sucesso");    
                
                }
                else MessageBox.Show("Login / Senha Invalidos, ou modo de acesso errado");

            }

        }
  

        private void tslblCad_Click(object sender, EventArgs e)
        {
            frmLogar frmLogar = new frmLogar();
            frmLogar.MdiParent = this;
            frmLogar.Show();
        }
        
               

        private void AltCli_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmAlterarCliente>().Count() > 0)
            {
                MessageBox.Show("FORMULÁRIO DE ALTERAR CLIENTE JÁ ESTÁ ABERTO");
                return;

            }
            else
            {

                frmAlterarCliente frmLogar = new frmAlterarCliente();
                frmLogar.MdiParent = this;
                frmLogar.Show();
            }
        }

      
        private void CadCli_Click(object sender, EventArgs e)
        {


            if (Application.OpenForms.OfType<frmCadastroCliente>().Count() > 0)
            {
                MessageBox.Show("FORMULÁRIO DE CADASTRO DE CLIENTES JÁ ESTÁ ABERTO");
                return;

            }
        
            else
            {

                frmCadastroCliente frmCliente = new frmCadastroCliente();
                frmCliente.MdiParent = this;
                frmCliente.Show();

            }
        }

        private void CadAgencia_Click(object sender, EventArgs e)
        {
            
            if (Application.OpenForms.OfType<frmCadastroAgencia>().Count() > 0)
            {
                MessageBox.Show("FORMULÁRIO DE CADASTRO DE AGÊNCIA JÁ ESTÁ ABERTO");
                return;

            }
            else
            {
                frmCadastroAgencia frmagencia = new frmCadastroAgencia();
                frmagencia.MdiParent = this;
                frmagencia.Show();
            }


        }
               
       

        private void btnPlanos_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmPlanos>().Count() > 0)
            {
                MessageBox.Show("FORMULÁRIO DE PLANOS JÁ ESTÁ ABERTO");
                return;

            }
            else
            {

                frmPlanos frmplanos = new frmPlanos();
                frmplanos.MdiParent = this;
                frmplanos.Show();
            }
        }

        private void btnCoberturas_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmCoberturasAdi>().Count() > 0)
            {
                MessageBox.Show("FORMULÁRIO DE CONDIÇÕES ADICIONAIS JÁ ESTÁ ABERTO");
                return;

            }
            else
            {


                frmCoberturasAdi frmcobertura = new frmCoberturasAdi();
                frmcobertura.MdiParent = this;
                frmcobertura.Show();
            }
        }

        private void btnGTAGLOBALTRAVELASSISTANCEportuguês_Click(object sender, EventArgs e)
        {
            url = "http://www.gtaassist.com.br/sitev2/biblioteca/cg/Condicoes_Gerais.pdf";
            frmCondicoesGerais f = new frmCondicoesGerais(url);
            f.MdiParent = this;
            f.Show();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja mesmo sair do sistema?", "SISTEMA", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Variaveis.logado = "não";
                Application.Exit();

            }  
            
          
        }

        private void btnGTAGLOBALTRAVELASSISTANCEinglês_Click(object sender, EventArgs e)
        {
            url = "http://www.gtaassist.com.br/sitev2/biblioteca/cg/cgIngles.pdf";
            frmCondicoesGerais f = new frmCondicoesGerais(url);
            f.MdiParent = this;
            f.Show();
        }

        private void btnCANCELAMENTODEVIAGEMPLUSREASON_Click(object sender, EventArgs e)
        {
            url = "http://www.gtaassist.com.br/sitev2/home/cg/CANCELAMENTO%20DE%20VIAGEM%20PLUS%20REASON.PDF";
            frmCondicoesGerais f = new frmCondicoesGerais(url);
            f.MdiParent = this;
            f.Show();
        }

        private void btnADICIONALDECANCELAMENTODEVIAGEM_Click(object sender, EventArgs e)
        {
            url = "http://www.gtaassist.com.br/sitev2/home/cg/CANCELAMENTO%20DE%20VIAGEM%20ADICIONAL.PDF";
            frmCondicoesGerais f = new frmCondicoesGerais(url);
            f.MdiParent = this;
            f.Show();
        }

        private void btnCOBERTURADEGRAVIDEZ_Click(object sender, EventArgs e)
        {
            url = "http://www.gtaassist.com.br/sitev2/home/cg/COBERTURA%20DE%20GRAVIDEZ.PDF";
            frmCondicoesGerais f = new frmCondicoesGerais(url);
            f.MdiParent = this;
            f.Show();
        }

        private void btnBRAZILIANASSISTNACIONAL_Click(object sender, EventArgs e)
        {
            url = "http://www.gtaassist.com.br/sitev2/home/cg/COND.%20GERAIS%20BRAZILIAN%20ASSIST%202014.PDF";
            frmCondicoesGerais f = new frmCondicoesGerais(url);
            f.MdiParent = this;
            f.Show();
        }

        private void btnMARITIMOCOBERTURADEREPARODEBAGAGEM_Click(object sender, EventArgs e)
        {
            url = "http://www.gtaassist.com.br/sitev2/home/cg/BENEFICIO%20EXTRA%20-%20COBERTURA%20DE%20REPARO%20DE%20BAGAGEM.pdf";
            frmCondicoesGerais f = new frmCondicoesGerais(url);
            f.MdiParent = this;
            f.Show();
        }

        private void btnCANCELAMENTOMASTER_Click(object sender, EventArgs e)
        {
            url = "http://www.gtaassist.com.br/sitev2/biblioteca/cg/CANCELAMENTO_MASTER_GTA.PDF";
            frmCondicoesGerais f = new frmCondicoesGerais(url);
            f.MdiParent = this;
            f.Show();
        }

        private void btnCotação_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmCotacao>().Count() > 0)
            {
                MessageBox.Show("FORMULÁRIO DE COTAÇÃO JÁ ESTÁ ABERTO");
                return;

            }
            else
            {

                frmCotacao frmcotacao = new frmCotacao();
                frmcotacao.MdiParent = this;
                frmcotacao.Show();
            }
        }

        private void btnLogOff_Click(object sender, EventArgs e)
        {
            StatusStripIni.Visible = false;
            Variaveis.logado = "não";
            btnLogOff.Enabled = false;
            btnAlterar.Enabled = false;
            btnAltAgen.Enabled = false;
            btnAltCli.Enabled = false;
            expandablePanel2.Visible = true;
            expandablePanel2.Expanded = false;
            Cadastro.Enabled = true;
            
            tstxtLogin.Clear();
            tstxtSenha.Clear();
            tstcmbMod.SelectedIndex = -1;
            tstxtLogin.Focus();
        }

        private void frmMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
           //if (MessageBox.Show("Deseja mesmo sair/reiniciar o sistema?", "SISTEMA", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
        //    {
          //      e.Cancel = true;
           //    // Variaveis.logado = "não";
           // }
          //  else e.Cancel = false;
        
           
            
        }

        private void btnAltCli_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmAlterarCliente>().Count() > 0)
            {
                MessageBox.Show("FORMULÁRIO DE ALTERAR CLIENTE JÁ ESTÁ ABERTO");
                return;

            }
            else
            {

                frmAlterarCliente frmLogar = new frmAlterarCliente();
                frmLogar.MdiParent = this;
                frmLogar.Show();
            }
        }

        private void btnAltAgen_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmAlterarAgencia>().Count() > 0)
            {
                MessageBox.Show("FORMULÁRIO DE ALTERAR AGENCIA JÁ ESTÁ ABERTO");
                return;

            }
            else
            {

                frmAlterarAgencia frmAgen = new frmAlterarAgencia();
                frmAgen.MdiParent = this;
                frmAgen.Show();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {


            if (Application.OpenForms.OfType<frmLogar>().Count() > 0)
            {
                MessageBox.Show("FORMULÁRIO DE CADASTRO DE SENHA JÁ ESTÁ ABERTO");
                return;

            }
            else
            {

                frmLogar frmLogar = new frmLogar();
                frmLogar.MdiParent = this;
                expandablePanel2.Expanded = false;
                frmLogar.Show();
            }
                      
        }

        private void LogSen_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmLogar>().Count() > 0)
            {
                MessageBox.Show("FORMULÁRIO DE CADASTRO DE SENHA JÁ ESTÁ ABERTO");
                return;

            }
            else
            {

                frmLogar frmLogar = new frmLogar();
                frmLogar.MdiParent = this;
                expandablePanel2.Expanded = false;
                frmLogar.Show();
            }
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
        }
               

        private void buttonItem6_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja mesmo reiniciar o sistema?", "SISTEMA", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
           {
                Variaveis.logado = "não";
                Application.Restart();
                
           }  
            
            
        }

        private void tstxtLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)39 || e.KeyChar == (char)32)
            {
                e.KeyChar = (Char)0;
            }
            else if (e.KeyChar == (char)13)
            {
                tstxtSenha.Focus();
            }
        }

        private void tstxtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)39)
            {
                e.KeyChar = (Char)0;
            }
        }

                          
           

    }
        
    }




