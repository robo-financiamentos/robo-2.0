﻿using Robo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace robo.View
{
    public partial class FormInterface2 : Form
    {
        public FormInterface2()
        {
            InitializeComponent();


        }

        private void btnFiesNovo_Click(object sender, EventArgs e)
        {
            LimparModosDeExecucao();

            SelecionarMenusPorTipoFies("FIES NOVO");
        }

        private void SelecionarMenusPorTipoFies(string tipoFies)
        {
            List<TOMenus> menusFIESNovo = Dados.SelectMenuWhereLite(tipoFies);
            labelTipoFies.Text = tipoFies;
            foreach (var menu in menusFIESNovo)
            {
                Button btn = new Button();
                btn.Text = menu.Item;
                btn.Width = flpModosDeExecucao.Width;
                btn.Tag = menu;
                btn.Click += ExecutarAlgumaCoisa;
                flpModosDeExecucao.Controls.Add(btn);
            }
            //flpModosDeExecucao.Controls[1].Visible = false;
            //flpModosDeExecucao.Controls[2].Visible = false;
        }

        private void ExecutarAlgumaCoisa(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            StartForm((TOMenus)btn.Tag, labelTipoFies.Text.ToUpper());
        }

        private void StartForm(TOMenus menu, string tipoFies)
        {
            //panelCadastro.Controls.Clear();
            FormDefault formulario = new FormDefault(menu, tipoFies);
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            panelCadastro.Controls.Add(formulario);
            //panelCadastro.Tag = formulario;
            formulario.Show();
            formulario.BringToFront();

            //FormImportarCsv formulario2 = new FormImportarCsv();
            //formulario2.TopLevel = false;
            //formulario2.FormBorderStyle = FormBorderStyle.None;
            //formulario2.Dock = DockStyle.Fill;
            //panelCadastro.Controls.Add(formulario2);
            ////panelCadastro.Tag = formulario;
            //formulario2.Show();
            //formulario2.BringToFront();
        }

        private void LimparModosDeExecucao()
        {
            foreach (System.Windows.Forms.Control item in panelCadastro.Controls)
            {
                if (item.GetType() == typeof(FormDefault))
                {
                    panelCadastro.Controls.Remove(item);
                    break;
                }
            }
            if (flpModosDeExecucao.Controls.Count > 0)
            {
                flpModosDeExecucao.Controls.Clear();
            }
        }

        private void btnFiesLegado_Click(object sender, EventArgs e)
        {
            LimparModosDeExecucao();
            SelecionarMenusPorTipoFies("FIES LEGADO");
        }
    }
}