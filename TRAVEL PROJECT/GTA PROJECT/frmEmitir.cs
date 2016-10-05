using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BLL;
using System.Diagnostics;
using Root.Reports;


namespace GTA_PROJECT
{
    public partial class frmEmitir : Form
    {
        public frmEmitir()
        {
            InitializeComponent();
        }

        decimal valor;
        Planos completarplan = new Planos();
        Voucher voucher = new Voucher();
        ClienteBLL cliente = new ClienteBLL();

        private void frmEmitir_Load(object sender, EventArgs e)
        {
            dateTimeInput1.MinDate = DateTime.Now;

            cmbTipPlan.DataSource = completarplan.selecionar_categoria();
            cmbTipPlan.DisplayMember = "PlanCate";
            cmbTipPlan.SelectedIndex = 0;


            ClienteBLL cliente = new ClienteBLL();
            if (Planos_Detalhes.TipoPlan != "")
            {
                cmbTipPlan.Text = Planos_Detalhes.TipoPlan;
                cmbPlan.Text = Planos_Detalhes.Plano;
                cmbDias.Text = Planos_Detalhes.Dias;
                integerInput1.Text = Planos_Detalhes.Quant;
                cmbTipPlan.Enabled = false;
                cmbPlan.Enabled = false;
                cmbDias.Enabled = false;
                integerInput1.Enabled = false;
            }
           

            //cmbTipPlan.SelectedIndex = 0;           
           

        }

