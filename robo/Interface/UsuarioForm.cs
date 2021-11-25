﻿using robo;
using robo.TO;
using System;
using System.Drawing;
using robo.Utils;
using System.Windows.Forms;
using robo.Banco_de_Dados;

namespace robo.Interface
{
    public partial class UsuarioForm : Form
    {
        public UsuarioForm(Point location, TOUsuario usuario = null)
        {
            InitializeComponent();
            this.Location = location;
            cbIES.Text = Program.login.IES.ToUpper();
            cbIES.Enabled = false;
            if (usuario != null)
            {
                txtId.Text = usuario.Id.ToString();
                txtUser.Text = usuario.Usuario;
                txtSenhaUsuario.Text = string.Empty;
                cbPermissoes.Text = usuario.Permissao;
                cbRegional.Text = usuario.Regional;

                this.btnOKLogin.Text = "Atualizar";
                txtId.Enabled = false;
                this.txtUser.Enabled = false;
                this.btnOKLogin.Click -= new EventHandler(this.btnOKLogin_Click);
                this.btnOKLogin.Click += new EventHandler(this.btnAtualizarLogin_Click);
            }
            else
            {
                txtUser.Text = string.Empty;
                txtSenhaUsuario.Text = string.Empty;
                cbPermissoes.Text = string.Empty;

                this.btnOKLogin.Text = "Aceitar";
                this.txtUser.Enabled = true;
                this.btnOKLogin.Click -= new EventHandler(this.btnAtualizarLogin_Click);
                this.btnOKLogin.Click += new EventHandler(this.btnOKLogin_Click);
            }
        }

        private void btnCancelLogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOKLogin_Click(object sender, EventArgs e)
        {
            try
            {
                Dados.InsertDocumento<TOUsuario>(UsuarioPreenchido());
                MessageBox.Show("Usuario adicionado com sucesso.");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            finally
            {
                this.Close();
            }
        }

        private void btnAtualizarLogin_Click(object sender, EventArgs e)
        {
            try
            {
                Dados.UpdateDocumento<TOUsuario>(UsuarioPreenchido());
                MessageBox.Show("Login atualizado com sucesso.");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            finally
            {
                this.Close();
            }
        }

        private TOUsuario UsuarioPreenchido()
        {
            TOUsuario Usuario = new TOUsuario();
            Usuario.Id = Convert.ToInt32(txtId.Text);
            Usuario.Usuario = txtUser.Text;
            Usuario.Senha = Util.GetMD5(txtSenhaUsuario.Text);
            Usuario.Permissao = cbPermissoes.Text;
            Usuario.IES = cbIES.Text;
            Usuario.Regional = cbRegional.Text;
            return Usuario;
        }
    }
}
