using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema_Projeto.Logica;

namespace Sistema_Projeto.Apresentacao {
    public partial class FrmCadLogin : Form {
        Usuario usuario;
        
        public FrmCadLogin(Usuario n_usuario = null) {
            InitializeComponent();

            if (n_usuario == null) {
                btnCadastrar.Enabled = true;
                btnAlterarSenha.Enabled = false;
            }
            else {
                btnCadastrar.Enabled = false;
                btnAlterarSenha.Enabled = true;
                txtLogin.Enabled = false;
                chkAdmin.Enabled = false;
                lblCadastroUsuaruio.Text = "Alterar Senha (" + n_usuario.Login + ")";
                btnSair.Text = "Cancelar";
                txtLogin.Text = n_usuario.Login;

                if (n_usuario.Tipo == 1) {
                    chkAdmin.Checked = true;
                }
                else {
                    chkAdmin.Checked = false;
                }
                this.usuario = n_usuario;
            }

        }
        
        private void Limpar() {
            txtLogin.Clear();
            txtSenha2.Clear();
            txtSenha1.Clear();
            chkAdmin.Checked = false;
        }

        private void btnCadastrar_Click(object sender, EventArgs e) {
            if (!Valida.Campo(txtLogin, "Nome de Login")) {
                return;
            }
            if (!Valida.Senha(txtSenha1, txtSenha2)) {
                return;
            }
            try {
                usuario = new Usuario();
                usuario.Login = txtLogin.Text.Trim();
                usuario.Senha = txtSenha2.Text.Trim();

                if (chkAdmin.Checked) {
                    usuario.Tipo = 1;
                }
                else {
                    usuario.Tipo = 2;
                }
                if (usuario.VerificarExistente()) {
                    Util.MensagemErro("Usuário " + usuario.Login + " já existe!");
                    txtLogin.Focus();
                }
                else {
                    usuario.Gravar();
                    Util.Mensagem("Dados Gravados com Sucesso!");
                    Limpar();
                }
            }
            catch (Exception ERRO) {
                Util.MensagemErro("Falha na gravação dos dados. \n\n" + ERRO.Message);
            }
        }

        private void btnAlterarSenha_Click(object sender, EventArgs e) {
            if (!Valida.Senha(txtSenha1, txtSenha2)) {
                return;
            }
            try {
                usuario.Senha = txtSenha2.Text.Trim();
                usuario.Atualizar();
                Util.Mensagem("Senha alterada com Sucesso!");
                this.Dispose();
            }
            catch (Exception ERRO) {
                Util.MensagemErro("Falha na gravação dos dados. \n\n" + ERRO.Message);
            }
        }

        private void btnSair_Click(object sender, EventArgs e) {
            if (btnSair.Text.Equals("Cancelar")) {
                Util.Mensagem("A senha não foi alterado!");
            }
            this.Dispose();
        }

        

       
        
    }
}
