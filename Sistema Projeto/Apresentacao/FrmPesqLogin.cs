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
    public partial class FrmPesqLogin : Form {
        public FrmPesqLogin() {
            InitializeComponent();
            Util.ConfigDataGrid(dgvUsuario);
        }

        private void Pesquisar() {
            try {
                Usuario usuario = new Usuario();
                usuario.Login = txtPesquisa.Text.Trim();
                DataTableCollection resultado = usuario.Pesquisar();
                dgvUsuario.DataSource = resultado[0];

                dgvUsuario.Columns[0].HeaderText = "#";
                dgvUsuario.Columns[1].HeaderText = "Nome do Usuário";
                dgvUsuario.Columns[2].HeaderText = "Tipo";

                dgvUsuario.Columns[0].Width = 20;
                dgvUsuario.Columns[2].Width = 50;
            }
            catch (Exception ERRO) {
                Util.MensagemErro("Erro durante a consulta ao Banco: \n\n " + ERRO.Message);
            }
        }


        private void btnPesquisar_Click(object sender, EventArgs e) {
            Pesquisar();
        }

        private void chkPesquisar_CheckedChanged(object sender, EventArgs e) {
            if (chkPesquisar.Checked) {
                btnPesquisar.Enabled = false;
            }
            else
                btnPesquisar.Enabled = true;
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e) {
            if (!chkPesquisar.Checked) {
                return;
            }
            Pesquisar();
        }

        private void btnExcluir_Click(object sender, EventArgs e) {
            if (dgvUsuario.CurrentRow == null) {
                Util.Mensagem("Selecione um usuário para Excluir! ");
                return;
            }

            int id = Convert.ToInt32(dgvUsuario.SelectedRows[0].Cells[0].Value);
            string login = dgvUsuario.SelectedRows[0].Cells[1].Value.ToString();

            if (login.Equals("admin")) {
                Util.MensagemErro("Não é permitido excluir o usuário 'admin'");
                return;
            }
            if (Util.Pergunta("Deseja realmente Excluir o usuario " + login + "")) {
                try {
                    Usuario usuario = new Usuario();
                    usuario.Id = id;
                    usuario.Excluir();
                    Util.Mensagem("Usuário Excluido com sucesso!");
                    dgvUsuario.Rows.RemoveAt(dgvUsuario.SelectedRows[0].Index);
                }
                catch (Exception ERRO) {
                    Util.MensagemErro("Erro durante a consulta ao Banco: \n\n" + ERRO.Message);
                }
            }
        }

        private void btnAlterarSenha_Click(object sender, EventArgs e) {
            if (dgvUsuario.CurrentRow == null) {
                Util.Mensagem("Selecione um usuário para Alterar a Senha");
                return;
            }

            int id = Convert.ToInt32(dgvUsuario.SelectedRows[0].Cells[0].Value);
            Usuario usuario = new Usuario();
            usuario.Id = id;

            try {
                usuario.Buscar();
                FrmCadLogin frmCadL = new FrmCadLogin(usuario);
                Util.ConfigForm(frmCadL);
                frmCadL.ShowDialog();
            }
            catch (Exception ERRO) {
                Util.MensagemErro("Erro durante a consulta ao Banco: \n\n " + ERRO.Message);
            }
        }
    }
}
