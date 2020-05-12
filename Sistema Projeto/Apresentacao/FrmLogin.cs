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
    public partial class FrmLogin : Form {
        public FrmLogin() {
            InitializeComponent();
        }

        private void Limpar() {
            txtSenha.Clear();
            txtLogin.Focus();
        }



        private void btnLogin_Click(object sender, EventArgs e) {
            if (!Valida.Campo(txtLogin, "Login")) {
                return;
            }
            if (!Valida.Campo(txtSenha, "Senha")) {
                return;
            }
            Usuario usuario = new Usuario();
            usuario.Login = txtLogin.Text.Trim();
            usuario.Senha = txtSenha.Text.Trim();

            if (usuario.ValidaLogin()) {
                Util.tipo_usuario = usuario.Tipo;
                this.Dispose();//Fecha o form de login!
                FrmPrincipal prin = new FrmPrincipal();
                prin.ShowDialog();
            }
            else {
                Util.MensagemErro("Usuario e/ou senha invalidos!");
                Limpar();
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e) {
            txtLogin.Select();
        }

        private void btnSair_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void btnCriar_Click(object sender, EventArgs e) {
            FrmCadLogin cad = new FrmCadLogin();
            cad.ShowDialog();
        }
    }
}
