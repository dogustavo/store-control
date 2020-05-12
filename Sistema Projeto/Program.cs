using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema_Projeto.Apresentacao;
using Sistema_Projeto.Logica;
namespace Sistema_Projeto {
    static class Program {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Form Principal
            FrmLogin fLogin = new FrmLogin();
            fLogin.ShowDialog();

            if (Util.tipo_usuario != 0) {
                Application.Run(new FrmPrincipal());
            }
            else {
                Application.Exit();
            }
        }
    }
}
