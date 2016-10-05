namespace GTA_PROJECT
{
    partial class frmCotacao
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
            this.label3 = new System.Windows.Forms.Label();
            this.cmbTipoPlan = new System.Windows.Forms.ComboBox();
            this.lblTipoPlan = new System.Windows.Forms.Label();
            this.cmbPlano = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbDias = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtQuant = new System.Windows.Forms.NumericUpDown();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.btnEmiCota02 = new DevComponents.DotNetBar.ButtonX();
            this.btnLimpar02 = new DevComponents.DotNetBar.ButtonX();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblValResp03 = new System.Windows.Forms.Label();
            this.lblValResp02 = new System.Windows.Forms.Label();
            this.lblValor03 = new System.Windows.Forms.Label();
            this.lblQuant03 = new System.Windows.Forms.Label();
            this.lblDias03 = new System.Windows.Forms.Label();
            this.lblPlan03 = new System.Windows.Forms.Label();
            this.lblTipPlan03 = new System.Windows.Forms.Label();
            this.lblValor02 = new System.Windows.Forms.Label();
            this.lblQuant02 = new System.Windows.Forms.Label();
            this.lblDias02 = new System.Windows.Forms.Label();
            this.lblPlan02 = new System.Windows.Forms.Label();
            this.lblTipPlan02 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblValRel01 = new System.Windows.Forms.Label();
            this.lblValRel = new System.Windows.Forms.Label();
            this.lblVal01 = new System.Windows.Forms.Label();
            this.lblQuant01 = new System.Windows.Forms.Label();
            this.lblDias01 = new System.Windows.Forms.Label();
            this.lblPlan01 = new System.Windows.Forms.Label();
            this.lblTipPlan01 = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblQuant = new System.Windows.Forms.Label();
            this.lblDias = new System.Windows.Forms.Label();
            this.lblPlan = new System.Windows.Forms.Label();
            this.lblTipPlan = new System.Windows.Forms.Label();
            this.btnLimpar = new DevComponents.DotNetBar.ButtonX();
            this.btnEmiCota01 = new DevComponents.DotNetBar.ButtonX();
            this.btnCotar = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuant)).BeginInit();
            this.groupPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Quantidade de pessoas:";
            // 
            // cmbTipoPlan
            // 
            this.cmbTipoPlan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoPlan.FormattingEnabled = true;
            this.cmbTipoPlan.Items.AddRange(new object[] {
            "INTERNACIONAL",
            "NACIONAIS",
            "MARITIMO",
            "CORPORATIVO",
            "PRATICA DE ESPORTES",
            "RECEPTIVO",
            "STUDENT"});
            this.cmbTipoPlan.Location = new System.Drawing.Point(109, 47);
            this.cmbTipoPlan.Name = "cmbTipoPlan";
            this.cmbTipoPlan.Size = new System.Drawing.Size(153, 23);
            this.cmbTipoPlan.TabIndex = 9;
            this.cmbTipoPlan.SelectedIndexChanged += new System.EventHandler(this.cmbTipoPlan_SelectedIndexChanged);
            // 
            // lblTipoPlan
            // 
            this.lblTipoPlan.AutoSize = true;
            this.lblTipoPlan.BackColor = System.Drawing.Color.Transparent;
            this.lblTipoPlan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoPlan.Location = new System.Drawing.Point(25, 50);
            this.lblTipoPlan.Name = "lblTipoPlan";
            this.lblTipoPlan.Size = new System.Drawing.Size(80, 15);
            this.lblTipoPlan.TabIndex = 8;
            this.lblTipoPlan.Text = "Tipo Plano:";
            // 
            // cmbPlano
            // 
            this.cmbPlano.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPlano.FormattingEnabled = true;
            this.cmbPlano.Location = new System.Drawing.Point(109, 81);
            this.cmbPlano.Name = "cmbPlano";
            this.cmbPlano.Size = new System.Drawing.Size(153, 23);
            this.cmbPlano.TabIndex = 11;
            this.cmbPlano.SelectedIndexChanged += new System.EventHandler(this.cmbPlano_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Planos:";
            // 
            // cmbDias
            // 
            this.cmbDias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDias.FormattingEnabled = true;
            this.cmbDias.Location = new System.Drawing.Point(109, 112);
            this.cmbDias.Name = "cmbDias";
            this.cmbDias.Size = new System.Drawing.Size(153, 23);
            this.cmbDias.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(52, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 15);
            this.label4.TabIndex = 27;
            this.label4.Text = "Dias:";
            // 
            // txtQuant
            // 
            this.txtQuant.Location = new System.Drawing.Point(174, 148);
            this.txtQuant.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.txtQuant.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtQuant.Name = "txtQuant";
            this.txtQuant.Size = new System.Drawing.Size(88, 21);
            this.txtQuant.TabIndex = 33;
            this.txtQuant.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtQuant.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // groupPanel1
            // 
            this.groupPanel1.BackColor = System.Drawing.Color.Transparent;
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.btnEmiCota02);
            this.groupPanel1.Controls.Add(this.btnLimpar02);
            this.groupPanel1.Controls.Add(this.groupBox2);
            this.groupPanel1.Controls.Add(this.groupBox1);
            this.groupPanel1.Controls.Add(this.btnLimpar);
            this.groupPanel1.Controls.Add(this.btnEmiCota01);
            this.groupPanel1.Controls.Add(this.btnCotar);
            this.groupPanel1.Controls.Add(this.txtQuant);
            this.groupPanel1.Controls.Add(this.cmbDias);
            this.groupPanel1.Controls.Add(this.label4);
            this.groupPanel1.Controls.Add(this.label3);
            this.groupPanel1.Controls.Add(this.cmbPlano);
            this.groupPanel1.Controls.Add(this.lblTipoPlan);
            this.groupPanel1.Controls.Add(this.label1);
            this.groupPanel1.Controls.Add(this.cmbTipoPlan);
            this.groupPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupPanel1.Location = new System.Drawing.Point(12, 12);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(877, 288);
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
            this.groupPanel1.TabIndex = 36;
            // 
            // btnEmiCota02
            // 
            this.btnEmiCota02.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnEmiCota02.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnEmiCota02.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnEmiCota02.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEmiCota02.Location = new System.Drawing.Point(589, 212);
            this.btnEmiCota02.Name = "btnEmiCota02";
            this.btnEmiCota02.Size = new System.Drawing.Size(270, 23);
            this.btnEmiCota02.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnEmiCota02.TabIndex = 43;
            this.btnEmiCota02.Text = "Emitir Cotação";
            this.btnEmiCota02.Click += new System.EventHandler(this.btnEmiCota02_Click);
            // 
            // btnLimpar02
            // 
            this.btnLimpar02.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnLimpar02.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnLimpar02.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnLimpar02.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLimpar02.Location = new System.Drawing.Point(589, 241);
            this.btnLimpar02.Name = "btnLimpar02";
            this.btnLimpar02.Size = new System.Drawing.Size(270, 23);
            this.btnLimpar02.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnLimpar02.TabIndex = 42;
            this.btnLimpar02.Text = "Limpar";
            this.btnLimpar02.Click += new System.EventHandler(this.btnLimpar02_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblValResp03);
            this.groupBox2.Controls.Add(this.lblValResp02);
            this.groupBox2.Controls.Add(this.lblValor03);
            this.groupBox2.Controls.Add(this.lblQuant03);
            this.groupBox2.Controls.Add(this.lblDias03);
            this.groupBox2.Controls.Add(this.lblPlan03);
            this.groupBox2.Controls.Add(this.lblTipPlan03);
            this.groupBox2.Controls.Add(this.lblValor02);
            this.groupBox2.Controls.Add(this.lblQuant02);
            this.groupBox2.Controls.Add(this.lblDias02);
            this.groupBox2.Controls.Add(this.lblPlan02);
            this.groupBox2.Controls.Add(this.lblTipPlan02);
            this.groupBox2.Location = new System.Drawing.Point(589, 15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(270, 175);
            this.groupBox2.TabIndex = 41;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "OPÇÃO 02";
            // 
            // lblValResp03
            // 
            this.lblValResp03.Location = new System.Drawing.Point(106, 152);
            this.lblValResp03.Name = "lblValResp03";
            this.lblValResp03.Size = new System.Drawing.Size(158, 13);
            this.lblValResp03.TabIndex = 13;
            // 
            // lblValResp02
            // 
            this.lblValResp02.AutoSize = true;
            this.lblValResp02.Location = new System.Drawing.Point(10, 149);
            this.lblValResp02.Name = "lblValResp02";
            this.lblValResp02.Size = new System.Drawing.Size(90, 15);
            this.lblValResp02.TabIndex = 12;
            this.lblValResp02.Text = "Valor em R$:";
            // 
            // lblValor03
            // 
            this.lblValor03.Location = new System.Drawing.Point(114, 127);
            this.lblValor03.Name = "lblValor03";
            this.lblValor03.Size = new System.Drawing.Size(125, 13);
            this.lblValor03.TabIndex = 9;
            // 
            // lblQuant03
            // 
            this.lblQuant03.Location = new System.Drawing.Point(174, 103);
            this.lblQuant03.Name = "lblQuant03";
            this.lblQuant03.Size = new System.Drawing.Size(65, 13);
            this.lblQuant03.TabIndex = 8;
            // 
            // lblDias03
            // 
            this.lblDias03.Location = new System.Drawing.Point(85, 83);
            this.lblDias03.Name = "lblDias03";
            this.lblDias03.Size = new System.Drawing.Size(154, 13);
            this.lblDias03.TabIndex = 7;
            // 
            // lblPlan03
            // 
            this.lblPlan03.Location = new System.Drawing.Point(85, 60);
            this.lblPlan03.Name = "lblPlan03";
            this.lblPlan03.Size = new System.Drawing.Size(154, 13);
            this.lblPlan03.TabIndex = 6;
            // 
            // lblTipPlan03
            // 
            this.lblTipPlan03.Location = new System.Drawing.Point(85, 33);
            this.lblTipPlan03.Name = "lblTipPlan03";
            this.lblTipPlan03.Size = new System.Drawing.Size(154, 19);
            this.lblTipPlan03.TabIndex = 5;
            // 
            // lblValor02
            // 
            this.lblValor02.AutoSize = true;
            this.lblValor02.Location = new System.Drawing.Point(9, 127);
            this.lblValor02.Name = "lblValor02";
            this.lblValor02.Size = new System.Drawing.Size(99, 15);
            this.lblValor02.TabIndex = 4;
            this.lblValor02.Text = "Valor em US$:";
            // 
            // lblQuant02
            // 
            this.lblQuant02.AutoSize = true;
            this.lblQuant02.Location = new System.Drawing.Point(6, 103);
            this.lblQuant02.Name = "lblQuant02";
            this.lblQuant02.Size = new System.Drawing.Size(162, 15);
            this.lblQuant02.TabIndex = 3;
            this.lblQuant02.Text = "Quantidade de pessoas:";
            // 
            // lblDias02
            // 
            this.lblDias02.AutoSize = true;
            this.lblDias02.Location = new System.Drawing.Point(7, 83);
            this.lblDias02.Name = "lblDias02";
            this.lblDias02.Size = new System.Drawing.Size(40, 15);
            this.lblDias02.TabIndex = 2;
            this.lblDias02.Text = "Dias:";
            // 
            // lblPlan02
            // 
            this.lblPlan02.AutoSize = true;
            this.lblPlan02.Location = new System.Drawing.Point(7, 60);
            this.lblPlan02.Name = "lblPlan02";
            this.lblPlan02.Size = new System.Drawing.Size(55, 15);
            this.lblPlan02.TabIndex = 1;
            this.lblPlan02.Text = "Planos:";
            // 
            // lblTipPlan02
            // 
            this.lblTipPlan02.AutoSize = true;
            this.lblTipPlan02.Location = new System.Drawing.Point(7, 34);
            this.lblTipPlan02.Name = "lblTipPlan02";
            this.lblTipPlan02.Size = new System.Drawing.Size(80, 15);
            this.lblTipPlan02.TabIndex = 0;
            this.lblTipPlan02.Text = "Tipo Plano:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblValRel01);
            this.groupBox1.Controls.Add(this.lblValRel);
            this.groupBox1.Controls.Add(this.lblVal01);
            this.groupBox1.Controls.Add(this.lblQuant01);
            this.groupBox1.Controls.Add(this.lblDias01);
            this.groupBox1.Controls.Add(this.lblPlan01);
            this.groupBox1.Controls.Add(this.lblTipPlan01);
            this.groupBox1.Controls.Add(this.lblValor);
            this.groupBox1.Controls.Add(this.lblQuant);
            this.groupBox1.Controls.Add(this.lblDias);
            this.groupBox1.Controls.Add(this.lblPlan);
            this.groupBox1.Controls.Add(this.lblTipPlan);
            this.groupBox1.Location = new System.Drawing.Point(285, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(276, 178);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "OPÇÃO 01";
            // 
            // lblValRel01
            // 
            this.lblValRel01.Location = new System.Drawing.Point(106, 152);
            this.lblValRel01.Name = "lblValRel01";
            this.lblValRel01.Size = new System.Drawing.Size(164, 13);
            this.lblValRel01.TabIndex = 11;
            // 
            // lblValRel
            // 
            this.lblValRel.AutoSize = true;
            this.lblValRel.Location = new System.Drawing.Point(10, 152);
            this.lblValRel.Name = "lblValRel";
            this.lblValRel.Size = new System.Drawing.Size(90, 15);
            this.lblValRel.TabIndex = 10;
            this.lblValRel.Text = "Valor em R$:";
            // 
            // lblVal01
            // 
            this.lblVal01.Location = new System.Drawing.Point(114, 127);
            this.lblVal01.Name = "lblVal01";
            this.lblVal01.Size = new System.Drawing.Size(125, 13);
            this.lblVal01.TabIndex = 9;
            // 
            // lblQuant01
            // 
            this.lblQuant01.Location = new System.Drawing.Point(174, 103);
            this.lblQuant01.Name = "lblQuant01";
            this.lblQuant01.Size = new System.Drawing.Size(65, 13);
            this.lblQuant01.TabIndex = 8;
            // 
            // lblDias01
            // 
            this.lblDias01.Location = new System.Drawing.Point(85, 83);
            this.lblDias01.Name = "lblDias01";
            this.lblDias01.Size = new System.Drawing.Size(154, 13);
            this.lblDias01.TabIndex = 7;
            // 
            // lblPlan01
            // 
            this.lblPlan01.Location = new System.Drawing.Point(85, 60);
            this.lblPlan01.Name = "lblPlan01";
            this.lblPlan01.Size = new System.Drawing.Size(154, 13);
            this.lblPlan01.TabIndex = 6;
            // 
            // lblTipPlan01
            // 
            this.lblTipPlan01.Location = new System.Drawing.Point(85, 33);
            this.lblTipPlan01.Name = "lblTipPlan01";
            this.lblTipPlan01.Size = new System.Drawing.Size(154, 19);
            this.lblTipPlan01.TabIndex = 5;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(9, 127);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(99, 15);
            this.lblValor.TabIndex = 4;
            this.lblValor.Text = "Valor em US$:";
            // 
            // lblQuant
            // 
            this.lblQuant.AutoSize = true;
            this.lblQuant.Location = new System.Drawing.Point(6, 103);
            this.lblQuant.Name = "lblQuant";
            this.lblQuant.Size = new System.Drawing.Size(162, 15);
            this.lblQuant.TabIndex = 3;
            this.lblQuant.Text = "Quantidade de pessoas:";
            // 
            // lblDias
            // 
            this.lblDias.AutoSize = true;
            this.lblDias.Location = new System.Drawing.Point(7, 83);
            this.lblDias.Name = "lblDias";
            this.lblDias.Size = new System.Drawing.Size(40, 15);
            this.lblDias.TabIndex = 2;
            this.lblDias.Text = "Dias:";
            // 
            // lblPlan
            // 
            this.lblPlan.AutoSize = true;
            this.lblPlan.Location = new System.Drawing.Point(7, 60);
            this.lblPlan.Name = "lblPlan";
            this.lblPlan.Size = new System.Drawing.Size(55, 15);
            this.lblPlan.TabIndex = 1;
            this.lblPlan.Text = "Planos:";
            // 
            // lblTipPlan
            // 
            this.lblTipPlan.AutoSize = true;
            this.lblTipPlan.Location = new System.Drawing.Point(7, 34);
            this.lblTipPlan.Name = "lblTipPlan";
            this.lblTipPlan.Size = new System.Drawing.Size(80, 15);
            this.lblTipPlan.TabIndex = 0;
            this.lblTipPlan.Text = "Tipo Plano:";
            // 
            // btnLimpar
            // 
            this.btnLimpar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnLimpar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLimpar.Location = new System.Drawing.Point(278, 241);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(283, 23);
            this.btnLimpar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnLimpar.TabIndex = 39;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnEmiCota01
            // 
            this.btnEmiCota01.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnEmiCota01.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnEmiCota01.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmiCota01.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEmiCota01.Location = new System.Drawing.Point(278, 212);
            this.btnEmiCota01.Name = "btnEmiCota01";
            this.btnEmiCota01.Size = new System.Drawing.Size(283, 23);
            this.btnEmiCota01.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnEmiCota01.TabIndex = 38;
            this.btnEmiCota01.Text = "Emitir Cotação";
            this.btnEmiCota01.Click += new System.EventHandler(this.btnEmiCota01_Click);
            // 
            // btnCotar
            // 
            this.btnCotar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCotar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCotar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCotar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCotar.Location = new System.Drawing.Point(27, 212);
            this.btnCotar.Name = "btnCotar";
            this.btnCotar.Size = new System.Drawing.Size(235, 23);
            this.btnCotar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCotar.TabIndex = 37;
            this.btnCotar.Text = "Cotar";
            this.btnCotar.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // frmCotacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(901, 311);
            this.Controls.Add(this.groupPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frmCotacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cotar";
            this.Load += new System.EventHandler(this.frmCotacao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtQuant)).EndInit();
            this.groupPanel1.ResumeLayout(false);
            this.groupPanel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbTipoPlan;
        private System.Windows.Forms.Label lblTipoPlan;
        private System.Windows.Forms.ComboBox cmbPlano;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbDias;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown txtQuant;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.ButtonX btnLimpar;
        private DevComponents.DotNetBar.ButtonX btnEmiCota01;
        private DevComponents.DotNetBar.ButtonX btnCotar;
        private DevComponents.DotNetBar.ButtonX btnEmiCota02;
        private DevComponents.DotNetBar.ButtonX btnLimpar02;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblValResp03;
        private System.Windows.Forms.Label lblValResp02;
        private System.Windows.Forms.Label lblValor03;
        private System.Windows.Forms.Label lblQuant03;
        private System.Windows.Forms.Label lblDias03;
        private System.Windows.Forms.Label lblPlan03;
        private System.Windows.Forms.Label lblTipPlan03;
        private System.Windows.Forms.Label lblValor02;
        private System.Windows.Forms.Label lblQuant02;
        private System.Windows.Forms.Label lblDias02;
        private System.Windows.Forms.Label lblPlan02;
        private System.Windows.Forms.Label lblTipPlan02;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblValRel01;
        private System.Windows.Forms.Label lblValRel;
        private System.Windows.Forms.Label lblVal01;
        private System.Windows.Forms.Label lblQuant01;
        private System.Windows.Forms.Label lblDias01;
        private System.Windows.Forms.Label lblPlan01;
        private System.Windows.Forms.Label lblTipPlan01;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblQuant;
        private System.Windows.Forms.Label lblDias;
        private System.Windows.Forms.Label lblPlan;
        private System.Windows.Forms.Label lblTipPlan;
    }
}