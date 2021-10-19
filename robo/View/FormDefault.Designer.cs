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
            this.panelCadastro = new System.Windows.Forms.Panel();
            this.gbIES = new System.Windows.Forms.Panel();
            this.cbIES = new System.Windows.Forms.ComboBox();
            this.labelIES = new MetroFramework.Controls.MetroLabel();
            this.labelAvisoIES = new MetroFramework.Controls.MetroLabel();
            this.labelFiesSiga = new MetroFramework.Controls.MetroLabel();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.cbFiesSiga = new System.Windows.Forms.ComboBox();
            this.labelDataInicio = new MetroFramework.Controls.MetroLabel();
            this.cbSituacao = new System.Windows.Forms.ComboBox();
            this.cbAno = new System.Windows.Forms.ComboBox();
            this.metroLabel19 = new MetroFramework.Controls.MetroLabel();
            this.labelIESRepasse = new MetroFramework.Controls.MetroLabel();
            this.labelCPFCaracteres = new MetroFramework.Controls.MetroLabel();
            this.cbMes = new System.Windows.Forms.ComboBox();
            this.metroLabel17 = new MetroFramework.Controls.MetroLabel();
            this.cbIESRepasse = new System.Windows.Forms.ComboBox();
            this.metroLabel16 = new MetroFramework.Controls.MetroLabel();
            this.dtpDataInicial = new System.Windows.Forms.DateTimePicker();
            this.labelDay = new System.Windows.Forms.Label();
            this.dtpDataFinal = new System.Windows.Forms.DateTimePicker();
            this.labelCPF = new MetroFramework.Controls.MetroLabel();
            this.labelSituacao = new MetroFramework.Controls.MetroLabel();
            this.labelCampus = new MetroFramework.Controls.MetroLabel();
            this.labelDataFim = new MetroFramework.Controls.MetroLabel();
            this.labelAno = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.labelMes = new MetroFramework.Controls.MetroLabel();
            this.cbSemestre = new System.Windows.Forms.ComboBox();
            this.cbCampus = new System.Windows.Forms.ComboBox();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.panelCampus = new System.Windows.Forms.Panel();
            this.panelCPF = new System.Windows.Forms.Panel();
            this.panelSemestre = new System.Windows.Forms.Panel();
            this.panelDataInicioEFim = new System.Windows.Forms.Panel();
            this.panelAnoEMes = new System.Windows.Forms.Panel();
            this.panelSituacao = new System.Windows.Forms.Panel();
            this.panelIESRepasse = new System.Windows.Forms.Panel();
            this.panelFiesSiga = new System.Windows.Forms.Panel();
            this.panelCabecalho = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panelCadastro.SuspendLayout();
            this.gbIES.SuspendLayout();
            this.panelCampus.SuspendLayout();
            this.panelCPF.SuspendLayout();
            this.panelSemestre.SuspendLayout();
            this.panelDataInicioEFim.SuspendLayout();
            this.panelAnoEMes.SuspendLayout();
            this.panelSituacao.SuspendLayout();
            this.panelIESRepasse.SuspendLayout();
            this.panelFiesSiga.SuspendLayout();
            this.panelCabecalho.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCadastro
            // 
            this.panelCadastro.BackColor = System.Drawing.Color.White;
            this.panelCadastro.Controls.Add(this.flowLayoutPanel1);
            this.panelCadastro.Controls.Add(this.labelDay);
            this.panelCadastro.Location = new System.Drawing.Point(0, 0);
            this.panelCadastro.Name = "panelCadastro";
            this.panelCadastro.Size = new System.Drawing.Size(1072, 700);
            this.panelCadastro.TabIndex = 39;
            // 
            // gbIES
            // 
            this.gbIES.Controls.Add(this.cbIES);
            this.gbIES.Controls.Add(this.labelIES);
            this.gbIES.Controls.Add(this.labelAvisoIES);
            this.gbIES.Location = new System.Drawing.Point(3, 109);
            this.gbIES.Name = "gbIES";
            this.gbIES.Size = new System.Drawing.Size(617, 94);
            this.gbIES.TabIndex = 62;
            this.gbIES.TabStop = false;
            this.gbIES.Tag = "ADITAMENTO";
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
            this.cbIES.Location = new System.Drawing.Point(13, 38);
            this.cbIES.Name = "cbIES";
            this.cbIES.Size = new System.Drawing.Size(598, 25);
            this.cbIES.TabIndex = 2;
            this.cbIES.Tag = "ADITAMENTO DRD";
            // 
            // labelIES
            // 
            this.labelIES.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelIES.AutoSize = true;
            this.labelIES.Location = new System.Drawing.Point(13, 16);
            this.labelIES.Name = "labelIES";
            this.labelIES.Size = new System.Drawing.Size(26, 19);
            this.labelIES.TabIndex = 1;
            this.labelIES.Tag = "FIES NOVOADITAMENTO DRM DRD";
            this.labelIES.Text = "IES";
            // 
            // labelAvisoIES
            // 
            this.labelAvisoIES.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAvisoIES.AutoSize = true;
            this.labelAvisoIES.FontSize = MetroFramework.MetroLabelSize.Small;
            this.labelAvisoIES.Location = new System.Drawing.Point(369, 66);
            this.labelAvisoIES.Name = "labelAvisoIES";
            this.labelAvisoIES.Size = new System.Drawing.Size(242, 15);
            this.labelAvisoIES.TabIndex = 37;
            this.labelAvisoIES.Text = "(Troque de conta para poder acessar outra IES)";
            // 
            // labelFiesSiga
            // 
            this.labelFiesSiga.AutoSize = true;
            this.labelFiesSiga.Location = new System.Drawing.Point(2, 10);
            this.labelFiesSiga.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFiesSiga.Name = "labelFiesSiga";
            this.labelFiesSiga.Size = new System.Drawing.Size(65, 19);
            this.labelFiesSiga.TabIndex = 60;
            this.labelFiesSiga.Text = "FIES SIGA";
            // 
            // btnIniciar
            // 
            this.btnIniciar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnIniciar.BackColor = System.Drawing.Color.White;
            this.btnIniciar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIniciar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnIniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btnIniciar.Location = new System.Drawing.Point(3, 801);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(615, 29);
            this.btnIniciar.TabIndex = 61;
            this.btnIniciar.Text = "Executar";
            this.btnIniciar.UseVisualStyleBackColor = false;
            // 
            // cbFiesSiga
            // 
            this.cbFiesSiga.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFiesSiga.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFiesSiga.FormattingEnabled = true;
            this.cbFiesSiga.Items.AddRange(new object[] {
            "FIES",
            "FIES CONTRATADO"});
            this.cbFiesSiga.Location = new System.Drawing.Point(2, 32);
            this.cbFiesSiga.Name = "cbFiesSiga";
            this.cbFiesSiga.Size = new System.Drawing.Size(271, 25);
            this.cbFiesSiga.TabIndex = 59;
            // 
            // labelDataInicio
            // 
            this.labelDataInicio.AutoSize = true;
            this.labelDataInicio.Location = new System.Drawing.Point(17, 6);
            this.labelDataInicio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDataInicio.Name = "labelDataInicio";
            this.labelDataInicio.Size = new System.Drawing.Size(70, 19);
            this.labelDataInicio.TabIndex = 51;
            this.labelDataInicio.Text = "Data Inicio";
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
            this.cbSituacao.Location = new System.Drawing.Point(7, 35);
            this.cbSituacao.Name = "cbSituacao";
            this.cbSituacao.Size = new System.Drawing.Size(271, 25);
            this.cbSituacao.TabIndex = 42;
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
            this.cbAno.Location = new System.Drawing.Point(15, 33);
            this.cbAno.Name = "cbAno";
            this.cbAno.Size = new System.Drawing.Size(137, 25);
            this.cbAno.TabIndex = 43;
            // 
            // metroLabel19
            // 
            this.metroLabel19.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel19.AutoSize = true;
            this.metroLabel19.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel19.Location = new System.Drawing.Point(2, 66);
            this.metroLabel19.Name = "metroLabel19";
            this.metroLabel19.Size = new System.Drawing.Size(126, 19);
            this.metroLabel19.TabIndex = 36;
            this.metroLabel19.Text = "Dados de Execução";
            // 
            // labelIESRepasse
            // 
            this.labelIESRepasse.AutoSize = true;
            this.labelIESRepasse.Location = new System.Drawing.Point(7, 9);
            this.labelIESRepasse.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelIESRepasse.Name = "labelIESRepasse";
            this.labelIESRepasse.Size = new System.Drawing.Size(77, 19);
            this.labelIESRepasse.TabIndex = 58;
            this.labelIESRepasse.Text = "IES Repasse";
            // 
            // labelCPFCaracteres
            // 
            this.labelCPFCaracteres.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCPFCaracteres.AutoSize = true;
            this.labelCPFCaracteres.FontSize = MetroFramework.MetroLabelSize.Small;
            this.labelCPFCaracteres.Location = new System.Drawing.Point(488, 55);
            this.labelCPFCaracteres.Name = "labelCPFCaracteres";
            this.labelCPFCaracteres.Size = new System.Drawing.Size(116, 15);
            this.labelCPFCaracteres.TabIndex = 35;
            this.labelCPFCaracteres.Text = "(11 caracteres Exatos*)";
            // 
            // cbMes
            // 
            this.cbMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMes.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMes.FormattingEnabled = true;
            this.cbMes.Items.AddRange(new object[] {
            "",
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
            this.cbMes.Location = new System.Drawing.Point(158, 33);
            this.cbMes.Name = "cbMes";
            this.cbMes.Size = new System.Drawing.Size(128, 25);
            this.cbMes.TabIndex = 44;
            // 
            // metroLabel17
            // 
            this.metroLabel17.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel17.AutoSize = true;
            this.metroLabel17.Location = new System.Drawing.Point(3, 34);
            this.metroLabel17.Name = "metroLabel17";
            this.metroLabel17.Size = new System.Drawing.Size(213, 19);
            this.metroLabel17.TabIndex = 34;
            this.metroLabel17.Text = "Digite e Selecione os dados abaixo";
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
            this.cbIESRepasse.Location = new System.Drawing.Point(7, 31);
            this.cbIESRepasse.Name = "cbIESRepasse";
            this.cbIESRepasse.Size = new System.Drawing.Size(271, 25);
            this.cbIESRepasse.TabIndex = 57;
            // 
            // metroLabel16
            // 
            this.metroLabel16.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel16.AutoSize = true;
            this.metroLabel16.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel16.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel16.Location = new System.Drawing.Point(3, 6);
            this.metroLabel16.Name = "metroLabel16";
            this.metroLabel16.Size = new System.Drawing.Size(110, 25);
            this.metroLabel16.TabIndex = 33;
            this.metroLabel16.Text = "Robo Ritter";
            // 
            // dtpDataInicial
            // 
            this.dtpDataInicial.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataInicial.Location = new System.Drawing.Point(17, 28);
            this.dtpDataInicial.Name = "dtpDataInicial";
            this.dtpDataInicial.Size = new System.Drawing.Size(137, 22);
            this.dtpDataInicial.TabIndex = 45;
            // 
            // labelDay
            // 
            this.labelDay.AutoSize = true;
            this.labelDay.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDay.ForeColor = System.Drawing.Color.White;
            this.labelDay.Location = new System.Drawing.Point(44, 370);
            this.labelDay.Name = "labelDay";
            this.labelDay.Size = new System.Drawing.Size(367, 22);
            this.labelDay.TabIndex = 31;
            this.labelDay.Text = "Quarta-feira, 11 de novembro de 2022";
            // 
            // dtpDataFinal
            // 
            this.dtpDataFinal.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataFinal.Location = new System.Drawing.Point(160, 28);
            this.dtpDataFinal.Name = "dtpDataFinal";
            this.dtpDataFinal.Size = new System.Drawing.Size(128, 22);
            this.dtpDataFinal.TabIndex = 46;
            // 
            // labelCPF
            // 
            this.labelCPF.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCPF.AutoSize = true;
            this.labelCPF.Location = new System.Drawing.Point(13, 4);
            this.labelCPF.Name = "labelCPF";
            this.labelCPF.Size = new System.Drawing.Size(33, 19);
            this.labelCPF.TabIndex = 28;
            this.labelCPF.Text = "CPF";
            // 
            // labelSituacao
            // 
            this.labelSituacao.AutoSize = true;
            this.labelSituacao.Location = new System.Drawing.Point(7, 13);
            this.labelSituacao.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSituacao.Name = "labelSituacao";
            this.labelSituacao.Size = new System.Drawing.Size(58, 19);
            this.labelSituacao.TabIndex = 55;
            this.labelSituacao.Text = "Situação";
            // 
            // labelCampus
            // 
            this.labelCampus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCampus.AutoSize = true;
            this.labelCampus.Location = new System.Drawing.Point(3, 6);
            this.labelCampus.Name = "labelCampus";
            this.labelCampus.Size = new System.Drawing.Size(63, 19);
            this.labelCampus.TabIndex = 3;
            this.labelCampus.Tag = "";
            this.labelCampus.Text = "CAMPUS";
            // 
            // labelDataFim
            // 
            this.labelDataFim.AutoSize = true;
            this.labelDataFim.Location = new System.Drawing.Point(162, 6);
            this.labelDataFim.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDataFim.Name = "labelDataFim";
            this.labelDataFim.Size = new System.Drawing.Size(62, 19);
            this.labelDataFim.TabIndex = 52;
            this.labelDataFim.Text = "Data Fim";
            // 
            // labelAno
            // 
            this.labelAno.AutoSize = true;
            this.labelAno.Location = new System.Drawing.Point(15, 11);
            this.labelAno.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAno.Name = "labelAno";
            this.labelAno.Size = new System.Drawing.Size(33, 19);
            this.labelAno.TabIndex = 54;
            this.labelAno.Text = "Ano";
            // 
            // metroLabel4
            // 
            this.metroLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(9, 2);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(63, 19);
            this.metroLabel4.TabIndex = 24;
            this.metroLabel4.Text = "Semestre";
            // 
            // labelMes
            // 
            this.labelMes.AutoSize = true;
            this.labelMes.Location = new System.Drawing.Point(160, 11);
            this.labelMes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMes.Name = "labelMes";
            this.labelMes.Size = new System.Drawing.Size(33, 19);
            this.labelMes.TabIndex = 53;
            this.labelMes.Text = "Mês";
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
            this.cbSemestre.Location = new System.Drawing.Point(9, 29);
            this.cbSemestre.Name = "cbSemestre";
            this.cbSemestre.Size = new System.Drawing.Size(594, 25);
            this.cbSemestre.TabIndex = 9;
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
            this.cbCampus.Items.AddRange(new object[] {
            "",
            "Zona Sul",
            "Fapa",
            "Fapa-Fapa",
            "Canoas",
            "Iguatemi",
            "Sertorio",
            "Luis Afonso",
            "General Vitorino",
            "Riachuelo",
            "Galeria Lusa",
            "Uruguai",
            "Barra",
            "Botafogo",
            "Catete",
            "Manoel Elias"});
            this.cbCampus.Location = new System.Drawing.Point(3, 28);
            this.cbCampus.Name = "cbCampus";
            this.cbCampus.Size = new System.Drawing.Size(612, 25);
            this.cbCampus.TabIndex = 4;
            this.cbCampus.Tag = "";
            // 
            // txtCPF
            // 
            this.txtCPF.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCPF.Location = new System.Drawing.Point(13, 31);
            this.txtCPF.Margin = new System.Windows.Forms.Padding(2);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(595, 22);
            this.txtCPF.TabIndex = 11;
            // 
            // panelCampus
            // 
            this.panelCampus.Controls.Add(this.labelCampus);
            this.panelCampus.Controls.Add(this.cbCampus);
            this.panelCampus.Location = new System.Drawing.Point(3, 209);
            this.panelCampus.Name = "panelCampus";
            this.panelCampus.Size = new System.Drawing.Size(617, 76);
            this.panelCampus.TabIndex = 63;
            // 
            // panelCPF
            // 
            this.panelCPF.Controls.Add(this.txtCPF);
            this.panelCPF.Controls.Add(this.labelCPF);
            this.panelCPF.Controls.Add(this.labelCPFCaracteres);
            this.panelCPF.Location = new System.Drawing.Point(3, 291);
            this.panelCPF.Name = "panelCPF";
            this.panelCPF.Size = new System.Drawing.Size(617, 73);
            this.panelCPF.TabIndex = 64;
            // 
            // panelSemestre
            // 
            this.panelSemestre.Controls.Add(this.cbSemestre);
            this.panelSemestre.Controls.Add(this.metroLabel4);
            this.panelSemestre.Location = new System.Drawing.Point(3, 370);
            this.panelSemestre.Name = "panelSemestre";
            this.panelSemestre.Size = new System.Drawing.Size(617, 67);
            this.panelSemestre.TabIndex = 65;
            // 
            // panelDataInicioEFim
            // 
            this.panelDataInicioEFim.Controls.Add(this.dtpDataInicial);
            this.panelDataInicioEFim.Controls.Add(this.labelDataFim);
            this.panelDataInicioEFim.Controls.Add(this.dtpDataFinal);
            this.panelDataInicioEFim.Controls.Add(this.labelDataInicio);
            this.panelDataInicioEFim.Location = new System.Drawing.Point(3, 443);
            this.panelDataInicioEFim.Name = "panelDataInicioEFim";
            this.panelDataInicioEFim.Size = new System.Drawing.Size(617, 65);
            this.panelDataInicioEFim.TabIndex = 66;
            // 
            // panelAnoEMes
            // 
            this.panelAnoEMes.Controls.Add(this.labelAno);
            this.panelAnoEMes.Controls.Add(this.labelMes);
            this.panelAnoEMes.Controls.Add(this.cbMes);
            this.panelAnoEMes.Controls.Add(this.cbAno);
            this.panelAnoEMes.Location = new System.Drawing.Point(3, 514);
            this.panelAnoEMes.Name = "panelAnoEMes";
            this.panelAnoEMes.Size = new System.Drawing.Size(617, 63);
            this.panelAnoEMes.TabIndex = 67;
            // 
            // panelSituacao
            // 
            this.panelSituacao.Controls.Add(this.labelSituacao);
            this.panelSituacao.Controls.Add(this.cbSituacao);
            this.panelSituacao.Location = new System.Drawing.Point(3, 583);
            this.panelSituacao.Name = "panelSituacao";
            this.panelSituacao.Size = new System.Drawing.Size(617, 71);
            this.panelSituacao.TabIndex = 68;
            // 
            // panelIESRepasse
            // 
            this.panelIESRepasse.Controls.Add(this.labelIESRepasse);
            this.panelIESRepasse.Controls.Add(this.cbIESRepasse);
            this.panelIESRepasse.Location = new System.Drawing.Point(3, 660);
            this.panelIESRepasse.Name = "panelIESRepasse";
            this.panelIESRepasse.Size = new System.Drawing.Size(615, 68);
            this.panelIESRepasse.TabIndex = 69;
            // 
            // panelFiesSiga
            // 
            this.panelFiesSiga.Controls.Add(this.labelFiesSiga);
            this.panelFiesSiga.Controls.Add(this.cbFiesSiga);
            this.panelFiesSiga.Location = new System.Drawing.Point(3, 734);
            this.panelFiesSiga.Name = "panelFiesSiga";
            this.panelFiesSiga.Size = new System.Drawing.Size(615, 61);
            this.panelFiesSiga.TabIndex = 70;
            this.panelFiesSiga.Tag = "ADITAMENTO";
            // 
            // panelCabecalho
            // 
            this.panelCabecalho.Controls.Add(this.metroLabel16);
            this.panelCabecalho.Controls.Add(this.metroLabel17);
            this.panelCabecalho.Controls.Add(this.metroLabel19);
            this.panelCabecalho.Location = new System.Drawing.Point(3, 3);
            this.panelCabecalho.Name = "panelCabecalho";
            this.panelCabecalho.Size = new System.Drawing.Size(635, 100);
            this.panelCabecalho.TabIndex = 71;
            this.panelCabecalho.Tag = "ADITAMENTO";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.panelCabecalho);
            this.flowLayoutPanel1.Controls.Add(this.gbIES);
            this.flowLayoutPanel1.Controls.Add(this.panelCampus);
            this.flowLayoutPanel1.Controls.Add(this.panelCPF);
            this.flowLayoutPanel1.Controls.Add(this.panelSemestre);
            this.flowLayoutPanel1.Controls.Add(this.panelDataInicioEFim);
            this.flowLayoutPanel1.Controls.Add(this.panelAnoEMes);
            this.flowLayoutPanel1.Controls.Add(this.panelSituacao);
            this.flowLayoutPanel1.Controls.Add(this.panelIESRepasse);
            this.flowLayoutPanel1.Controls.Add(this.panelFiesSiga);
            this.flowLayoutPanel1.Controls.Add(this.btnIniciar);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(33, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1023, 685);
            this.flowLayoutPanel1.TabIndex = 37;
            // 
            // FormDefault
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 691);
            this.Controls.Add(this.panelCadastro);
            this.Name = "FormDefault";
            this.Text = "FormDefault";
            this.panelCadastro.ResumeLayout(false);
            this.panelCadastro.PerformLayout();
            this.gbIES.ResumeLayout(false);
            this.gbIES.PerformLayout();
            this.panelCampus.ResumeLayout(false);
            this.panelCampus.PerformLayout();
            this.panelCPF.ResumeLayout(false);
            this.panelCPF.PerformLayout();
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
            this.panelCabecalho.ResumeLayout(false);
            this.panelCabecalho.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCadastro;
        private System.Windows.Forms.Button btnIniciar;
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
        private MetroFramework.Controls.MetroLabel metroLabel19;
        private MetroFramework.Controls.MetroLabel labelCPFCaracteres;
        private MetroFramework.Controls.MetroLabel metroLabel17;
        private MetroFramework.Controls.MetroLabel metroLabel16;
        private System.Windows.Forms.Label labelDay;
        private MetroFramework.Controls.MetroLabel labelCPF;
        private MetroFramework.Controls.MetroLabel labelCampus;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel labelIES;
        private System.Windows.Forms.ComboBox cbSemestre;
        private System.Windows.Forms.ComboBox cbCampus;
        private System.Windows.Forms.TextBox txtCPF;
        private System.Windows.Forms.ComboBox cbIES;
        private System.Windows.Forms.Panel gbIES;
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
    }
}