using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Sistema_Projeto.Logica {
    class Util {
        private const string NOMESISTEMA = "Projeto Loja";
        public static int tipo_usuario = 0;


        //Método para realizar uma pergunta - retorna um bool (V ou F)
        public static Boolean Pergunta(string txt) {
            DialogResult resposta = MessageBox.Show(txt, NOMESISTEMA,
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1);

            if (resposta == DialogResult.Yes) {
                return true;
            }

            return false;
        }

        //Método para exibir uma mensagem.
        public static void Mensagem(String txt,
            MessageBoxIcon icone = MessageBoxIcon.Information) {
            MessageBox.Show(txt, NOMESISTEMA, MessageBoxButtons.OK, icone);
        }

        //Método para exibir uma mensagem de Erro
        public static void MensagemErro(String txt) {
            Mensagem(txt, MessageBoxIcon.Error);
        }

        //Método para configurar um formulário
        public static void ConfigForm(Form f) {
            f.FormBorderStyle = FormBorderStyle.FixedDialog;
            f.StartPosition = FormStartPosition.CenterParent;
            //f.ControlBox = false;
            f.MaximizeBox = false;
            f.MinimizeBox = false;
            f.ShowInTaskbar = false;
        }

        //Configurador de GridViews:
        public static void ConfigDataGrid(DataGridView d) {
            d.AllowUserToAddRows = false;
            d.AllowUserToDeleteRows = false;
            d.AllowUserToResizeRows = false;
            //d.AllowUserToResizeColumns = false;
            d.AllowUserToOrderColumns = false;
            d.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.DarkGray;
            d.BackgroundColor = System.Drawing.Color.White;
            d.CellBorderStyle = DataGridViewCellBorderStyle.None;
            d.EditMode = DataGridViewEditMode.EditProgrammatically;
            d.RowHeadersVisible = false;
            d.ScrollBars = ScrollBars.Vertical;
            d.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            d.MultiSelect = false;
            d.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            d.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
