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
    public partial class FrmCadUsuario : Form {

        Cliente cli = new Cliente();

        public FrmCadUsuario(Cliente c = null) {
            
            InitializeComponent();

            if (c == null) {
                ModoCadastro();
            }
            else {
                ModoAtualizacao();
                setCliente(c);
                btnLimpar.Text = "Cancelar";
            }
        }

        public bool ValidaTodos() {
            if (!Valida.Campo(mskCPF, "CPF", 11)) {
                return false;
            }
            if (!Valida.Campo(mskDataNasc, "Datanasc", 8)) {
                return false;
            }
            if (!Valida.Campo(txtNome, "Nome")) {
                return false;
            }
            if (!Valida.Campo(mskRG, "RG", 9)) {
                return false;
            }
            if (!Valida.Campo(cboSexo, "Sexo")) {
                return false;
            }
            if (!Valida.Campo(cboEstadoCiv, "Estadociv")) {
                return false;
            }
            if (!Valida.Campo(txtCidade, "Cidade")) {
                return false;
            }
            if (!Valida.Campo(txtRua, "Rua")) {
                return false;
            }
            if (!Valida.Campo(cboUF, "UF")) {
                return false;
            }
            if (!Valida.Campo(txtBairro, "Bairro")) {
                return false;
            }
            if (!Valida.Campo(txtNumero, "Numero")) {
                return false;
            }
            return true;
        }

        private void ModoCadastro() {
            this.Text = "Cadastro de Funcionário";
            lblStatus2.Text = "NOVO CADASTRO";
            lblStatus2.ForeColor = System.Drawing.Color.Blue;
            Limpar();

            btnCadastrar.Enabled = true;
            btnAtualizar.Enabled = false;
            this.AcceptButton = btnCadastrar;
        }

        private void ModoAtualizacao() {
            this.Text = "Atualização de Funcionário";
            lblStatus2.Text = "ATUALIZAÇÃO";
            label1.Text = "Atualização de Funcionário";
            lblStatus2.ForeColor = System.Drawing.Color.Red;

            btnCadastrar.Enabled = false;
            btnAtualizar.Enabled = true;
            this.AcceptButton = btnAtualizar;
            mskCPF.Enabled = false;
        }

        private void Limpar() {
            lblCodigo.Text = "";
            txtNome.Clear();
            txtCidade.Clear();
            txtBairro.Clear();
            txtRua.Clear();
            cboUF.Text = "";
            txtNumero.Clear();
            cboEstadoCiv.Text = "";
            cboSexo.Text = "";
            mskRG.Clear();
            mskTelefone.Clear();

            mskDataNasc.Text = "";
            mskCPF.Enabled = true;
        }


        private void btnLimpar_Click(object sender, EventArgs e) {
            if (btnLimpar.Text == "Cancelar") {
                this.Dispose();
            }
            ModoCadastro();
            mskCPF.Clear();
            mskCPF.Focus();
        }

        private void btnCadastrar_Click(object sender, EventArgs e) {
            string cpf = mskCPF.Text.Trim();
            if (Valida.IsCpf(cpf)) {
                if (!ValidaTodos()) {
                    return;
                }

                try {
                    cli = new Cliente();
                    cli = GetCliente();
                    cli.Gravar();
                    Util.Mensagem("Dados gravados com sucesso!");
                    Limpar();
                    mskCPF.Clear();
                    mskCPF.Focus();
                }
                catch (Exception ERRO) {
                    Util.Mensagem("Falha na gravação dos dados. \n\n" + ERRO.Message);
                }
            }
            else {
                Util.MensagemErro("Campo CPF Vazio ou inválido!");
            }
            


        }

        private Cliente GetCliente() {
            Cliente C = new Cliente();

            int xID;

            if (int.TryParse(lblCodigo.Text, out xID)) {
                C.IdCliente = xID;
            }

            C.Cpf = mskCPF.Text.Trim();
            C.Nome = txtNome.Text.Trim();
            C.Telefone = mskTelefone.Text.Trim();

            C.Datanasc = DateTime.Parse(mskDataNasc.Text.Trim());

            C.Rua = txtRua.Text.Trim();
            C.Rg = mskRG.Text.Trim();
            C.Sexo = cboSexo.Text;
            C.Uf = cboUF.Text;
            C.Cidade = txtCidade.Text.Trim();
            C.Bairro = txtBairro.Text.Trim();
            C.Estadociv = cboEstadoCiv.Text;
            C.Numero = txtNumero.Text.Trim();

            return C;
        }

        private void setCliente(Cliente cli) {
            lblCodigo.Text = cli.IdCliente.ToString();
            mskCPF.Text = cli.Cpf;
            txtNome.Text = cli.Nome;
            mskTelefone.Text = cli.Telefone;

            mskDataNasc.Text = cli.Datanasc.ToString();

            txtRua.Text = cli.Rua;
            mskRG.Text = cli.Rg;
            cboSexo.Text = cli.Sexo;
            txtBairro.Text = cli.Bairro;
            txtCidade.Text = cli.Cidade;
            cboUF.Text = cli.Uf;
            txtNumero.Text = cli.Numero;
            cboEstadoCiv.Text = cli.Estadociv;
        }

        private void btnAtualizar_Click(object sender, EventArgs e) {
            if (!ValidaTodos()) {
                return;
            }

            try {
                cli = new Cliente();
                cli = GetCliente();
                cli.Atualizar();
                Util.Mensagem("Dados atualizados com sucesso!");
                if (btnLimpar.Text == "Cancelar") {
                    this.Dispose();
                }

                ModoCadastro();
                mskCPF.Clear();
                mskCPF.Focus();
            }
            catch (Exception ERRO) {
                Util.Mensagem("Falha na atualização dos dados. \n\n" + ERRO.Message);
            }
        }

        private void PesquisarCliente() {
            cli = new Cliente();
            cli.Cpf = mskCPF.Text;
            try {
                if (cli.VerificarExistente()) {
                    cli.Buscar();
                    setCliente(cli);
                    ModoAtualizacao();

                }
                else {
                    ModoCadastro();
                }
            }
            catch (Exception erro) {
                Util.Mensagem("Falha no acesso ao banco de dados. \n\n" + erro.Message);

            }
        }

        private void mskCPF_KeyPress(object sender, KeyPressEventArgs e) {
            Valida.TeclaLetras(e);
            
        }

        private void mskCPF_Leave(object sender, EventArgs e) {
            PesquisarCliente();

        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e) {
            Valida.TeclaLetras(e);
        }

        private void txtCidade_KeyPress(object sender, KeyPressEventArgs e) {
            Valida.TeclaLetras(e);
        }

        private void txtBairro_KeyPress(object sender, KeyPressEventArgs e) {
            Valida.TeclaLetrasNumeros(e);
        }

        private void txtRua_KeyPress(object sender, KeyPressEventArgs e) {
            Valida.TeclaLetras(e);
        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e) {
            Valida.TeclaNumeros(e);
        }
        
    }
}
