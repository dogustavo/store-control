using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema_Projeto.Apresentacao;
using Sistema_Projeto.Logica;

namespace Sistema_Projeto.Apresentacao {
    public partial class FrmPesqCliente : Form {
        //Filtra os dados
        BindingSource bsresultado = new BindingSource();

        public FrmPesqCliente() {
            InitializeComponent();
            Util.ConfigDataGrid(dgvFunc);
            mskPesquisa.Select();
        }

        private void Filtrar() {
            if (string.IsNullOrEmpty(mskPesquisa.Text.Trim())) {
                bsresultado.RemoveFilter();
                return;
            }
            bsresultado.Filter = "Nome LIKE '%" + mskPesquisa.Text + "%'";
        }
        private void AtualizarDataGrid() {
            for (int i = 0; i < clbItens.Items.Count; i++) {
                if (clbItens.GetItemChecked(i)) {
                    dgvFunc.Columns[i].Visible = true;
                }
                else {
                    dgvFunc.Columns[i].Visible = false;
                }
            }

        }

        private void AtualizarCheckListBox() {
            for (int i = 0; i < dgvFunc.Columns.Count; i++) {
                clbItens.Items.Add(dgvFunc.Columns[i].Name, true);
            }
        }

        private void Pesquisar() {
            clbItens.Items.Clear();
            mskPesquisa.Clear();
            mskPesquisa.Focus();

            try {
                Cliente cli = new Cliente();
                DataTableCollection resultaado = cli.Pesquisar();
                bsresultado.DataSource = resultaado[0];
                dgvFunc.DataSource = resultaado[0];
                AtualizarCheckListBox();
                AtualizarDataGrid();
                //FormataColunas();
            }
            catch (Exception e) {
                Util.Mensagem("Falha ao acesso aos dados durante a consulta.\n\n" + e.Message);
            }
        }


        private void clbItens_SelectedIndexChanged(object sender, EventArgs e) {
            AtualizarDataGrid();
        }

        private void mskPesquisa_TextChanged(object sender, EventArgs e) {
            Filtrar();
        }

        private void mskPesquisa_KeyPress(object sender, KeyPressEventArgs e) {
            Valida.TeclaLetrasNumeros(e);
        }

        private void btnEditar_Click(object sender, EventArgs e) {
            if (dgvFunc.CurrentRow == null) {
                Util.Mensagem("Selecione um cliente para editar");
                return;
            }

            int id = Convert.ToInt32(dgvFunc.SelectedRows[0].Cells[0].Value);
            Cliente cli = new Cliente();
            cli.IdCliente = id;

            try {
                cli.BuscarID();
                FrmCadUsuario fCaduser = new FrmCadUsuario(cli);
                Util.ConfigForm(fCaduser);
                fCaduser.ShowDialog();
            }
            catch (Exception ERRO) {
                Util.MensagemErro("Erro durante a consulta ao Banco:\n\n " + ERRO.Message);
            }
        }

        private void FrmPesqCliente_Shown(object sender, EventArgs e) {
            Pesquisar();
        }

        private void btnExcluir_Click(object sender, EventArgs e) {
            if (dgvFunc.CurrentRow == null) {
                Util.Mensagem("Selecione um Cliente para Excluir");
                return;
            }

            int id = Convert.ToInt32(dgvFunc.SelectedRows[0].Cells[0].Value);

            if (Util.Pergunta("Deseja realmente Excluir o cliente #" + id + "?")) {
                try {
                    Cliente cli = new Cliente();
                    cli.IdCliente = id;
                    cli.Excluir();
                    Util.Mensagem("Cliente" + cli.Nome + "Excluído com sucesso");
                    dgvFunc.Rows.RemoveAt(dgvFunc.SelectedRows[0].Index);
                }
                catch (Exception ERRO) {
                    Util.MensagemErro("Erro durante a consulta ao Banco:\n\n " + ERRO.Message);
                }
            }
        }

        private void FrmPesqCliente_Shown_1(object sender, EventArgs e) {
            Pesquisar();
        }
    }
}
