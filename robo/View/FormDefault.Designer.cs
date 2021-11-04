﻿
namespace robo.View
{
    partial class FormDefault
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDefault));
            this.panelCadastro = new System.Windows.Forms.Panel();
            this.circularProgressBar1 = new CircularProgressBar.CircularProgressBar();
            this.lblStatus = new MetroFramework.Controls.MetroLabel();
            this.wbHelp = new System.Windows.Forms.WebBrowser();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panelCabecalho = new System.Windows.Forms.Panel();
            this.btnHelp = new MetroFramework.Controls.MetroButton();
            this.lblExecucao = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel17 = new MetroFramework.Controls.MetroLabel();
            this.panelCPF = new System.Windows.Forms.Panel();
            this.txtCPF = new System.Windows.Forms.MaskedTextBox();
            this.labelCPF = new MetroFramework.Controls.MetroLabel();
            this.labelCPFCaracteres = new MetroFramework.Controls.MetroLabel();
            this.panelImportar = new System.Windows.Forms.Panel();
            this.btnImportar = new System.Windows.Forms.Button();
            this.lblAlunosImportados = new MetroFramework.Controls.MetroLabel();
            this.panelIES = new System.Windows.Forms.Panel();
            this.cbIES = new System.Windows.Forms.ComboBox();
            this.labelIES = new MetroFramework.Controls.MetroLabel();
            this.labelAvisoIES = new MetroFramework.Controls.MetroLabel();
            this.panelCampus = new System.Windows.Forms.Panel();
            this.labelCampus = new MetroFramework.Controls.MetroLabel();
            this.cbCampus = new System.Windows.Forms.ComboBox();
            this.panelSemestre = new System.Windows.Forms.Panel();
            this.cbSemestre = new System.Windows.Forms.ComboBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.panelDataInicioEFim = new System.Windows.Forms.Panel();
            this.dtpDataInicial = new System.Windows.Forms.DateTimePicker();
            this.labelDataFim = new MetroFramework.Controls.MetroLabel();
            this.dtpDataFinal = new System.Windows.Forms.DateTimePicker();
            this.labelDataInicio = new MetroFramework.Controls.MetroLabel();
            this.panelAnoEMes = new System.Windows.Forms.Panel();
            this.labelAno = new MetroFramework.Controls.MetroLabel();
            this.labelMes = new MetroFramework.Controls.MetroLabel();
            this.cbMes = new System.Windows.Forms.ComboBox();
            this.cbAno = new System.Windows.Forms.ComboBox();
            this.panelSituacao = new System.Windows.Forms.Panel();
            this.labelSituacao = new MetroFramework.Controls.MetroLabel();
            this.cbSituacao = new System.Windows.Forms.ComboBox();
            this.panelIESRepasse = new System.Windows.Forms.Panel();
            this.labelIESRepasse = new MetroFramework.Controls.MetroLabel();
            this.cbIESRepasse = new System.Windows.Forms.ComboBox();
            this.panelFiesSiga = new System.Windows.Forms.Panel();
            this.labelFiesSiga = new MetroFramework.Controls.MetroLabel();
            this.cbFiesSiga = new System.Windows.Forms.ComboBox();
            this.labelDay = new System.Windows.Forms.Label();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.tooltip = new MetroFramework.Components.MetroToolTip();
            this.panelCadastro.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panelCabecalho.SuspendLayout();
            this.panelCPF.SuspendLayout();
            this.panelImportar.SuspendLayout();
            this.panelIES.SuspendLayout();
            this.panelCampus.SuspendLayout();
            this.panelSemestre.SuspendLayout();
            this.panelDataInicioEFim.SuspendLayout();
            this.panelAnoEMes.SuspendLayout();
            this.panelSituacao.SuspendLayout();
            this.panelIESRepasse.SuspendLayout();
            this.panelFiesSiga.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCadastro
            // 
            this.panelCadastro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelCadastro.BackColor = System.Drawing.Color.White;
            this.panelCadastro.Controls.Add(this.circularProgressBar1);
            this.panelCadastro.Controls.Add(this.lblStatus);
            this.panelCadastro.Controls.Add(this.wbHelp);
            this.panelCadastro.Controls.Add(this.flowLayoutPanel1);
            this.panelCadastro.Controls.Add(this.labelDay);
            this.panelCadastro.Controls.Add(this.btnIniciar);
            this.panelCadastro.Location = new System.Drawing.Point(0, 0);
            this.panelCadastro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelCadastro.Name = "panelCadastro";
            this.panelCadastro.Size = new System.Drawing.Size(1429, 862);
            this.panelCadastro.TabIndex = 39;
            // 
            // circularProgressBar1
            // 
            this.circularProgressBar1.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circularProgressBar1.AnimationSpeed = 500;
            this.circularProgressBar1.BackColor = System.Drawing.Color.Transparent;
            this.circularProgressBar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circularProgressBar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.circularProgressBar1.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.circularProgressBar1.InnerMargin = 2;
            this.circularProgressBar1.InnerWidth = -1;
            this.circularProgressBar1.Location = new System.Drawing.Point(928, 4);
            this.circularProgressBar1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.circularProgressBar1.MarqueeAnimationSpeed = 2000;
            this.circularProgressBar1.Name = "circularProgressBar1";
            this.circularProgressBar1.OuterColor = System.Drawing.Color.Gray;
            this.circularProgressBar1.OuterMargin = -25;
            this.circularProgressBar1.OuterWidth = 26;
            this.circularProgressBar1.ProgressColor = System.Drawing.Color.Purple;
            this.circularProgressBar1.ProgressWidth = 25;
            this.circularProgressBar1.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circularProgressBar1.Size = new System.Drawing.Size(319, 300);
            this.circularProgressBar1.StartAngle = 270;
            this.circularProgressBar1.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar1.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circularProgressBar1.SubscriptText = "";
            this.circularProgressBar1.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar1.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circularProgressBar1.SuperscriptText = "";
            this.circularProgressBar1.TabIndex = 62;
            this.circularProgressBar1.Text = "Processando...";
            this.circularProgressBar1.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.circularProgressBar1.Value = 68;
            this.circularProgressBar1.Visible = false;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(793, 735);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(35, 20);
            this.lblStatus.TabIndex = 64;
            this.lblStatus.Text = "Erro";
            this.lblStatus.Visible = false;
            // 
            // wbHelp
            // 
            this.wbHelp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wbHelp.CausesValidation = false;
            this.wbHelp.Location = new System.Drawing.Point(732, 312);
            this.wbHelp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.wbHelp.MinimumSize = new System.Drawing.Size(27, 25);
            this.wbHelp.Name = "wbHelp";
            this.wbHelp.Size = new System.Drawing.Size(626, 419);
            this.wbHelp.TabIndex = 63;
            this.wbHelp.Visible = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.panelCabecalho);
            this.flowLayoutPanel1.Controls.Add(this.panelCPF);
            this.flowLayoutPanel1.Controls.Add(this.panelImportar);
            this.flowLayoutPanel1.Controls.Add(this.panelIES);
            this.flowLayoutPanel1.Controls.Add(this.panelCampus);
            this.flowLayoutPanel1.Controls.Add(this.panelSemestre);
            this.flowLayoutPanel1.Controls.Add(this.panelDataInicioEFim);
            this.flowLayoutPanel1.Controls.Add(this.panelAnoEMes);
            this.flowLayoutPanel1.Controls.Add(this.panelSituacao);
            this.flowLayoutPanel1.Controls.Add(this.panelIESRepasse);
            this.flowLayoutPanel1.Controls.Add(this.panelFiesSiga);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(44, 15);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(680, 623);
            this.flowLayoutPanel1.TabIndex = 37;
            // 
            // panelCabecalho
            // 
            this.panelCabecalho.Controls.Add(this.btnHelp);
            this.panelCabecalho.Controls.Add(this.lblExecucao);
            this.panelCabecalho.Controls.Add(this.metroLabel1);
            this.panelCabecalho.Controls.Add(this.metroLabel17);
            this.panelCabecalho.Location = new System.Drawing.Point(4, 4);
            this.panelCabecalho.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelCabecalho.Name = "panelCabecalho";
            this.panelCabecalho.Size = new System.Drawing.Size(651, 123);
            this.panelCabecalho.TabIndex = 71;
            this.panelCabecalho.Tag = "";
            this.panelCabecalho.Visible = false;
            // 
            // btnHelp
            // 
            this.btnHelp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHelp.BackgroundImage")));
            this.btnHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnHelp.Location = new System.Drawing.Point(159, 7);
            this.btnHelp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(35, 28);
            this.btnHelp.TabIndex = 35;
            this.btnHelp.UseSelectable = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // lblExecucao
            // 
            this.lblExecucao.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblExecucao.AutoSize = true;
            this.lblExecucao.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblExecucao.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblExecucao.Location = new System.Drawing.Point(4, 7);
            this.lblExecucao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExecucao.Name = "lblExecucao";
            this.lblExecucao.Size = new System.Drawing.Size(114, 25);
            this.lblExecucao.TabIndex = 33;
            this.lblExecucao.Text = "Robo Ritter";
            // 
            // metroLabel1
            // 
            this.metroLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(4, 38);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(223, 20);
            this.metroLabel1.TabIndex = 34;
            this.metroLabel1.Text = "Digite e Selecione os dados abaixo";
            // 
            // metroLabel17
            // 
            this.metroLabel17.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel17.AutoSize = true;
            this.metroLabel17.Location = new System.Drawing.Point(3, 38);
            this.metroLabel17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel17.Name = "metroLabel17";
            this.metroLabel17.Size = new System.Drawing.Size(223, 20);
            this.metroLabel17.TabIndex = 34;
            this.metroLabel17.Text = "Digite e Selecione os dados abaixo";
            // 
            // panelCPF
            // 
            this.panelCPF.Controls.Add(this.txtCPF);
            this.panelCPF.Controls.Add(this.labelCPF);
            this.panelCPF.Controls.Add(this.labelCPFCaracteres);
            this.panelCPF.Location = new System.Drawing.Point(4, 135);
            this.panelCPF.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelCPF.Name = "panelCPF";
            this.panelCPF.Size = new System.Drawing.Size(651, 90);
            this.panelCPF.TabIndex = 64;
            this.panelCPF.Visible = false;
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(17, 32);
            this.txtCPF.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(600, 22);
            this.txtCPF.TabIndex = 35;
            this.txtCPF.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtCPF_MouseClick);
            this.txtCPF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCPF_KeyPress);
            // 
            // labelCPF
            // 
            this.labelCPF.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCPF.AutoSize = true;
            this.labelCPF.Location = new System.Drawing.Point(17, 5);
            this.labelCPF.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCPF.Name = "labelCPF";
            this.labelCPF.Size = new System.Drawing.Size(33, 20);
            this.labelCPF.TabIndex = 28;
            this.labelCPF.Text = "CPF";
            // 
            // labelCPFCaracteres
            // 
            this.labelCPFCaracteres.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCPFCaracteres.AutoSize = true;
            this.labelCPFCaracteres.FontSize = MetroFramework.MetroLabelSize.Small;
            this.labelCPFCaracteres.Location = new System.Drawing.Point(427, 58);
            this.labelCPFCaracteres.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCPFCaracteres.Name = "labelCPFCaracteres";
            this.labelCPFCaracteres.Size = new System.Drawing.Size(128, 17);
            this.labelCPFCaracteres.TabIndex = 35;
            this.labelCPFCaracteres.Text = "(11 caracteres Exatos*)";
            // 
            // panelImportar
            // 
            this.panelImportar.Controls.Add(this.btnImportar);
            this.panelImportar.Controls.Add(this.lblAlunosImportados);
            this.panelImportar.Location = new System.Drawing.Point(4, 233);
            this.panelImportar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelImportar.Name = "panelImportar";
            this.panelImportar.Size = new System.Drawing.Size(651, 123);
            this.panelImportar.TabIndex = 72;
            this.panelImportar.Tag = "";
            this.panelImportar.Visible = false;
            // 
            // btnImportar
            // 
            this.btnImportar.BackColor = System.Drawing.Color.Green;
            this.btnImportar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnImportar.Image = global::robo.Properties.Resources.excel_1_;
            this.btnImportar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImportar.Location = new System.Drawing.Point(3, 55);
            this.btnImportar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnImportar.Name = "btnImportar";
            this.btnImportar.Size = new System.Drawing.Size(281, 43);
            this.btnImportar.TabIndex = 37;
            this.btnImportar.Text = "Atualizar";
            this.btnImportar.UseVisualStyleBackColor = false;
            this.btnImportar.Click += new System.EventHandler(this.btnImportar_Click);
            // 
            // lblAlunosImportados
            // 
            this.lblAlunosImportados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAlunosImportados.AutoSize = true;
            this.lblAlunosImportados.Location = new System.Drawing.Point(12, 31);
            this.lblAlunosImportados.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAlunosImportados.Name = "lblAlunosImportados";
            this.lblAlunosImportados.Size = new System.Drawing.Size(223, 20);
            this.lblAlunosImportados.TabIndex = 34;
            this.lblAlunosImportados.Text = "Digite e Selecione os dados abaixo";
            // 
            // panelIES
            // 
            this.panelIES.Controls.Add(this.cbIES);
            this.panelIES.Controls.Add(this.labelIES);
            this.panelIES.Controls.Add(this.labelAvisoIES);
            this.panelIES.Location = new System.Drawing.Point(4, 364);
            this.panelIES.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelIES.Name = "panelIES";
            this.panelIES.Size = new System.Drawing.Size(651, 116);
            this.panelIES.TabIndex = 62;
            this.panelIES.Tag = "";
            this.panelIES.Visible = false;
            // 
            // cbIES
            // 
            this.cbIES.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbIES.BackColor = System.Drawing.SystemColors.Control;
            this.cbIES.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbIES.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIES.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbIES.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbIES.FormattingEnabled = true;
            this.cbIES.Items.AddRange(new object[] {
            "TODOS",
            "FADERGS",
            "UNIRITTER",
            "IBMR",
            "UnP",
            "FPB"});
            this.cbIES.Location = new System.Drawing.Point(12, 48);
            this.cbIES.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbIES.Name = "cbIES";
            this.cbIES.Size = new System.Drawing.Size(600, 29);
            this.cbIES.TabIndex = 2;
            this.cbIES.Tag = "";
            this.cbIES.SelectedIndexChanged += new System.EventHandler(this.cbIES_SelectedIndexChanged);
            // 
            // labelIES
            // 
            this.labelIES.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelIES.AutoSize = true;
            this.labelIES.Location = new System.Drawing.Point(12, 25);
            this.labelIES.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelIES.Name = "labelIES";
            this.labelIES.Size = new System.Drawing.Size(27, 20);
            this.labelIES.TabIndex = 1;
            this.labelIES.Tag = "";
            this.labelIES.Text = "IES";
            // 
            // labelAvisoIES
            // 
            this.labelAvisoIES.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAvisoIES.AutoSize = true;
            this.labelAvisoIES.FontSize = MetroFramework.MetroLabelSize.Small;
            this.labelAvisoIES.Location = new System.Drawing.Point(281, 81);
            this.labelAvisoIES.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAvisoIES.Name = "labelAvisoIES";
            this.labelAvisoIES.Size = new System.Drawing.Size(263, 17);
            this.labelAvisoIES.TabIndex = 37;
            this.labelAvisoIES.Text = "(Troque de conta para poder acessar outra IES)";
            // 
            // panelCampus
            // 
            this.panelCampus.Controls.Add(this.labelCampus);
            this.panelCampus.Controls.Add(this.cbCampus);
            this.panelCampus.Location = new System.Drawing.Point(4, 488);
            this.panelCampus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelCampus.Name = "panelCampus";
            this.panelCampus.Size = new System.Drawing.Size(651, 94);
            this.panelCampus.TabIndex = 63;
            this.panelCampus.Visible = false;
            // 
            // labelCampus
            // 
            this.labelCampus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCampus.AutoSize = true;
            this.labelCampus.Location = new System.Drawing.Point(12, 7);
            this.labelCampus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCampus.Name = "labelCampus";
            this.labelCampus.Size = new System.Drawing.Size(59, 20);
            this.labelCampus.TabIndex = 3;
            this.labelCampus.Tag = "";
            this.labelCampus.Text = "Campus";
            // 
            // cbCampus
            // 
            this.cbCampus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbCampus.BackColor = System.Drawing.SystemColors.Control;
            this.cbCampus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbCampus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCampus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbCampus.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCampus.FormattingEnabled = true;
            this.cbCampus.Location = new System.Drawing.Point(12, 31);
            this.cbCampus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbCampus.Name = "cbCampus";
            this.cbCampus.Size = new System.Drawing.Size(600, 29);
            this.cbCampus.TabIndex = 4;
            this.cbCampus.Tag = "";
            // 
            // panelSemestre
            // 
            this.panelSemestre.Controls.Add(this.cbSemestre);
            this.panelSemestre.Controls.Add(this.metroLabel4);
            this.panelSemestre.Location = new System.Drawing.Point(4, 590);
            this.panelSemestre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelSemestre.Name = "panelSemestre";
            this.panelSemestre.Size = new System.Drawing.Size(651, 65);
            this.panelSemestre.TabIndex = 65;
            this.panelSemestre.Tag = "";
            this.panelSemestre.Visible = false;
            // 
            // cbSemestre
            // 
            this.cbSemestre.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbSemestre.BackColor = System.Drawing.SystemColors.Control;
            this.cbSemestre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbSemestre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSemestre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbSemestre.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSemestre.FormattingEnabled = true;
            this.cbSemestre.Items.AddRange(new object[] {
            "FIES Legado",
            "FIES Novo"});
            this.cbSemestre.Location = new System.Drawing.Point(12, 26);
            this.cbSemestre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbSemestre.Name = "cbSemestre";
            this.cbSemestre.Size = new System.Drawing.Size(600, 29);
            this.cbSemestre.TabIndex = 9;
            // 
            // metroLabel4
            // 
            this.metroLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(12, 2);
            this.metroLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(67, 20);
            this.metroLabel4.TabIndex = 24;
            this.metroLabel4.Text = "Semestre";
            // 
            // panelDataInicioEFim
            // 
            this.panelDataInicioEFim.Controls.Add(this.dtpDataInicial);
            this.panelDataInicioEFim.Controls.Add(this.labelDataFim);
            this.panelDataInicioEFim.Controls.Add(this.dtpDataFinal);
            this.panelDataInicioEFim.Controls.Add(this.labelDataInicio);
            this.panelDataInicioEFim.Location = new System.Drawing.Point(4, 663);
            this.panelDataInicioEFim.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelDataInicioEFim.Name = "panelDataInicioEFim";
            this.panelDataInicioEFim.Size = new System.Drawing.Size(651, 80);
            this.panelDataInicioEFim.TabIndex = 66;
            this.panelDataInicioEFim.Tag = "";
            this.panelDataInicioEFim.Visible = false;
            // 
            // dtpDataInicial
            // 
            this.dtpDataInicial.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataInicial.Location = new System.Drawing.Point(23, 34);
            this.dtpDataInicial.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpDataInicial.Name = "dtpDataInicial";
            this.dtpDataInicial.Size = new System.Drawing.Size(181, 26);
            this.dtpDataInicial.TabIndex = 45;
            // 
            // labelDataFim
            // 
            this.labelDataFim.AutoSize = true;
            this.labelDataFim.Location = new System.Drawing.Point(216, 7);
            this.labelDataFim.Name = "labelDataFim";
            this.labelDataFim.Size = new System.Drawing.Size(63, 20);
            this.labelDataFim.TabIndex = 52;
            this.labelDataFim.Text = "Data Fim";
            // 
            // dtpDataFinal
            // 
            this.dtpDataFinal.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataFinal.Location = new System.Drawing.Point(213, 34);
            this.dtpDataFinal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpDataFinal.Name = "dtpDataFinal";
            this.dtpDataFinal.Size = new System.Drawing.Size(169, 26);
            this.dtpDataFinal.TabIndex = 46;
            // 
            // labelDataInicio
            // 
            this.labelDataInicio.AutoSize = true;
            this.labelDataInicio.Location = new System.Drawing.Point(23, 7);
            this.labelDataInicio.Name = "labelDataInicio";
            this.labelDataInicio.Size = new System.Drawing.Size(73, 20);
            this.labelDataInicio.TabIndex = 51;
            this.labelDataInicio.Text = "Data Inicio";
            // 
            // panelAnoEMes
            // 
            this.panelAnoEMes.Controls.Add(this.labelAno);
            this.panelAnoEMes.Controls.Add(this.labelMes);
            this.panelAnoEMes.Controls.Add(this.cbMes);
            this.panelAnoEMes.Controls.Add(this.cbAno);
            this.panelAnoEMes.Location = new System.Drawing.Point(4, 751);
            this.panelAnoEMes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelAnoEMes.Name = "panelAnoEMes";
            this.panelAnoEMes.Size = new System.Drawing.Size(651, 78);
            this.panelAnoEMes.TabIndex = 67;
            this.panelAnoEMes.Visible = false;
            // 
            // labelAno
            // 
            this.labelAno.AutoSize = true;
            this.labelAno.Location = new System.Drawing.Point(20, 14);
            this.labelAno.Name = "labelAno";
            this.labelAno.Size = new System.Drawing.Size(34, 20);
            this.labelAno.TabIndex = 54;
            this.labelAno.Text = "Ano";
            // 
            // labelMes
            // 
            this.labelMes.AutoSize = true;
            this.labelMes.Location = new System.Drawing.Point(213, 14);
            this.labelMes.Name = "labelMes";
            this.labelMes.Size = new System.Drawing.Size(35, 20);
            this.labelMes.TabIndex = 53;
            this.labelMes.Text = "Mês";
            // 
            // cbMes
            // 
            this.cbMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMes.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMes.FormattingEnabled = true;
            this.cbMes.Items.AddRange(new object[] {
            "Janeiro",
            "Fevereiro",
            "Março",
            "Abril",
            "Maio",
            "Junho",
            "Julho",
            "Agosto",
            "Setembro",
            "Outubro",
            "Novembro",
            "Dezembro"});
            this.cbMes.Location = new System.Drawing.Point(211, 41);
            this.cbMes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbMes.Name = "cbMes";
            this.cbMes.Size = new System.Drawing.Size(169, 28);
            this.cbMes.TabIndex = 44;
            // 
            // cbAno
            // 
            this.cbAno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAno.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAno.FormattingEnabled = true;
            this.cbAno.Items.AddRange(new object[] {
            "",
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021"});
            this.cbAno.Location = new System.Drawing.Point(20, 41);
            this.cbAno.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbAno.Name = "cbAno";
            this.cbAno.Size = new System.Drawing.Size(181, 28);
            this.cbAno.TabIndex = 43;
            // 
            // panelSituacao
            // 
            this.panelSituacao.Controls.Add(this.labelSituacao);
            this.panelSituacao.Controls.Add(this.cbSituacao);
            this.panelSituacao.Location = new System.Drawing.Point(4, 837);
            this.panelSituacao.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelSituacao.Name = "panelSituacao";
            this.panelSituacao.Size = new System.Drawing.Size(651, 87);
            this.panelSituacao.TabIndex = 68;
            this.panelSituacao.Visible = false;
            // 
            // labelSituacao
            // 
            this.labelSituacao.AutoSize = true;
            this.labelSituacao.Location = new System.Drawing.Point(19, 18);
            this.labelSituacao.Name = "labelSituacao";
            this.labelSituacao.Size = new System.Drawing.Size(60, 20);
            this.labelSituacao.TabIndex = 55;
            this.labelSituacao.Text = "Situação";
            // 
            // cbSituacao
            // 
            this.cbSituacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSituacao.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSituacao.FormattingEnabled = true;
            this.cbSituacao.Items.AddRange(new object[] {
            "",
            "Contratado",
            "Contrato Cancelado",
            "Contrato encerrado",
            "Contrato pendente de correcao",
            "Contrato pendente de validacao",
            "Em preenchimento pelo aluno",
            "Enviado ao banco",
            "Pendente de validacao pela CPSA",
            "Reaberto pela CPSA para correcao",
            "Recebido pelo banco",
            "Rejeitado pela CPSA",
            "Validado pela CPSA",
            "Vencido",
            "Prorrogado"});
            this.cbSituacao.Location = new System.Drawing.Point(20, 43);
            this.cbSituacao.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbSituacao.Name = "cbSituacao";
            this.cbSituacao.Size = new System.Drawing.Size(600, 28);
            this.cbSituacao.TabIndex = 42;
            // 
            // panelIESRepasse
            // 
            this.panelIESRepasse.Controls.Add(this.labelIESRepasse);
            this.panelIESRepasse.Controls.Add(this.cbIESRepasse);
            this.panelIESRepasse.Location = new System.Drawing.Point(4, 932);
            this.panelIESRepasse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelIESRepasse.Name = "panelIESRepasse";
            this.panelIESRepasse.Size = new System.Drawing.Size(651, 84);
            this.panelIESRepasse.TabIndex = 69;
            this.panelIESRepasse.Tag = "";
            this.panelIESRepasse.Visible = false;
            // 
            // labelIESRepasse
            // 
            this.labelIESRepasse.AutoSize = true;
            this.labelIESRepasse.Location = new System.Drawing.Point(19, 14);
            this.labelIESRepasse.Name = "labelIESRepasse";
            this.labelIESRepasse.Size = new System.Drawing.Size(82, 20);
            this.labelIESRepasse.TabIndex = 58;
            this.labelIESRepasse.Text = "IES Repasse";
            // 
            // cbIESRepasse
            // 
            this.cbIESRepasse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIESRepasse.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbIESRepasse.FormattingEnabled = true;
            this.cbIESRepasse.Items.AddRange(new object[] {
            "488 - CENTRO UNIVERSITÁRIO RITTER DOS REIS",
            "5317 - FACULDADE PORTO ALEGRENSE",
            "2950 - Centro Universitário FADERGS"});
            this.cbIESRepasse.Location = new System.Drawing.Point(20, 38);
            this.cbIESRepasse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbIESRepasse.Name = "cbIESRepasse";
            this.cbIESRepasse.Size = new System.Drawing.Size(600, 28);
            this.cbIESRepasse.TabIndex = 57;
            // 
            // panelFiesSiga
            // 
            this.panelFiesSiga.Controls.Add(this.labelFiesSiga);
            this.panelFiesSiga.Controls.Add(this.cbFiesSiga);
            this.panelFiesSiga.Location = new System.Drawing.Point(4, 1024);
            this.panelFiesSiga.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelFiesSiga.Name = "panelFiesSiga";
            this.panelFiesSiga.Size = new System.Drawing.Size(651, 75);
            this.panelFiesSiga.TabIndex = 70;
            this.panelFiesSiga.Tag = "";
            this.panelFiesSiga.Visible = false;
            // 
            // labelFiesSiga
            // 
            this.labelFiesSiga.AutoSize = true;
            this.labelFiesSiga.Location = new System.Drawing.Point(17, 15);
            this.labelFiesSiga.Name = "labelFiesSiga";
            this.labelFiesSiga.Size = new System.Drawing.Size(67, 20);
            this.labelFiesSiga.TabIndex = 60;
            this.labelFiesSiga.Text = "FIES SIGA";
            // 
            // cbFiesSiga
            // 
            this.cbFiesSiga.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFiesSiga.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFiesSiga.FormattingEnabled = true;
            this.cbFiesSiga.Items.AddRange(new object[] {
            "FIES",
            "FIES CONTRATADO"});
            this.cbFiesSiga.Location = new System.Drawing.Point(20, 39);
            this.cbFiesSiga.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbFiesSiga.Name = "cbFiesSiga";
            this.cbFiesSiga.Size = new System.Drawing.Size(600, 28);
            this.cbFiesSiga.TabIndex = 59;
            // 
            // labelDay
            // 
            this.labelDay.AutoSize = true;
            this.labelDay.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDay.ForeColor = System.Drawing.Color.White;
            this.labelDay.Location = new System.Drawing.Point(59, 455);
            this.labelDay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDay.Name = "labelDay";
            this.labelDay.Size = new System.Drawing.Size(466, 30);
            this.labelDay.TabIndex = 31;
            this.labelDay.Text = "Quarta-feira, 11 de novembro de 2022";
            // 
            // btnIniciar
            // 
            this.btnIniciar.BackColor = System.Drawing.Color.White;
            this.btnIniciar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIniciar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnIniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btnIniciar.Location = new System.Drawing.Point(117, 704);
            this.btnIniciar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(288, 36);
            this.btnIniciar.TabIndex = 61;
            this.btnIniciar.Tag = "ADITAMENTO BAIXAR DRM";
            this.btnIniciar.Text = "Executar";
            this.btnIniciar.UseVisualStyleBackColor = false;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.WorkerReportsProgress = true;
            this.backgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker_ProgressChanged);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_RunWorkerCompleted);
            // 
            // tooltip
            // 
            this.tooltip.Style = MetroFramework.MetroColorStyle.Blue;
            this.tooltip.StyleManager = null;
            this.tooltip.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // FormDefault
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1371, 750);
            this.Controls.Add(this.panelCadastro);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormDefault";
            this.Text = "FormDefault";
            this.panelCadastro.ResumeLayout(false);
            this.panelCadastro.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panelCabecalho.ResumeLayout(false);
            this.panelCabecalho.PerformLayout();
            this.panelCPF.ResumeLayout(false);
            this.panelCPF.PerformLayout();
            this.panelImportar.ResumeLayout(false);
            this.panelImportar.PerformLayout();
            this.panelIES.ResumeLayout(false);
            this.panelIES.PerformLayout();
            this.panelCampus.ResumeLayout(false);
            this.panelCampus.PerformLayout();
            this.panelSemestre.ResumeLayout(false);
            this.panelSemestre.PerformLayout();
            this.panelDataInicioEFim.ResumeLayout(false);
            this.panelDataInicioEFim.PerformLayout();
            this.panelAnoEMes.ResumeLayout(false);
            this.panelAnoEMes.PerformLayout();
            this.panelSituacao.ResumeLayout(false);
            this.panelSituacao.PerformLayout();
            this.panelIESRepasse.ResumeLayout(false);
            this.panelIESRepasse.PerformLayout();
            this.panelFiesSiga.ResumeLayout(false);
            this.panelFiesSiga.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCadastro;
        private MetroFramework.Controls.MetroLabel labelFiesSiga;
        private System.Windows.Forms.ComboBox cbFiesSiga;
        private MetroFramework.Controls.MetroLabel labelDataInicio;
        private System.Windows.Forms.ComboBox cbSituacao;
        private System.Windows.Forms.ComboBox cbAno;
        private MetroFramework.Controls.MetroLabel labelIESRepasse;
        private System.Windows.Forms.ComboBox cbMes;
        private System.Windows.Forms.ComboBox cbIESRepasse;
        private System.Windows.Forms.DateTimePicker dtpDataInicial;
        private System.Windows.Forms.DateTimePicker dtpDataFinal;
        private MetroFramework.Controls.MetroLabel labelSituacao;
        private MetroFramework.Controls.MetroLabel labelDataFim;
        private MetroFramework.Controls.MetroLabel labelAno;
        private MetroFramework.Controls.MetroLabel labelMes;
        private MetroFramework.Controls.MetroLabel labelAvisoIES;
        private MetroFramework.Controls.MetroLabel labelCPFCaracteres;
        private MetroFramework.Controls.MetroLabel metroLabel17;
        private MetroFramework.Controls.MetroLabel lblExecucao;
        private System.Windows.Forms.Label labelDay;
        private MetroFramework.Controls.MetroLabel labelCPF;
        private MetroFramework.Controls.MetroLabel labelCampus;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel labelIES;
        private System.Windows.Forms.ComboBox cbSemestre;
        private System.Windows.Forms.ComboBox cbCampus;
        private System.Windows.Forms.ComboBox cbIES;
        private System.Windows.Forms.Panel panelIES;
        private System.Windows.Forms.Panel panelCampus;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panelCabecalho;
        private System.Windows.Forms.Panel panelCPF;
        private System.Windows.Forms.Panel panelSemestre;
        private System.Windows.Forms.Panel panelDataInicioEFim;
        private System.Windows.Forms.Panel panelAnoEMes;
        private System.Windows.Forms.Panel panelSituacao;
        private System.Windows.Forms.Panel panelIESRepasse;
        private System.Windows.Forms.Panel panelFiesSiga;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Panel panelImportar;
        private System.Windows.Forms.Button btnImportar;
        private MetroFramework.Controls.MetroLabel lblAlunosImportados;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.MaskedTextBox txtCPF;
        public CircularProgressBar.CircularProgressBar circularProgressBar1;
        public System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.WebBrowser wbHelp;
        private MetroFramework.Controls.MetroButton btnHelp;
        private MetroFramework.Components.MetroToolTip tooltip;
        private MetroFramework.Controls.MetroLabel lblStatus;
    }
}