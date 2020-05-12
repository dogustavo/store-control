using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema_Projeto.Logica;
namespace Sistema_Projeto.Logica {
    class Valida {
        public static bool Campo(TextBox txtbox, string msg) {
            if (string.IsNullOrEmpty(txtbox.Text.Trim())) {
                txtbox.BackColor = System.Drawing.Color.Yellow;
                Util.MensagemErro("Campo " + msg + " Vazio ou inválido!");
                txtbox.BackColor = System.Drawing.Color.White;
                return false;
            }
            return true;
        }

        public static bool Campo(MaskedTextBox mskBox, string msg, int comp) {
            string txt = mskBox.Text.Trim();
            if ((string.IsNullOrEmpty(txt)) || (txt.Length != comp)) {
                mskBox.BackColor = System.Drawing.Color.Yellow;
                Util.MensagemErro("Campo " + msg + " Vazio ou inválido!");
                mskBox.BackColor = System.Drawing.Color.White;
                mskBox.Focus();
                return false;
            }
            return true;
        }

        public static bool Campo(ComboBox cbobox, string msg) {
            if (string.IsNullOrEmpty(cbobox.Text.Trim())) {
                Util.MensagemErro("Campo " + msg + " Vazio ou inválido!");
                cbobox.Focus();
                return false;
            }
            return true;
        }

        public static bool DataNascCliente(DateTimePicker dtpicker) {
            if (dtpicker.Value > DateTime.Now.AddYears(-16)) {
                Util.MensagemErro("Data de Nascimento inválida (menor de 16 anos)");
                dtpicker.Focus();
                return false;
            }
            if (dtpicker.Value < DateTime.Now.AddYears(-90)) {
                Util.MensagemErro("Data de Nascimento inválida (maior de 90 anos)");
                dtpicker.Focus();
                return false;
            }
            return true;
        }


        public static void TeclaLetras(KeyPressEventArgs e) {
            bool letras = char.IsLetter(e.KeyChar);
            bool backspace = e.KeyChar == (char)Keys.Back;
            bool espaco = e.KeyChar == (char)Keys.Space;

            if (!letras && !backspace && !espaco) {
                e.Handled = true;
            }
        }
        public static void TeclaNumeros(KeyPressEventArgs e) {
            bool numeros = char.IsNumber(e.KeyChar);
            bool backspace = e.KeyChar == (char)Keys.Back;
            bool espaco = e.KeyChar == (char)Keys.Space;

            if (!numeros && !backspace && !espaco) {
                e.Handled = true;
            }
        }

        public static void TeclaLetrasNumeros(KeyPressEventArgs e) {
            bool letras = char.IsLetter(e.KeyChar);
            bool numeros = char.IsNumber(e.KeyChar);
            bool backspace = e.KeyChar == (char)Keys.Back;
            bool espaco = e.KeyChar == (char)Keys.Space;

            if (!letras && !numeros && !backspace && !espaco) {
                e.Handled = true;
            }
        }

        public static bool IsCpf(string cpf) {
            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

            cpf = cpf.Trim().Replace(".", "").Replace("-", "");
            if (cpf.Length != 11)
                return false;

            for (int j = 0; j < 10; j++)
                if (j.ToString().PadLeft(11, char.Parse(j.ToString())) == cpf)
                    return false;

            string tempCpf = cpf.Substring(0, 9);
            int soma = 0;

            for (int i = 0; i < 9; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];

            int resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            string digito = resto.ToString();
            tempCpf = tempCpf + digito;
            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];

            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            digito = digito + resto.ToString();

            return cpf.EndsWith(digito);
        }

        public static bool Senha(TextBox txtsenha1, TextBox txtsenha2) {
            if (string.IsNullOrEmpty(txtsenha1.Text)) {
                txtsenha1.BackColor = System.Drawing.Color.Yellow;
                Util.MensagemErro("Senha não foi informada ou inválida! ");
                txtsenha1.BackColor = System.Drawing.Color.White;
                return false;
            }
            if (txtsenha1.Text.Length < 6) {
                txtsenha1.BackColor = System.Drawing.Color.Yellow;
                Util.MensagemErro("A senha dever conter 6 caracteres, no mínimo!");
                txtsenha1.BackColor = System.Drawing.Color.White;
                return false;
            }
            if (!txtsenha1.Text.Equals(txtsenha2.Text)) {
                Util.MensagemErro("As senhas digitadas não coincidem!");
                return false;
            }
            return true;
        }

    }
}
