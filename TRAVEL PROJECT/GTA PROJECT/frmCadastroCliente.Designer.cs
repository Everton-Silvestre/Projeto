namespace GTA_PROJECT
{
    partial class frmCadastroCliente
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
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.lblBairro = new System.Windows.Forms.Label();
            this.mtxtCep = new System.Windows.Forms.MaskedTextBox();
            this.mtxtCpf = new System.Windows.Forms.MaskedTextBox();
            this.mtxtTel = new System.Windows.Forms.MaskedTextBox();
            this.mtxtRg = new System.Windows.Forms.MaskedTextBox();
            this.cmbEst = new System.Windows.Forms.ComboBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtCid = new System.Windows.Forms.TextBox();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.txtEnd = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblCep = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblCid = new System.Windows.Forms.Label();
            this.lblRg = new System.Windows.Forms.Label();
            this.lblCpf = new System.Windows.Forms.Label();
            this.lblTel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblEnd = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblAviso = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblContCor = new System.Windows.Forms.Label();
            this.txtContCor = new System.Windows.Forms.TextBox();
            this.lblBanco = new System.Windows.Forms.Label();
            this.txtAgen = new System.Windows.Forms.TextBox();
            this.txtBanco = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFavo = new System.Windows.Forms.Label();
            this.txtFavo = new System.Windows.Forms.TextBox();
            this.gpCadCli = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.btnCompCep = new DevComponents.DotNetBar.ButtonX();
            this.lblAviEmail = new System.Windows.Forms.Label();
            this.btnCadastrar = new DevComponents.DotNetBar.ButtonX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.groupBox1.SuspendLayout();
            this.gpCadCli.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(423, 103);
            this.txtBairro.MaxLength = 40;
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(202, 21);
            this.txtBairro.TabIndex = 11;
            this.txtBairro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBairro_KeyPress);
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.BackColor = System.Drawing.Color.Transparent;
            this.lblBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBairro.Location = new System.Drawing.Point(355, 110);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(50, 15);
            this.lblBairro.TabIndex = 51;
            this.lblBairro.Text = "Bairro:";
            // 
            // mtxtCep
            // 
            this.mtxtCep.Location = new System.Drawing.Point(424, 6);
            this.mtxtCep.Mask = "00000-000";
            this.mtxtCep.Name = "mtxtCep";
            this.mtxtCep.Size = new System.Drawing.Size(81, 21);
            this.mtxtCep.TabIndex = 7;
            this.mtxtCep.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtxtCep_KeyPress);
            // 
            // mtxtCpf
            // 
            this.mtxtCpf.Location = new System.Drawing.Point(79, 84);
            this.mtxtCpf.Mask = "000.000.000/00";
            this.mtxtCpf.Name = "mtxtCpf";
            this.mtxtCpf.Size = new System.Drawing.Size(110, 21);
            this.mtxtCpf.TabIndex = 3;
            this.mtxtCpf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtxtCpf_KeyPress);
            // 
            // mtxtTel
            // 
            this.mtxtTel.Location = new System.Drawing.Point(81, 121);
            this.mtxtTel.Mask = "(00)0000-0000";
            this.mtxtTel.Name = "mtxtTel";
            this.mtxtTel.Size = new System.Drawing.Size(108, 21);
            this.mtxtTel.TabIndex = 4;
            this.mtxtTel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtxtTel_KeyPress);
            // 
            // mtxtRg
            // 
            this.mtxtRg.Location = new System.Drawing.Point(79, 48);
            this.mtxtRg.Mask = "00.000.000-0";
            this.mtxtRg.Name = "mtxtRg";
            this.mtxtRg.Size = new System.Drawing.Size(110, 21);
            this.mtxtRg.TabIndex = 2;
            this.mtxtRg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtxtRg_KeyPress);
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
            this.cmbEst.Location = new System.Drawing.Point(423, 170);
            this.cmbEst.Name = "cmbEst";
            this.cmbEst.Size = new System.Drawing.Size(81, 23);
            this.cmbEst.TabIndex = 13;
            this.cmbEst.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbEst_KeyPress);
            // 
            // txtEmail
            // 
            this.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEmail.Location = new System.Drawing.Point(81, 153);
            this.txtEmail.MaxLength = 40;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(246, 21);
            this.txtEmail.TabIndex = 5;
            this.txtEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmail_KeyPress);
            // 
            // txtCid
            // 
            this.txtCid.Location = new System.Drawing.Point(423, 138);
            this.txtCid.MaxLength = 40;
            this.txtCid.Name = "txtCid";
            this.txtCid.Size = new System.Drawing.Size(202, 21);
            this.txtCid.TabIndex = 12;
            this.txtCid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCid_KeyPress);
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(424, 74);
            this.txtNum.MaxLength = 11;
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(201, 21);
            this.txtNum.TabIndex = 10;
            this.txtNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNum_KeyPress);
            // 
            // txtEnd
            // 
            this.txtEnd.Location = new System.Drawing.Point(424, 34);
            this.txtEnd.MaxLength = 60;
            this.txtEnd.Name = "txtEnd";
            this.txtEnd.Size = new System.Drawing.Size(201, 21);
            this.txtEnd.TabIndex = 9;
            this.txtEnd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEnd_KeyPress);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(79, 16);
            this.txtNome.MaxLength = 60;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(253, 21);
            this.txtNome.TabIndex = 1;
            this.txtNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNome_KeyPress);
            // 
            // lblCep
            // 
            this.lblCep.AutoSize = true;
            this.lblCep.BackColor = System.Drawing.Color.Transparent;
            this.lblCep.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCep.Location = new System.Drawing.Point(356, 9);
            this.lblCep.Name = "lblCep";
            this.lblCep.Size = new System.Drawing.Size(34, 15);
            this.lblCep.TabIndex = 39;
            this.lblCep.Text = "CEP";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(22, 159);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(48, 15);
            this.lblEmail.TabIndex = 38;
            this.lblEmail.Text = "Email:";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.BackColor = System.Drawing.Color.Transparent;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(355, 169);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(51, 15);
            this.lblEstado.TabIndex = 37;
            this.lblEstado.Text = "Estado";
            // 
            // lblCid
            // 
            this.lblCid.AutoSize = true;
            this.lblCid.BackColor = System.Drawing.Color.Transparent;
            this.lblCid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCid.Location = new System.Drawing.Point(355, 138);
            this.lblCid.Name = "lblCid";
            this.lblCid.Size = new System.Drawing.Size(52, 15);
            this.lblCid.TabIndex = 36;
            this.lblCid.Text = "Cidade";
            // 
            // lblRg
            // 
            this.lblRg.AutoSize = true;
            this.lblRg.BackColor = System.Drawing.Color.Transparent;
            this.lblRg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRg.Location = new System.Drawing.Point(39, 54);
            this.lblRg.Name = "lblRg";
            this.lblRg.Size = new System.Drawing.Size(31, 15);
            this.lblRg.TabIndex = 35;
            this.lblRg.Text = "RG:";
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.BackColor = System.Drawing.Color.Transparent;
            this.lblCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpf.Location = new System.Drawing.Point(33, 90);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(37, 15);
            this.lblCpf.TabIndex = 34;
            this.lblCpf.Text = "CPF:";
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.BackColor = System.Drawing.Color.Transparent;
            this.lblTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTel.Location = new System.Drawing.Point(3, 124);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(67, 15);
            this.lblTel.TabIndex = 33;
            this.lblTel.Text = "Telefone:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(355, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 15);
            this.label3.TabIndex = 32;
            this.label3.Text = "Número:";
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.BackColor = System.Drawing.Color.Transparent;
            this.lblEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnd.Location = new System.Drawing.Point(345, 40);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(72, 15);
            this.lblEnd.TabIndex = 31;
            this.lblEnd.Text = "Endereço:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.Color.Transparent;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(21, 19);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(49, 15);
            this.lblNome.TabIndex = 30;
            this.lblNome.Text = "Nome:";
            // 
            // lblAviso
            // 
            this.lblAviso.AutoSize = true;
            this.lblAviso.ForeColor = System.Drawing.Color.Red;
            this.lblAviso.Location = new System.Drawing.Point(465, 16);
            this.lblAviso.Name = "lblAviso";
            this.lblAviso.Size = new System.Drawing.Size(165, 15);
            this.lblAviso.TabIndex = 70;
            this.lblAviso.Text = "** Itens Não obrigatórios";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.lblAviso);
            this.groupBox1.Controls.Add(this.lblContCor);
            this.groupBox1.Controls.Add(this.txtContCor);
            this.groupBox1.Controls.Add(this.lblBanco);
            this.groupBox1.Controls.Add(this.txtAgen);
            this.groupBox1.Controls.Add(this.txtBanco);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblFavo);
            this.groupBox1.Controls.Add(this.txtFavo);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(22, 223);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(639, 164);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados Bancarios **";
            // 
            // lblContCor
            // 
            this.lblContCor.AutoSize = true;
            this.lblContCor.Location = new System.Drawing.Point(6, 134);
            this.lblContCor.Name = "lblContCor";
            this.lblContCor.Size = new System.Drawing.Size(123, 15);
            this.lblContCor.TabIndex = 37;
            this.lblContCor.Text = "Conta Corrente: **";
            // 
            // txtContCor
            // 
            this.txtContCor.Location = new System.Drawing.Point(151, 127);
            this.txtContCor.MaxLength = 13;
            this.txtContCor.Name = "txtContCor";
            this.txtContCor.Size = new System.Drawing.Size(100, 21);
            this.txtContCor.TabIndex = 17;
            this.txtContCor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtContCor_KeyPress);
            // 
            // lblBanco
            // 
            this.lblBanco.AutoSize = true;
            this.lblBanco.Location = new System.Drawing.Point(6, 27);
            this.lblBanco.Name = "lblBanco";
            this.lblBanco.Size = new System.Drawing.Size(67, 15);
            this.lblBanco.TabIndex = 28;
            this.lblBanco.Text = "Banco: **";
            // 
            // txtAgen
            // 
            this.txtAgen.Location = new System.Drawing.Point(151, 91);
            this.txtAgen.MaxLength = 10;
            this.txtAgen.Name = "txtAgen";
            this.txtAgen.Size = new System.Drawing.Size(100, 21);
            this.txtAgen.TabIndex = 16;
            this.txtAgen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAgen_KeyPress);
            // 
            // txtBanco
            // 
            this.txtBanco.Location = new System.Drawing.Point(151, 24);
            this.txtBanco.MaxLength = 50;
            this.txtBanco.Name = "txtBanco";
            this.txtBanco.Size = new System.Drawing.Size(100, 21);
            this.txtBanco.TabIndex = 14;
            this.txtBanco.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBanco_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 15);
            this.label1.TabIndex = 34;
            this.label1.Text = "Agência: **";
            // 
            // lblFavo
            // 
            this.lblFavo.AutoSize = true;
            this.lblFavo.Location = new System.Drawing.Point(6, 65);
            this.lblFavo.Name = "lblFavo";
            this.lblFavo.Size = new System.Drawing.Size(97, 15);
            this.lblFavo.TabIndex = 32;
            this.lblFavo.Text = "Favorecido: **";
            // 
            // txtFavo
            // 
            this.txtFavo.Location = new System.Drawing.Point(151, 58);
            this.txtFavo.MaxLength = 50;
            this.txtFavo.Name = "txtFavo";
            this.txtFavo.Size = new System.Drawing.Size(100, 21);
            this.txtFavo.TabIndex = 15;
            this.txtFavo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFavo_KeyPress);
            // 
            // gpCadCli
            // 
            this.gpCadCli.BackColor = System.Drawing.Color.Transparent;
            this.gpCadCli.CanvasColor = System.Drawing.SystemColors.Control;
            this.gpCadCli.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.gpCadCli.Controls.Add(this.btnCompCep);
            this.gpCadCli.Controls.Add(this.lblAviEmail);
            this.gpCadCli.Controls.Add(this.btnCadastrar);
            this.gpCadCli.Controls.Add(this.groupBox1);
            this.gpCadCli.Controls.Add(this.lblNome);
            this.gpCadCli.Controls.Add(this.txtBairro);
            this.gpCadCli.Controls.Add(this.lblEnd);
            this.gpCadCli.Controls.Add(this.lblBairro);
            this.gpCadCli.Controls.Add(this.label3);
            this.gpCadCli.Controls.Add(this.lblTel);
            this.gpCadCli.Controls.Add(this.mtxtCep);
            this.gpCadCli.Controls.Add(this.lblCpf);
            this.gpCadCli.Controls.Add(this.mtxtCpf);
            this.gpCadCli.Controls.Add(this.lblRg);
            this.gpCadCli.Controls.Add(this.mtxtTel);
            this.gpCadCli.Controls.Add(this.lblCid);
            this.gpCadCli.Controls.Add(this.mtxtRg);
            this.gpCadCli.Controls.Add(this.lblEstado);
            this.gpCadCli.Controls.Add(this.lblEmail);
            this.gpCadCli.Controls.Add(this.cmbEst);
            this.gpCadCli.Controls.Add(this.lblCep);
            this.gpCadCli.Controls.Add(this.txtEmail);
            this.gpCadCli.Controls.Add(this.txtNome);
            this.gpCadCli.Controls.Add(this.txtCid);
            this.gpCadCli.Controls.Add(this.txtEnd);
            this.gpCadCli.Controls.Add(this.txtNum);
            this.gpCadCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpCadCli.Location = new System.Drawing.Point(7, 39);
            this.gpCadCli.Name = "gpCadCli";
            this.gpCadCli.Size = new System.Drawing.Size(674, 451);
            // 
            // 
            // 
            this.gpCadCli.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.gpCadCli.Style.BackColorGradientAngle = 90;
            this.gpCadCli.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.gpCadCli.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gpCadCli.Style.BorderBottomWidth = 1;
            this.gpCadCli.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.gpCadCli.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gpCadCli.Style.BorderLeftWidth = 1;
            this.gpCadCli.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gpCadCli.Style.BorderRightWidth = 1;
            this.gpCadCli.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gpCadCli.Style.BorderTopWidth = 1;
            this.gpCadCli.Style.Class = "";
            this.gpCadCli.Style.CornerDiameter = 4;
            this.gpCadCli.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.gpCadCli.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.gpCadCli.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.gpCadCli.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.gpCadCli.StyleMouseDown.Class = "";
            this.gpCadCli.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.gpCadCli.StyleMouseOver.Class = "";
            this.gpCadCli.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.gpCadCli.TabIndex = 53;
            this.gpCadCli.Text = "Cadastro Cliente";
            // 
            // btnCompCep
            // 
            this.btnCompCep.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCompCep.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCompCep.Location = new System.Drawing.Point(511, 6);
            this.btnCompCep.Name = "btnCompCep";
            this.btnCompCep.Size = new System.Drawing.Size(114, 22);
            this.btnCompCep.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCompCep.TabIndex = 72;
            this.btnCompCep.Text = "Completar CEP";
            this.btnCompCep.Click += new System.EventHandler(this.btnCompCep_Click);
            // 
            // lblAviEmail
            // 
            this.lblAviEmail.ForeColor = System.Drawing.Color.Red;
            this.lblAviEmail.Location = new System.Drawing.Point(8, 184);
            this.lblAviEmail.Name = "lblAviEmail";
            this.lblAviEmail.Size = new System.Drawing.Size(315, 36);
            this.lblAviEmail.TabIndex = 71;
            this.lblAviEmail.Text = "ATENÇÃO: Este e-mail será utilizado para login no sistema";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCadastrar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCadastrar.Location = new System.Drawing.Point(474, 396);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(187, 30);
            this.btnCadastrar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCadastrar.TabIndex = 52;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
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
            this.labelX1.Location = new System.Drawing.Point(12, 10);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(325, 23);
            this.labelX1.TabIndex = 54;
            this.labelX1.Text = "Entre com as informações abaixo:";
            // 
            // frmCadastroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(686, 495);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.gpCadCli);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frmCadastroCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Cliente";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gpCadCli.ResumeLayout(false);
            this.gpCadCli.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.MaskedTextBox mtxtCep;
        private System.Windows.Forms.MaskedTextBox mtxtCpf;
        private System.Windows.Forms.MaskedTextBox mtxtTel;
        private System.Windows.Forms.MaskedTextBox mtxtRg;
        private System.Windows.Forms.ComboBox cmbEst;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtCid;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.TextBox txtEnd;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblCep;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblCid;
        private System.Windows.Forms.Label lblRg;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblAviso;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblContCor;
        private System.Windows.Forms.TextBox txtContCor;
        private System.Windows.Forms.Label lblBanco;
        private System.Windows.Forms.TextBox txtAgen;
        private System.Windows.Forms.TextBox txtBanco;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFavo;
        private System.Windows.Forms.TextBox txtFavo;
        private DevComponents.DotNetBar.Controls.GroupPanel gpCadCli;
        private DevComponents.DotNetBar.ButtonX btnCadastrar;
        private DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.Label lblAviEmail;
        private DevComponents.DotNetBar.ButtonX btnCompCep;
    }
}