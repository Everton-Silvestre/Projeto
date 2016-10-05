namespace GTA_PROJECT
{
    partial class frmAlterarCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtCliCod = new System.Windows.Forms.TextBox();
            this.txtCorren = new System.Windows.Forms.TextBox();
            this.mskCep = new System.Windows.Forms.MaskedTextBox();
            this.mskRg = new System.Windows.Forms.MaskedTextBox();
            this.mskTel = new System.Windows.Forms.MaskedTextBox();
            this.mskCpf = new System.Windows.Forms.MaskedTextBox();
            this.txtAgen = new System.Windows.Forms.TextBox();
            this.txtFavo = new System.Windows.Forms.TextBox();
            this.txtBan = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtCid = new System.Windows.Forms.TextBox();
            this.txtEndNro = new System.Windows.Forms.TextBox();
            this.txtEnd = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblRg = new System.Windows.Forms.Label();
            this.lblCpf = new System.Windows.Forms.Label();
            this.lblTel = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblBairro = new System.Windows.Forms.Label();
            this.lblCep = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblCid = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblEnd = new System.Windows.Forms.Label();
            this.lblContCor = new System.Windows.Forms.Label();
            this.lblBanco = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFavo = new System.Windows.Forms.Label();
            this.lblAviso = new System.Windows.Forms.Label();
            this.cmbEst = new System.Windows.Forms.ComboBox();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.lblSenha = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.lblAviEmail = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAlterar = new DevComponents.DotNetBar.ButtonX();
            this.groupPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCliCod
            // 
            this.txtCliCod.Location = new System.Drawing.Point(70, 14);
            this.txtCliCod.Name = "txtCliCod";
            this.txtCliCod.ReadOnly = true;
            this.txtCliCod.Size = new System.Drawing.Size(100, 20);
            this.txtCliCod.TabIndex = 34;
            // 
            // txtCorren
            // 
            this.txtCorren.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtCorren.Location = new System.Drawing.Point(126, 156);
            this.txtCorren.MaxLength = 13;
            this.txtCorren.Name = "txtCorren";
            this.txtCorren.Size = new System.Drawing.Size(100, 20);
            this.txtCorren.TabIndex = 32;
            this.txtCorren.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCorren_KeyPress);
            // 
            // mskCep
            // 
            this.mskCep.BeepOnError = true;
            this.mskCep.Location = new System.Drawing.Point(347, 15);
            this.mskCep.Mask = "00000-000";
            this.mskCep.Name = "mskCep";
            this.mskCep.Size = new System.Drawing.Size(100, 20);
            this.mskCep.TabIndex = 23;
            this.mskCep.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mskCep_KeyPress);
            // 
            // mskRg
            // 
            this.mskRg.Location = new System.Drawing.Point(70, 91);
            this.mskRg.Mask = "00.000.000-0";
            this.mskRg.Name = "mskRg";
            this.mskRg.Size = new System.Drawing.Size(100, 20);
            this.mskRg.TabIndex = 18;
            this.mskRg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mskRg_KeyPress);
            // 
            // mskTel
            // 
            this.mskTel.Location = new System.Drawing.Point(75, 161);
            this.mskTel.Mask = "(00)0000-0000";
            this.mskTel.Name = "mskTel";
            this.mskTel.Size = new System.Drawing.Size(95, 20);
            this.mskTel.TabIndex = 20;
            this.mskTel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mskTel_KeyPress);
            // 
            // mskCpf
            // 
            this.mskCpf.Location = new System.Drawing.Point(70, 123);
            this.mskCpf.Mask = "000.000.000/00";
            this.mskCpf.Name = "mskCpf";
            this.mskCpf.Size = new System.Drawing.Size(100, 20);
            this.mskCpf.TabIndex = 19;
            this.mskCpf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mskCpf_KeyPress);
            // 
            // txtAgen
            // 
            this.txtAgen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtAgen.Location = new System.Drawing.Point(126, 116);
            this.txtAgen.MaxLength = 10;
            this.txtAgen.Name = "txtAgen";
            this.txtAgen.Size = new System.Drawing.Size(100, 20);
            this.txtAgen.TabIndex = 31;
            this.txtAgen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAgen_KeyPress);
            // 
            // txtFavo
            // 
            this.txtFavo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtFavo.Location = new System.Drawing.Point(126, 81);
            this.txtFavo.MaxLength = 50;
            this.txtFavo.Name = "txtFavo";
            this.txtFavo.Size = new System.Drawing.Size(100, 20);
            this.txtFavo.TabIndex = 30;
            this.txtFavo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFavo_KeyPress);
            // 
            // txtBan
            // 
            this.txtBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtBan.Location = new System.Drawing.Point(126, 39);
            this.txtBan.MaxLength = 50;
            this.txtBan.Name = "txtBan";
            this.txtBan.Size = new System.Drawing.Size(100, 20);
            this.txtBan.TabIndex = 29;
            this.txtBan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBan_KeyPress);
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(536, 11);
            this.txtBairro.MaxLength = 40;
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(100, 20);
            this.txtBairro.TabIndex = 26;
            this.txtBairro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBairro_KeyPress);
            // 
            // txtEmail
            // 
            this.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEmail.Location = new System.Drawing.Point(70, 207);
            this.txtEmail.MaxLength = 40;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(163, 20);
            this.txtEmail.TabIndex = 21;
            this.txtEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmail_KeyPress);
            // 
            // txtCid
            // 
            this.txtCid.Location = new System.Drawing.Point(536, 41);
            this.txtCid.MaxLength = 40;
            this.txtCid.Name = "txtCid";
            this.txtCid.Size = new System.Drawing.Size(100, 20);
            this.txtCid.TabIndex = 27;
            this.txtCid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCid_KeyPress);
            // 
            // txtEndNro
            // 
            this.txtEndNro.Location = new System.Drawing.Point(348, 76);
            this.txtEndNro.MaxLength = 10;
            this.txtEndNro.Name = "txtEndNro";
            this.txtEndNro.Size = new System.Drawing.Size(100, 20);
            this.txtEndNro.TabIndex = 25;
            this.txtEndNro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEndNro_KeyPress);
            // 
            // txtEnd
            // 
            this.txtEnd.Location = new System.Drawing.Point(348, 46);
            this.txtEnd.MaxLength = 60;
            this.txtEnd.Name = "txtEnd";
            this.txtEnd.Size = new System.Drawing.Size(100, 20);
            this.txtEnd.TabIndex = 24;
            this.txtEnd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEnd_KeyPress);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(70, 50);
            this.txtNome.MaxLength = 60;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(163, 20);
            this.txtNome.TabIndex = 17;
            this.txtNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNome_KeyPress);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(14, 212);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(48, 15);
            this.lblEmail.TabIndex = 43;
            this.lblEmail.Text = "Email:";
            // 
            // lblRg
            // 
            this.lblRg.AutoSize = true;
            this.lblRg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRg.Location = new System.Drawing.Point(15, 92);
            this.lblRg.Name = "lblRg";
            this.lblRg.Size = new System.Drawing.Size(27, 15);
            this.lblRg.TabIndex = 42;
            this.lblRg.Text = "RG";
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpf.Location = new System.Drawing.Point(16, 128);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(33, 15);
            this.lblCpf.TabIndex = 41;
            this.lblCpf.Text = "CPF";
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTel.Location = new System.Drawing.Point(6, 166);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(63, 15);
            this.lblTel.TabIndex = 40;
            this.lblTel.Text = "Telefone";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(14, 54);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(49, 15);
            this.lblNome.TabIndex = 39;
            this.lblNome.Text = "Nome:";
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBairro.Location = new System.Drawing.Point(470, 16);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(50, 15);
            this.lblBairro.TabIndex = 57;
            this.lblBairro.Text = "Bairro:";
            // 
            // lblCep
            // 
            this.lblCep.AutoSize = true;
            this.lblCep.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCep.Location = new System.Drawing.Point(288, 19);
            this.lblCep.Name = "lblCep";
            this.lblCep.Size = new System.Drawing.Size(38, 15);
            this.lblCep.TabIndex = 56;
            this.lblCep.Text = "CEP:";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(469, 80);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(55, 15);
            this.lblEstado.TabIndex = 55;
            this.lblEstado.Text = "Estado:";
            // 
            // lblCid
            // 
            this.lblCid.AutoSize = true;
            this.lblCid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCid.Location = new System.Drawing.Point(469, 46);
            this.lblCid.Name = "lblCid";
            this.lblCid.Size = new System.Drawing.Size(56, 15);
            this.lblCid.TabIndex = 54;
            this.lblCid.Text = "Cidade:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(274, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 15);
            this.label3.TabIndex = 53;
            this.label3.Text = "Número:";
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnd.Location = new System.Drawing.Point(263, 51);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(72, 15);
            this.lblEnd.TabIndex = 52;
            this.lblEnd.Text = "Endereço:";
            // 
            // lblContCor
            // 
            this.lblContCor.AutoSize = true;
            this.lblContCor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContCor.Location = new System.Drawing.Point(3, 159);
            this.lblContCor.Name = "lblContCor";
            this.lblContCor.Size = new System.Drawing.Size(123, 15);
            this.lblContCor.TabIndex = 61;
            this.lblContCor.Text = "Conta Corrente: **";
            // 
            // lblBanco
            // 
            this.lblBanco.AutoSize = true;
            this.lblBanco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBanco.Location = new System.Drawing.Point(53, 41);
            this.lblBanco.Name = "lblBanco";
            this.lblBanco.Size = new System.Drawing.Size(67, 15);
            this.lblBanco.TabIndex = 58;
            this.lblBanco.Text = "Banco: **";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 15);
            this.label1.TabIndex = 60;
            this.label1.Text = "Agência: **";
            // 
            // lblFavo
            // 
            this.lblFavo.AutoSize = true;
            this.lblFavo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFavo.Location = new System.Drawing.Point(25, 84);
            this.lblFavo.Name = "lblFavo";
            this.lblFavo.Size = new System.Drawing.Size(97, 15);
            this.lblFavo.TabIndex = 59;
            this.lblFavo.Text = "Favorecido: **";
            // 
            // lblAviso
            // 
            this.lblAviso.AutoSize = true;
            this.lblAviso.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAviso.ForeColor = System.Drawing.Color.Red;
            this.lblAviso.Location = new System.Drawing.Point(157, 17);
            this.lblAviso.Name = "lblAviso";
            this.lblAviso.Size = new System.Drawing.Size(146, 13);
            this.lblAviso.TabIndex = 71;
            this.lblAviso.Text = "** Itens Não obrigatorios";
            // 
            // cmbEst
            // 
            this.cmbEst.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEst.FormattingEnabled = true;
            this.cmbEst.Items.AddRange(new object[] {
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.cmbEst.Location = new System.Drawing.Point(536, 79);
            this.cmbEst.Name = "cmbEst";
            this.cmbEst.Size = new System.Drawing.Size(100, 21);
            this.cmbEst.TabIndex = 28;
            this.cmbEst.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbEst_KeyPress);
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.Class = "";
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.ForeColor = System.Drawing.Color.Black;
            this.labelX1.Location = new System.Drawing.Point(16, 5);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(325, 23);
            this.labelX1.TabIndex = 74;
            this.labelX1.Text = "Altere as informações desejadas:";
            // 
            // groupPanel1
            // 
            this.groupPanel1.BackColor = System.Drawing.Color.Transparent;
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.lblSenha);
            this.groupPanel1.Controls.Add(this.groupBox1);
            this.groupPanel1.Controls.Add(this.txtSenha);
            this.groupPanel1.Controls.Add(this.lblAviEmail);
            this.groupPanel1.Controls.Add(this.label2);
            this.groupPanel1.Controls.Add(this.btnAlterar);
            this.groupPanel1.Controls.Add(this.txtNome);
            this.groupPanel1.Controls.Add(this.cmbEst);
            this.groupPanel1.Controls.Add(this.txtEnd);
            this.groupPanel1.Controls.Add(this.txtEndNro);
            this.groupPanel1.Controls.Add(this.txtCid);
            this.groupPanel1.Controls.Add(this.txtEmail);
            this.groupPanel1.Controls.Add(this.txtBairro);
            this.groupPanel1.Controls.Add(this.lblBairro);
            this.groupPanel1.Controls.Add(this.lblCep);
            this.groupPanel1.Controls.Add(this.lblEstado);
            this.groupPanel1.Controls.Add(this.mskCpf);
            this.groupPanel1.Controls.Add(this.lblCid);
            this.groupPanel1.Controls.Add(this.mskTel);
            this.groupPanel1.Controls.Add(this.label3);
            this.groupPanel1.Controls.Add(this.mskRg);
            this.groupPanel1.Controls.Add(this.lblEnd);
            this.groupPanel1.Controls.Add(this.mskCep);
            this.groupPanel1.Controls.Add(this.lblEmail);
            this.groupPanel1.Controls.Add(this.lblRg);
            this.groupPanel1.Controls.Add(this.txtCliCod);
            this.groupPanel1.Controls.Add(this.lblCpf);
            this.groupPanel1.Controls.Add(this.lblNome);
            this.groupPanel1.Controls.Add(this.lblTel);
            this.groupPanel1.Location = new System.Drawing.Point(16, 31);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(653, 400);
            // 
            // 
            // 
            this.groupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel1.Style.BackColorGradientAngle = 90;
            this.groupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderBottomWidth = 1;
            this.groupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderLeftWidth = 1;
            this.groupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderRightWidth = 1;
            this.groupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderTopWidth = 1;
            this.groupPanel1.Style.Class = "";
            this.groupPanel1.Style.CornerDiameter = 4;
            this.groupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseDown.Class = "";
            this.groupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseOver.Class = "";
            this.groupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel1.TabIndex = 75;
            this.groupPanel1.Text = "Alterar Cliente";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.Location = new System.Drawing.Point(20, 284);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(52, 15);
            this.lblSenha.TabIndex = 73;
            this.lblSenha.Text = "Senha:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.lblAviso);
            this.groupBox1.Controls.Add(this.lblBanco);
            this.groupBox1.Controls.Add(this.txtAgen);
            this.groupBox1.Controls.Add(this.txtFavo);
            this.groupBox1.Controls.Add(this.txtBan);
            this.groupBox1.Controls.Add(this.lblFavo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblContCor);
            this.groupBox1.Controls.Add(this.txtCorren);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(266, 123);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(370, 192);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados Bancarios **";
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(93, 282);
            this.txtSenha.MaxLength = 20;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(100, 20);
            this.txtSenha.TabIndex = 22;
            this.txtSenha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSenha_KeyPress);
            // 
            // lblAviEmail
            // 
            this.lblAviEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblAviEmail.ForeColor = System.Drawing.Color.Red;
            this.lblAviEmail.Location = new System.Drawing.Point(14, 235);
            this.lblAviEmail.Name = "lblAviEmail";
            this.lblAviEmail.Size = new System.Drawing.Size(219, 36);
            this.lblAviEmail.TabIndex = 75;
            this.lblAviEmail.Text = "ATENÇÃO: Este e-mail será utilizado para login no sistema";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 15);
            this.label2.TabIndex = 74;
            this.label2.Text = "Código:";
            // 
            // btnAlterar
            // 
            this.btnAlterar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAlterar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAlterar.Location = new System.Drawing.Point(449, 335);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(187, 30);
            this.btnAlterar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAlterar.TabIndex = 33;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // frmAlterarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(681, 445);
            this.Controls.Add(this.groupPanel1);
            this.Controls.Add(this.labelX1);
            this.MaximizeBox = false;
            this.Name = "frmAlterarCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alterar Cliente";
            this.Load += new System.EventHandler(this.frmAlterarCliente_Load);
            this.groupPanel1.ResumeLayout(false);
            this.groupPanel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtCliCod;
        private System.Windows.Forms.TextBox txtCorren;
        private System.Windows.Forms.MaskedTextBox mskCep;
        private System.Windows.Forms.MaskedTextBox mskRg;
        private System.Windows.Forms.MaskedTextBox mskTel;
        private System.Windows.Forms.MaskedTextBox mskCpf;
        private System.Windows.Forms.TextBox txtAgen;
        private System.Windows.Forms.TextBox txtFavo;
        private System.Windows.Forms.TextBox txtBan;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtCid;
        private System.Windows.Forms.TextBox txtEndNro;
        private System.Windows.Forms.TextBox txtEnd;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblRg;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.Label lblCep;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblCid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.Label lblContCor;
        private System.Windows.Forms.Label lblBanco;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFavo;
        private System.Windows.Forms.Label lblAviso;
        private System.Windows.Forms.ComboBox cmbEst;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.ButtonX btnAlterar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblAviEmail;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txtSenha;
    }
}