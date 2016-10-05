namespace GTA_PROJECT
{
    partial class frmCadastroAgencia
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
            this.lblAviEmail = new System.Windows.Forms.Label();
            this.lblAviso = new System.Windows.Forms.Label();
            this.mtxtTel = new System.Windows.Forms.MaskedTextBox();
            this.mtxtCnpj = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblContCor = new System.Windows.Forms.Label();
            this.txtContCor = new System.Windows.Forms.TextBox();
            this.lblBanco = new System.Windows.Forms.Label();
            this.txtAgen = new System.Windows.Forms.TextBox();
            this.txtBanco = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblFavo = new System.Windows.Forms.Label();
            this.txtFavo = new System.Windows.Forms.TextBox();
            this.cmbEst = new System.Windows.Forms.ComboBox();
            this.mtxtCep = new System.Windows.Forms.MaskedTextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblEst = new System.Windows.Forms.Label();
            this.lblCep = new System.Windows.Forms.Label();
            this.txtRespCad = new System.Windows.Forms.TextBox();
            this.lblRespCad = new System.Windows.Forms.Label();
            this.lblTel = new System.Windows.Forms.Label();
            this.txtCid = new System.Windows.Forms.TextBox();
            this.lblCid = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.lblBairro = new System.Windows.Forms.Label();
            this.txtEnd = new System.Windows.Forms.TextBox();
            this.lblEnd = new System.Windows.Forms.Label();
            this.txtNomFant = new System.Windows.Forms.TextBox();
            this.lblNomFant = new System.Windows.Forms.Label();
            this.lblCnpj = new System.Windows.Forms.Label();
            this.txtRazSoc = new System.Windows.Forms.TextBox();
            this.lblRazSoc = new System.Windows.Forms.Label();
            this.txtSuplente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mskRgAt = new System.Windows.Forms.MaskedTextBox();
            this.mskRgSu = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gpCadAgen = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.btnCompCep = new DevComponents.DotNetBar.ButtonX();
            this.btnCadastrar = new DevComponents.DotNetBar.ButtonX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.groupBox1.SuspendLayout();
            this.gpCadAgen.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAviEmail
            // 
            this.lblAviEmail.AutoSize = true;
            this.lblAviEmail.ForeColor = System.Drawing.Color.Red;
            this.lblAviEmail.Location = new System.Drawing.Point(353, 64);
            this.lblAviEmail.Name = "lblAviEmail";
            this.lblAviEmail.Size = new System.Drawing.Size(384, 15);
            this.lblAviEmail.TabIndex = 69;
            this.lblAviEmail.Text = "ATENÇÃO: Este e-mail será utilizado para login no sistema";
            // 
            // lblAviso
            // 
            this.lblAviso.AutoSize = true;
            this.lblAviso.ForeColor = System.Drawing.Color.Red;
            this.lblAviso.Location = new System.Drawing.Point(209, 17);
            this.lblAviso.Name = "lblAviso";
            this.lblAviso.Size = new System.Drawing.Size(165, 15);
            this.lblAviso.TabIndex = 68;
            this.lblAviso.Text = "** Itens Não obrigatórios";
            // 
            // mtxtTel
            // 
            this.mtxtTel.Location = new System.Drawing.Point(110, 326);
            this.mtxtTel.Mask = "(00)0000-0000";
            this.mtxtTel.Name = "mtxtTel";
            this.mtxtTel.Size = new System.Drawing.Size(100, 21);
            this.mtxtTel.TabIndex = 53;
            this.mtxtTel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtxtTel_KeyPress);
            // 
            // mtxtCnpj
            // 
            this.mtxtCnpj.Location = new System.Drawing.Point(102, 93);
            this.mtxtCnpj.Mask = "00.000.000/0000-00";
            this.mtxtCnpj.Name = "mtxtCnpj";
            this.mtxtCnpj.Size = new System.Drawing.Size(140, 21);
            this.mtxtCnpj.TabIndex = 46;
            this.mtxtCnpj.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtxtCnpj_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblContCor);
            this.groupBox1.Controls.Add(this.txtContCor);
            this.groupBox1.Controls.Add(this.lblBanco);
            this.groupBox1.Controls.Add(this.txtAgen);
            this.groupBox1.Controls.Add(this.txtBanco);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblFavo);
            this.groupBox1.Controls.Add(this.txtFavo);
            this.groupBox1.Controls.Add(this.lblAviso);
            this.groupBox1.Location = new System.Drawing.Point(349, 227);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(388, 199);
            this.groupBox1.TabIndex = 60;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados Bancarios **";
            // 
            // lblContCor
            // 
            this.lblContCor.AutoSize = true;
            this.lblContCor.Location = new System.Drawing.Point(18, 164);
            this.lblContCor.Name = "lblContCor";
            this.lblContCor.Size = new System.Drawing.Size(123, 15);
            this.lblContCor.TabIndex = 37;
            this.lblContCor.Text = "Conta Corrente: **";
            // 
            // txtContCor
            // 
            this.txtContCor.Location = new System.Drawing.Point(163, 157);
            this.txtContCor.MaxLength = 13;
            this.txtContCor.Name = "txtContCor";
            this.txtContCor.Size = new System.Drawing.Size(100, 21);
            this.txtContCor.TabIndex = 63;
            this.txtContCor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtContCor_KeyPress);
            // 
            // lblBanco
            // 
            this.lblBanco.AutoSize = true;
            this.lblBanco.Location = new System.Drawing.Point(18, 57);
            this.lblBanco.Name = "lblBanco";
            this.lblBanco.Size = new System.Drawing.Size(67, 15);
            this.lblBanco.TabIndex = 28;
            this.lblBanco.Text = "Banco: **";
            // 
            // txtAgen
            // 
            this.txtAgen.Location = new System.Drawing.Point(163, 121);
            this.txtAgen.MaxLength = 10;
            this.txtAgen.Name = "txtAgen";
            this.txtAgen.Size = new System.Drawing.Size(100, 21);
            this.txtAgen.TabIndex = 62;
            this.txtAgen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAgen_KeyPress);
            // 
            // txtBanco
            // 
            this.txtBanco.Location = new System.Drawing.Point(163, 54);
            this.txtBanco.MaxLength = 50;
            this.txtBanco.Name = "txtBanco";
            this.txtBanco.Size = new System.Drawing.Size(100, 21);
            this.txtBanco.TabIndex = 60;
            this.txtBanco.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBanco_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 15);
            this.label2.TabIndex = 34;
            this.label2.Text = "Agência: **";
            // 
            // lblFavo
            // 
            this.lblFavo.AutoSize = true;
            this.lblFavo.Location = new System.Drawing.Point(18, 95);
            this.lblFavo.Name = "lblFavo";
            this.lblFavo.Size = new System.Drawing.Size(97, 15);
            this.lblFavo.TabIndex = 32;
            this.lblFavo.Text = "Favorecido: **";
            // 
            // txtFavo
            // 
            this.txtFavo.Location = new System.Drawing.Point(163, 88);
            this.txtFavo.MaxLength = 50;
            this.txtFavo.Name = "txtFavo";
            this.txtFavo.Size = new System.Drawing.Size(100, 21);
            this.txtFavo.TabIndex = 61;
            this.txtFavo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFavo_KeyPress);
            // 
            // cmbEst
            // 
            this.cmbEst.DisplayMember = "Selecionar";
            this.cmbEst.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEst.FlatStyle = System.Windows.Forms.FlatStyle.System;
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
            this.cmbEst.Location = new System.Drawing.Point(416, 7);
            this.cmbEst.MaxLength = 2;
            this.cmbEst.Name = "cmbEst";
            this.cmbEst.Size = new System.Drawing.Size(118, 23);
            this.cmbEst.TabIndex = 54;
            this.cmbEst.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbEst_KeyPress);
            // 
            // mtxtCep
            // 
            this.mtxtCep.Location = new System.Drawing.Point(102, 144);
            this.mtxtCep.Mask = "00000-000";
            this.mtxtCep.Name = "mtxtCep";
            this.mtxtCep.Size = new System.Drawing.Size(81, 21);
            this.mtxtCep.TabIndex = 47;
            this.mtxtCep.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtxtCep_KeyPress);
            // 
            // txtEmail
            // 
            this.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEmail.Location = new System.Drawing.Point(416, 40);
            this.txtEmail.MaxLength = 40;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(242, 21);
            this.txtEmail.TabIndex = 55;
            this.txtEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmail_KeyPress);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(350, 43);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(53, 15);
            this.lblEmail.TabIndex = 66;
            this.lblEmail.Text = "E-mail:";
            // 
            // lblEst
            // 
            this.lblEst.AutoSize = true;
            this.lblEst.Location = new System.Drawing.Point(350, 10);
            this.lblEst.Name = "lblEst";
            this.lblEst.Size = new System.Drawing.Size(55, 15);
            this.lblEst.TabIndex = 65;
            this.lblEst.Text = "Estado:";
            // 
            // lblCep
            // 
            this.lblCep.AutoSize = true;
            this.lblCep.Location = new System.Drawing.Point(15, 147);
            this.lblCep.Name = "lblCep";
            this.lblCep.Size = new System.Drawing.Size(38, 15);
            this.lblCep.TabIndex = 64;
            this.lblCep.Text = "CEP:";
            // 
            // txtRespCad
            // 
            this.txtRespCad.Location = new System.Drawing.Point(537, 95);
            this.txtRespCad.MaxLength = 40;
            this.txtRespCad.Name = "txtRespCad";
            this.txtRespCad.Size = new System.Drawing.Size(121, 21);
            this.txtRespCad.TabIndex = 56;
            this.txtRespCad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRespCad_KeyPress);
            // 
            // lblRespCad
            // 
            this.lblRespCad.AutoSize = true;
            this.lblRespCad.Location = new System.Drawing.Point(350, 98);
            this.lblRespCad.Name = "lblRespCad";
            this.lblRespCad.Size = new System.Drawing.Size(184, 15);
            this.lblRespCad.TabIndex = 63;
            this.lblRespCad.Text = "Responsável pelo cadastro:";
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Location = new System.Drawing.Point(15, 326);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(67, 15);
            this.lblTel.TabIndex = 62;
            this.lblTel.Text = "Telefone:";
            // 
            // txtCid
            // 
            this.txtCid.Location = new System.Drawing.Point(102, 285);
            this.txtCid.MaxLength = 60;
            this.txtCid.Name = "txtCid";
            this.txtCid.Size = new System.Drawing.Size(183, 21);
            this.txtCid.TabIndex = 52;
            this.txtCid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCid_KeyPress);
            // 
            // lblCid
            // 
            this.lblCid.AutoSize = true;
            this.lblCid.Location = new System.Drawing.Point(15, 289);
            this.lblCid.Name = "lblCid";
            this.lblCid.Size = new System.Drawing.Size(56, 15);
            this.lblCid.TabIndex = 61;
            this.lblCid.Text = "Cidade:";
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(102, 256);
            this.txtBairro.MaxLength = 15;
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(183, 21);
            this.txtBairro.TabIndex = 51;
            this.txtBairro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBairro_KeyPress);
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Location = new System.Drawing.Point(15, 259);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(50, 15);
            this.lblBairro.TabIndex = 59;
            this.lblBairro.Text = "Bairro:";
            // 
            // txtEnd
            // 
            this.txtEnd.Location = new System.Drawing.Point(102, 191);
            this.txtEnd.MaxLength = 80;
            this.txtEnd.Name = "txtEnd";
            this.txtEnd.Size = new System.Drawing.Size(183, 21);
            this.txtEnd.TabIndex = 49;
            this.txtEnd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEnd_KeyPress);
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.Location = new System.Drawing.Point(15, 194);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(72, 15);
            this.lblEnd.TabIndex = 57;
            this.lblEnd.Text = "Endereço:";
            // 
            // txtNomFant
            // 
            this.txtNomFant.Location = new System.Drawing.Point(124, 52);
            this.txtNomFant.MaxLength = 80;
            this.txtNomFant.Name = "txtNomFant";
            this.txtNomFant.Size = new System.Drawing.Size(163, 21);
            this.txtNomFant.TabIndex = 44;
            this.txtNomFant.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNomFant_KeyPress);
            // 
            // lblNomFant
            // 
            this.lblNomFant.AutoSize = true;
            this.lblNomFant.Location = new System.Drawing.Point(15, 55);
            this.lblNomFant.Name = "lblNomFant";
            this.lblNomFant.Size = new System.Drawing.Size(108, 15);
            this.lblNomFant.TabIndex = 55;
            this.lblNomFant.Text = "Nome Fantasia:";
            // 
            // lblCnpj
            // 
            this.lblCnpj.AutoSize = true;
            this.lblCnpj.Location = new System.Drawing.Point(15, 101);
            this.lblCnpj.Name = "lblCnpj";
            this.lblCnpj.Size = new System.Drawing.Size(46, 15);
            this.lblCnpj.TabIndex = 52;
            this.lblCnpj.Text = "CNPJ:";
            // 
            // txtRazSoc
            // 
            this.txtRazSoc.Location = new System.Drawing.Point(112, 12);
            this.txtRazSoc.MaxLength = 80;
            this.txtRazSoc.Name = "txtRazSoc";
            this.txtRazSoc.Size = new System.Drawing.Size(175, 21);
            this.txtRazSoc.TabIndex = 43;
            this.txtRazSoc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRazSoc_KeyPress);
            // 
            // lblRazSoc
            // 
            this.lblRazSoc.AutoSize = true;
            this.lblRazSoc.Location = new System.Drawing.Point(15, 15);
            this.lblRazSoc.Name = "lblRazSoc";
            this.lblRazSoc.Size = new System.Drawing.Size(96, 15);
            this.lblRazSoc.TabIndex = 45;
            this.lblRazSoc.Text = "Razão Social:";
            // 
            // txtSuplente
            // 
            this.txtSuplente.Location = new System.Drawing.Point(442, 154);
            this.txtSuplente.MaxLength = 40;
            this.txtSuplente.Name = "txtSuplente";
            this.txtSuplente.Size = new System.Drawing.Size(216, 21);
            this.txtSuplente.TabIndex = 58;
            this.txtSuplente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSuplente_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(350, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 15);
            this.label1.TabIndex = 72;
            this.label1.Text = "Suplente: **";
            // 
            // mskRgAt
            // 
            this.mskRgAt.Location = new System.Drawing.Point(440, 122);
            this.mskRgAt.Mask = "00.000.000-0";
            this.mskRgAt.Name = "mskRgAt";
            this.mskRgAt.Size = new System.Drawing.Size(121, 21);
            this.mskRgAt.TabIndex = 57;
            this.mskRgAt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mskRgAt_KeyPress);
            // 
            // mskRgSu
            // 
            this.mskRgSu.Location = new System.Drawing.Point(495, 185);
            this.mskRgSu.Mask = "00.000.000-0";
            this.mskRgSu.Name = "mskRgSu";
            this.mskRgSu.Size = new System.Drawing.Size(121, 21);
            this.mskRgSu.TabIndex = 59;
            this.mskRgSu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mskRgSu_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(350, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 15);
            this.label3.TabIndex = 75;
            this.label3.Text = "RG Titular:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(350, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 15);
            this.label4.TabIndex = 76;
            this.label4.Text = "RG Suplente: **";
            // 
            // gpCadAgen
            // 
            this.gpCadAgen.BackColor = System.Drawing.Color.Transparent;
            this.gpCadAgen.CanvasColor = System.Drawing.SystemColors.Control;
            this.gpCadAgen.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.gpCadAgen.Controls.Add(this.label5);
            this.gpCadAgen.Controls.Add(this.txtNum);
            this.gpCadAgen.Controls.Add(this.btnCompCep);
            this.gpCadAgen.Controls.Add(this.btnCadastrar);
            this.gpCadAgen.Controls.Add(this.label4);
            this.gpCadAgen.Controls.Add(this.label3);
            this.gpCadAgen.Controls.Add(this.lblRazSoc);
            this.gpCadAgen.Controls.Add(this.mskRgSu);
            this.gpCadAgen.Controls.Add(this.txtRazSoc);
            this.gpCadAgen.Controls.Add(this.mskRgAt);
            this.gpCadAgen.Controls.Add(this.lblCnpj);
            this.gpCadAgen.Controls.Add(this.txtSuplente);
            this.gpCadAgen.Controls.Add(this.lblNomFant);
            this.gpCadAgen.Controls.Add(this.label1);
            this.gpCadAgen.Controls.Add(this.txtNomFant);
            this.gpCadAgen.Controls.Add(this.lblAviEmail);
            this.gpCadAgen.Controls.Add(this.lblEnd);
            this.gpCadAgen.Controls.Add(this.txtEnd);
            this.gpCadAgen.Controls.Add(this.lblBairro);
            this.gpCadAgen.Controls.Add(this.mtxtTel);
            this.gpCadAgen.Controls.Add(this.txtBairro);
            this.gpCadAgen.Controls.Add(this.mtxtCnpj);
            this.gpCadAgen.Controls.Add(this.lblCid);
            this.gpCadAgen.Controls.Add(this.groupBox1);
            this.gpCadAgen.Controls.Add(this.txtCid);
            this.gpCadAgen.Controls.Add(this.cmbEst);
            this.gpCadAgen.Controls.Add(this.lblTel);
            this.gpCadAgen.Controls.Add(this.mtxtCep);
            this.gpCadAgen.Controls.Add(this.lblRespCad);
            this.gpCadAgen.Controls.Add(this.txtEmail);
            this.gpCadAgen.Controls.Add(this.txtRespCad);
            this.gpCadAgen.Controls.Add(this.lblEmail);
            this.gpCadAgen.Controls.Add(this.lblCep);
            this.gpCadAgen.Controls.Add(this.lblEst);
            this.gpCadAgen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpCadAgen.Location = new System.Drawing.Point(6, 40);
            this.gpCadAgen.Name = "gpCadAgen";
            this.gpCadAgen.Size = new System.Drawing.Size(772, 507);
            // 
            // 
            // 
            this.gpCadAgen.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.gpCadAgen.Style.BackColorGradientAngle = 90;
            this.gpCadAgen.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.gpCadAgen.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gpCadAgen.Style.BorderBottomWidth = 1;
            this.gpCadAgen.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.gpCadAgen.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gpCadAgen.Style.BorderLeftWidth = 1;
            this.gpCadAgen.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gpCadAgen.Style.BorderRightWidth = 1;
            this.gpCadAgen.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gpCadAgen.Style.BorderTopWidth = 1;
            this.gpCadAgen.Style.Class = "";
            this.gpCadAgen.Style.CornerDiameter = 4;
            this.gpCadAgen.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.gpCadAgen.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.gpCadAgen.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.gpCadAgen.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.gpCadAgen.StyleMouseDown.Class = "";
            this.gpCadAgen.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.gpCadAgen.StyleMouseOver.Class = "";
            this.gpCadAgen.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.gpCadAgen.TabIndex = 77;
            this.gpCadAgen.Text = "Cadastro Agência";
            this.gpCadAgen.Click += new System.EventHandler(this.gpCadAgen_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 15);
            this.label5.TabIndex = 87;
            this.label5.Text = "Número:";
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(102, 223);
            this.txtNum.MaxLength = 8;
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(149, 21);
            this.txtNum.TabIndex = 50;
            this.txtNum.TextChanged += new System.EventHandler(this.txtNum_TextChanged);
            this.txtNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNum_KeyPress);
            // 
            // btnCompCep
            // 
            this.btnCompCep.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCompCep.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCompCep.Location = new System.Drawing.Point(189, 136);
            this.btnCompCep.Name = "btnCompCep";
            this.btnCompCep.Size = new System.Drawing.Size(105, 30);
            this.btnCompCep.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCompCep.TabIndex = 48;
            this.btnCompCep.Text = "Completar CEP";
            this.btnCompCep.Click += new System.EventHandler(this.btnComCep_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCadastrar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Location = new System.Drawing.Point(526, 448);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(187, 30);
            this.btnCadastrar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCadastrar.TabIndex = 64;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.Click += new System.EventHandler(this.btnIncluir_Click);
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
            this.labelX1.Location = new System.Drawing.Point(6, 11);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(325, 23);
            this.labelX1.TabIndex = 78;
            this.labelX1.Text = "Entre com as informações abaixo:";
            // 
            // frmCadastroAgencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(788, 555);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.gpCadAgen);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.Name = "frmCadastroAgencia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Agência";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gpCadAgen.ResumeLayout(false);
            this.gpCadAgen.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblAviEmail;
        private System.Windows.Forms.Label lblAviso;
        private System.Windows.Forms.MaskedTextBox mtxtTel;
        private System.Windows.Forms.MaskedTextBox mtxtCnpj;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblContCor;
        private System.Windows.Forms.TextBox txtContCor;
        private System.Windows.Forms.Label lblBanco;
        private System.Windows.Forms.TextBox txtAgen;
        private System.Windows.Forms.TextBox txtBanco;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblFavo;
        private System.Windows.Forms.TextBox txtFavo;
        private System.Windows.Forms.ComboBox cmbEst;
        private System.Windows.Forms.MaskedTextBox mtxtCep;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblEst;
        private System.Windows.Forms.Label lblCep;
        private System.Windows.Forms.TextBox txtRespCad;
        private System.Windows.Forms.Label lblRespCad;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.TextBox txtCid;
        private System.Windows.Forms.Label lblCid;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.TextBox txtEnd;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.TextBox txtNomFant;
        private System.Windows.Forms.Label lblNomFant;
        private System.Windows.Forms.Label lblCnpj;
        private System.Windows.Forms.TextBox txtRazSoc;
        private System.Windows.Forms.Label lblRazSoc;
        private System.Windows.Forms.TextBox txtSuplente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mskRgAt;
        private System.Windows.Forms.MaskedTextBox mskRgSu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private DevComponents.DotNetBar.Controls.GroupPanel gpCadAgen;
        private DevComponents.DotNetBar.ButtonX btnCadastrar;
        private DevComponents.DotNetBar.ButtonX btnCompCep;
        private DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNum;
    }
}