        private void btnEmitir_Click(object sender, EventArgs e)
        {

            if (((cmbTipPlan.Enabled == true && (cmbTipPlan.FindStringExact(cmbTipPlan.Text) < 0 || cmbPlan.FindStringExact(cmbPlan.Text) < 0 || cmbDias.FindStringExact(cmbDias.Text) < 0))))
            {

                MessageBox.Show("Dados selecionados inválidos , selecione somente os itens da lista");
                return;

            }


            if (checkBoxX1.Checked == false)
            {

                MessageBox.Show("Confirme que seus dados pessoais estão atualizados, caso contrário atualize");
                return;

            }


            else if (cmbTipPlan.Text == "")
            {
                MessageBox.Show("Complete o campo de Tipo de Plano");
                return;
            }
            else if (cmbPlan.Text == "")
            {
                MessageBox.Show("Complete o campo de Planos");
                return;

            }
            else if (cmbDias.Text == "")
            {
                MessageBox.Show("Complete o campo de Dias");
                return;

            }
            else if (integerInput1.Text == "0" || integerInput1.Text.Trim() == "")
            {
                MessageBox.Show("Complete o campo de Quantidade");
                return;

            }
            else if (dateTimeInput1.Text.Trim() == "")
            {
                MessageBox.Show("Complete a data de inicio");
                return;

            }

         //  MessageBox.Show(cmbTipPlan.Text);
       //   MessageBox.Show((completarplan.selecionar_planos_voucher(cmbPlan.Text, cmbTipPlan.Text).Rows[0]["PlanCod"].ToString()));

          ///  voucher.inserir_voucher_cli(int.Parse(cliente.selecionar_cliente(Variaveis.login).Rows[0]["CliCod"].ToString()), int.Parse(completarplan.selecionar_planos(cmbPlan.Text, cmbTipPlan.Text).Rows[0]["PlanCod"].ToString()), cmbDias.Text, integerInput1.Value, dateTimeInput1.Value.ToString("yyyy-MM-dd"), checkBoxX1.Checked, ((int.Parse(integerInput1.Text) * valor) * decimal.Parse(Variaveis.dolar.Replace(".", ","))), (int.Parse(integerInput1.Text) * valor));

            string vArq = "";
            valor = Convert.ToDecimal(cmbDias.SelectedValue);
            //FolderBrowserDialog vSalvar = new FolderBrowserDialog();
            SaveFileDialog savedialog = new SaveFileDialog();
            //if (vSalvar.ShowDialog() == DialogResult.Cancel)
            //    return;
            savedialog.FileName =  "";
            savedialog.Filter = "Pdf Files|*.pdf";
            if (savedialog.ShowDialog() == DialogResult.Cancel) return;
            vArq = savedialog.FileName;
            //+ "\\" + "Emissão de seguro" + 

            if (Variaveis.modacesso == "Cliente")
            {

                try
                {
                    DataRow dados;
                    dados = cliente.selecionar_cliente(Variaveis.login).Rows[0];
                    Report vPdf = new Report(new PdfFormatter());                  
                    FontDef vDef = new FontDef(vPdf, FontDef.StandardFont.TimesRoman);
                    FontProp vDrop = new FontProp(vDef, 10);                    
                    Page vPage = new Page(vPdf);                    
                    vPage.AddCB_MM(15, new RepString(vDrop, "COMPROVANTE DE EMIÇÃO DE VOUCHER"));
                    vPage.Add(0, 60, new RepString(vDrop, "------------------------------------------------------------------------------------------------------------------------"));
                    vPage.Add(5, 70, new RepString(vDrop, "Informações Pessoais"));
                    vPage.Add(0, 80, new RepString(vDrop, "------------------------------------------------------------------------------------------------------------------------"));
                    vPage.Add(40, 100, new RepString(vDrop, "Nome: " + dados["CliNome"].ToString()));
                    vPage.Add(40, 120, new RepString(vDrop, "CPF: " + dados["CliCpf"].ToString()));
                    vPage.Add(40, 140, new RepString(vDrop, "RG: " + dados["CliRg"].ToString()));
                    vPage.Add(40, 160, new RepString(vDrop, "CEP: " + dados["CliCep"].ToString().PadLeft(8, '0')));
                    vPage.Add(40, 180, new RepString(vDrop, "Endereço: " + dados["CliEnd"].ToString()));
                    vPage.Add(40, 200, new RepString(vDrop, "Número do endereço:" + dados["CliEndNro"].ToString()));
                    vPage.Add(40, 220, new RepString(vDrop, "Bairro:" + dados["CliBairro"].ToString()));
                    vPage.Add(40, 240, new RepString(vDrop, "Cidade: " + dados["CliCid"].ToString()));
                    vPage.Add(40, 260, new RepString(vDrop, "Estado: " + dados["CliEst"].ToString()));
                    vPage.Add(40, 280, new RepString(vDrop, "Telefone: " + dados["CliTel"].ToString()));
                    vPage.Add(40, 300, new RepString(vDrop, "Email: " + dados["CliEmail"].ToString()));
                    vPage.Add(0, 310, new RepString(vDrop, "------------------------------------------------------------------------------------------------------------------------"));
                    vPage.Add(5, 320, new RepString(vDrop, "Informações Bancárias"));
                    vPage.Add(0, 330, new RepString(vDrop, "------------------------------------------------------------------------------------------------------------------------"));
                    vPage.Add(40, 340, new RepString(vDrop, "Banco: " + dados["CliBan"].ToString()));
                    vPage.Add(40, 360, new RepString(vDrop, "Favorecido: " + dados["CliFavo"].ToString()));
                    vPage.Add(40, 380, new RepString(vDrop, "Agência: " + dados["CliAgen"].ToString()));
                    vPage.Add(40, 400, new RepString(vDrop, "Conta Corrente: " + dados["CliCorren"].ToString()));
                    vPage.Add(0, 410, new RepString(vDrop, "------------------------------------------------------------------------------------------------------------------------"));
                    vPage.Add(0, 420, new RepString(vDrop, "Informações do plano"));
                    vPage.Add(0, 430, new RepString(vDrop, "------------------------------------------------------------------------------------------------------------------------"));
                    vPage.Add(40, 440, new RepString(vDrop, "Tipo Plano: " + cmbTipPlan.Text));
                    vPage.Add(40, 460, new RepString(vDrop, "Plano: " + cmbPlan.Text));
                    vPage.Add(40, 480, new RepString(vDrop, "Periodo: " + cmbDias.Text));
                    vPage.Add(40, 500, new RepString(vDrop, "Data Inicial: " + dateTimeInput1.Text));
                    vPage.Add(40, 520, new RepString(vDrop, "Quantidade de Pessoas: " + integerInput1.Text));
                    if (Planos_Detalhes.valor == 0)
                    {
                        vPage.Add(40, 540, new RepString(vDrop, "Valor: US$" + ((int.Parse(integerInput1.Text) * valor).ToString())));
                        vPage.Add(40, 560, new RepString(vDrop, "Valor: " + (((int.Parse(integerInput1.Text) * valor) * decimal.Parse(Variaveis.dolar.Replace(".", ","))).ToString("C3"))));
                        voucher.inserir_voucher_cli(int.Parse(cliente.selecionar_cliente(Variaveis.login).Rows[0]["CliCod"].ToString()), int.Parse(completarplan.selecionar_planos_voucher(cmbPlan.Text,cmbTipPlan.Text).Rows[0]["PlanCod"].ToString()), cmbDias.Text, integerInput1.Value, dateTimeInput1.Value.ToString("yyyy-MM-dd"), checkBoxX1.Checked,((int.Parse(integerInput1.Text) * valor) * decimal.Parse(Variaveis.dolar.Replace(".", ","))),(int.Parse(integerInput1.Text) * valor));
                      //  MessageBox.Show(((int.Parse(integerInput1.Text) * valor) * decimal.Parse(Variaveis.dolar.Replace(".", ","))).ToString());
                    }
                    else
                    {
                        vPage.Add(40, 540, new RepString(vDrop, "Valor: US$" + Planos_Detalhes.valor.ToString()));
                        vPage.Add(40, 560, new RepString(vDrop, "Valor: " + ((Planos_Detalhes.valor) * decimal.Parse(Variaveis.dolar.Replace(".", ","))).ToString("C3")));
                        voucher.inserir_voucher_cli(int.Parse(cliente.selecionar_cliente(Variaveis.login).Rows[0]["CliCod"].ToString()), int.Parse(completarplan.selecionar_planos_voucher(cmbPlan.Text, cmbTipPlan.Text).Rows[0]["PlanCod"].ToString()), cmbDias.Text, integerInput1.Value, dateTimeInput1.Value.ToString("yyyy-MM-dd"), checkBoxX1.Checked, ((Planos_Detalhes.valor) * decimal.Parse(Variaveis.dolar.Replace(".", ","))), Planos_Detalhes.valor);
                      //  MessageBox.Show((completarplan.selecionar_planos_voucher(cmbPlan.Text, cmbTipPlan.Text).Rows[0]["PlanCod"].ToString()));
                      //  MessageBox.Show(((int.Parse(integerInput1.Text) * valor) * decimal.Parse(Variaveis.dolar.Replace(".", ","))).ToString());
                    
                    }
                    vPage.Add(0, 570, new RepString(vDrop, "------------------------------------------------------------------------------------------------------------------------"));
                    vPage.Add(450, 580, new RepString(vDrop, "Data:" + DateTime.Now.ToShortDateString()));
                    vPdf.Save(vArq);
                   
                    MessageBox.Show("Arquivo Gerado com sucesso !", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Process.Start(vArq);
                    this.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Erro ao Gerar arquivo !!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }

            else if (Variaveis.modacesso == "Agência")
            {


                try
                {
                    DataRow dados;
                    AgenciaBLL agencia = new AgenciaBLL();
                    dados = agencia.selecionar_agencia(Variaveis.login,Variaveis.senha).Rows[0];
                    Report vPdf = new Report(new PdfFormatter());
                    FontDef vDef = new FontDef(vPdf, FontDef.StandardFont.TimesRoman);
                    FontProp vDrop = new FontProp(vDef, 10);
                    Page vPage = new Page(vPdf);
                    vPage.AddCB_MM(15, new RepString(vDrop, "COMPROVANTE DE EMIÇÃO DE VOUCHER"));
                    vPage.Add(0, 60, new RepString(vDrop, "------------------------------------------------------------------------------------------------------------------------"));
                    vPage.Add(5, 70, new RepString(vDrop, "Informações da Empresa"));
                    vPage.Add(0, 80, new RepString(vDrop, "------------------------------------------------------------------------------------------------------------------------"));
                    vPage.Add(40, 100, new RepString(vDrop, "Razão Social: " + dados["AgenRazSoc"].ToString()));
                    vPage.Add(40, 120, new RepString(vDrop, "Nome Fantasia: " + dados["AgenNomFant"].ToString()));
                    vPage.Add(40, 140, new RepString(vDrop, "CNPJ: " + dados["AgenCnpj"].ToString()));
                    vPage.Add(40, 160, new RepString(vDrop, "CEP: " + dados["AgenEnd"].ToString()));
                    vPage.Add(40, 180, new RepString(vDrop, "Endereço: " + dados["AgenEnd"].ToString().PadLeft(8, '0')));
                    vPage.Add(40, 200, new RepString(vDrop, "Número: " + dados["AgenEndNum"].ToString()));
                    vPage.Add(40, 220, new RepString(vDrop, "Bairro: " + dados["AgenBairro"].ToString()));
                    vPage.Add(40, 240, new RepString(vDrop, "Cidade:" + dados["AgenCid"].ToString()));
                    vPage.Add(40, 260, new RepString(vDrop, "Estado: " + dados["AgenEst"].ToString()));
                    vPage.Add(40, 280, new RepString(vDrop, "Telefone:" + dados["AgenTel"].ToString()));
                    vPage.Add(40, 300, new RepString(vDrop, "Email: " + dados["AgenEmail"].ToString()));
                    vPage.Add(40, 320, new RepString(vDrop, "Responsável pelo cadastro: " + dados["AgenRespCad"].ToString()));
                    vPage.Add(40, 340, new RepString(vDrop, "RG do Responsável pelo cadastro: " + dados["AgenRgResp"].ToString()));
                    vPage.Add(40, 360, new RepString(vDrop, "Suplente: " + dados["AgenNomSuple"].ToString()));
                    vPage.Add(40, 380, new RepString(vDrop, "RG do suplente: " + dados["AgenRgSuple"].ToString()));
                    vPage.Add(0, 390, new RepString(vDrop, "------------------------------------------------------------------------------------------------------------------------"));
                    vPage.Add(5, 400, new RepString(vDrop, "Informações Bancárias"));
                    vPage.Add(0, 410, new RepString(vDrop, "------------------------------------------------------------------------------------------------------------------------"));
                    vPage.Add(40, 420, new RepString(vDrop, "Banco: " + dados["AgenBan"].ToString()));
                    vPage.Add(40, 440, new RepString(vDrop, "Favorecido: " + dados["AgenFavo"].ToString()));
                    vPage.Add(40, 460, new RepString(vDrop, "Agência: " + dados["AgenNro"].ToString()));
                    vPage.Add(40, 480, new RepString(vDrop, "Conta Corrente: " + dados["AgenContCor"].ToString()));
                    vPage.Add(0, 490, new RepString(vDrop, "------------------------------------------------------------------------------------------------------------------------"));
                    vPage.Add(0, 500, new RepString(vDrop, "Informações do plano"));
                    vPage.Add(0, 510, new RepString(vDrop, "------------------------------------------------------------------------------------------------------------------------"));
                    vPage.Add(40, 520, new RepString(vDrop, "Tipo Plano: " + cmbTipPlan.Text));
                    vPage.Add(40, 540, new RepString(vDrop, "Plano: " + cmbPlan.Text));
                    vPage.Add(40, 560, new RepString(vDrop, "Periodo: " + cmbDias.Text));
                    vPage.Add(40, 580, new RepString(vDrop, "Data Inicial: " + dateTimeInput1.Text));
                    vPage.Add(40, 600, new RepString(vDrop, "Quantidade de Pessoas: " + integerInput1.Text));
                    if (Planos_Detalhes.valor == 0)
                    {
                        vPage.Add(40, 620, new RepString(vDrop, "Valor: US$" + ((int.Parse(integerInput1.Text) * valor).ToString())));
                        vPage.Add(40, 640, new RepString(vDrop, "Valor: " + (((int.Parse(integerInput1.Text) * valor) * decimal.Parse(Variaveis.dolar.Replace(".", ","))).ToString("C3"))));
                        //MessageBox.Show(((int.Parse(integerInput1.Text) * valor) * decimal.Parse(Variaveis.dolar.Replace(".", ","))).ToString());                      
                        voucher.inserir_voucher_agen(int.Parse(agencia.selecionar_agencia(Variaveis.login, Variaveis.senha).Rows[0]["AgenCod"].ToString()), int.Parse(completarplan.selecionar_planos_voucher(cmbPlan.Text, cmbTipPlan.Text).Rows[0]["PlanCod"].ToString()), cmbDias.Text, integerInput1.Value, dateTimeInput1.Value.ToString("yyyy-MM-dd"), checkBoxX1.Checked, (((int.Parse(integerInput1.Text) * valor) * decimal.Parse(Variaveis.dolar.Replace(".", ",")))), ((int.Parse(integerInput1.Text) * valor)));
                    }
                    else
                    {
                        vPage.Add(40, 620, new RepString(vDrop, "Valor: US$" + Planos_Detalhes.valor.ToString()));
                        vPage.Add(40, 640, new RepString(vDrop, "Valor: " + ((Planos_Detalhes.valor) * decimal.Parse(Variaveis.dolar.Replace(".", ","))).ToString("C3")));
                        voucher.inserir_voucher_agen(int.Parse(agencia.selecionar_agencia(Variaveis.login, Variaveis.senha).Rows[0]["AgenCod"].ToString()), int.Parse(completarplan.selecionar_planos_voucher(cmbPlan.Text, cmbTipPlan.Text).Rows[0]["PlanCod"].ToString()), cmbDias.Text, integerInput1.Value, dateTimeInput1.Value.ToString("yyyy-MM-dd"), checkBoxX1.Checked, ((Planos_Detalhes.valor) * decimal.Parse(Variaveis.dolar.Replace(".", ","))), Planos_Detalhes.valor);
                        //voucher.inserir_voucher_agen(int.Parse(agencia.selecionar_agencia(Variaveis.login,Variaveis.senha).Rows[0]["AgenCod"].ToString()), cmbTipPlan.Text, cmbPlan.Text, cmbDias.Text, integerInput1.Value, dateTimeInput1.Value.ToString("yyyy-MM-dd"), checkBoxX1.Checked);
                        //MessageBox.Show(((int.Parse(integerInput1.Text) * valor) * decimal.Parse(Variaveis.dolar.Replace(".", ","))).ToString()); 
                    }
                    vPage.Add(0, 650, new RepString(vDrop, "------------------------------------------------------------------------------------------------------------------------"));
                    vPage.Add(450, 660, new RepString(vDrop, "Data:" + DateTime.Now.ToShortDateString()));
                    vPdf.Save(vArq);
                    //voucher.inserir_voucher_agen(int.Parse(agencia.selecionar_agencia(Variaveis.login, Variaveis.senha).Rows[0]["AgenCod"].ToString()), int.Parse(completarplan.selecionar_planos(cmbPlan.Text, cmbTipPlan.Text).Rows[0]["PlanCod"].ToString()), cmbTipPlan.Text, cmbPlan.Text, cmbDias.Text, integerInput1.Value, dateTimeInput1.Value.ToString("yyyy-MM-dd"), checkBoxX1.Checked, (((int.Parse(integerInput1.Text) * valor) * decimal.Parse(Variaveis.dolar.Replace(".", ",")))), ((int.Parse(integerInput1.Text) * valor)));
                    MessageBox.Show("Arquivo Gerado com sucesso !", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Process.Start(vArq);
                    this.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Erro ao Gerar arquivo !!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }

        }

       
        private void cmbTipPlan_SelectedIndexChanged(object sender, EventArgs e)
        {
            Planos completarplan = new Planos();

            
                     if (Planos_Detalhes.TipoPlan == "" && cmbTipPlan.Text != "")
                {

                    cmbPlan.DataSource = completarplan.selecionar_categ_planos(cmbTipPlan.Text);
                    cmbPlan.DisplayMember = "PlanNome";
                    //cmbPlan.SelectedIndex = 0;

                }
                             
            
         
        }

        private void cmbPlan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Planos_Detalhes.TipoPlan == "" && cmbPlan.FindStringExact(cmbPlan.Text) >= 0)
            {
                cmbDias.DataSource = completarplan.selecionar_planos(cmbPlan.Text, cmbTipPlan.Text);
                cmbDias.DisplayMember = "AtriDescri";
                cmbDias.ValueMember = "AtriValor";
            }
                      
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {

            if (Application.OpenForms.OfType<frmAlterarCliente>().Count() > 0)
            {
                MessageBox.Show("FORMULÁRIO DE ALTERAR CLIENTE JÁ ESTÁ ABERTO");
                return;

            }
            else
            {

                frmAlterarCliente frmAlterar = new frmAlterarCliente();
                frmAlterar.Show();
            }
        }

        private void frmEmitir_FormClosing(object sender, FormClosingEventArgs e)
        {
            Planos_Detalhes.TipoPlan = "";
            Planos_Detalhes.Plano = "";
            Planos_Detalhes.Dias = "";
            Planos_Detalhes.Quant = "";
            Planos_Detalhes.valor = 0;
        }

        
       
    }
}
