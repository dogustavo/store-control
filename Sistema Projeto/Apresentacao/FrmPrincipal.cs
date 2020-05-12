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
using Sistema_Projeto.Apresentacao;

namespace Sistema_Projeto.Apresentacao {
    public partial class FrmPrincipal : Form {
        public FrmPrincipal() {
            InitializeComponent();
        }

    

        private void tsbSair_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void tsmSair_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void tsbCadCliente_Click(object sender, EventArgs e) {
            FrmCadUsuario cad = new FrmCadUsuario();
            cad.ShowDialog();
        }

        private void tsmCadCliente_Click(object sender, EventArgs e) {
            FrmCadUsuario cad = new FrmCadUsuario();
            cad.ShowDialog();
        }

        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e) {
            if (Util.Pergunta("Deseja sair do sistema?")) {
                System.Environment.Exit(0);
            }
            else {
                e.Cancel = true;
            }
        }

        private void tsmCadProduto_Click(object sender, EventArgs e) {
        }

        private void tsmSobre_Click(object sender, EventArgs e) {
            AboutBoxLoja sobre = new AboutBoxLoja();
            sobre.ShowDialog();
        }

        private void pesquisarToolStripMenuItem_Click(object sender, EventArgs e) {
            FrmPesqLogin pesq = new FrmPesqLogin();
            pesq.ShowDialog();
        }

        private void tsmPesqCliente_Click(object sender, EventArgs e) {
            FrmPesqCliente cli = new FrmPesqCliente();
            cli.ShowDialog();
        }
    }
}
