using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema_Projeto.Dados;
using System.Data;
namespace Sistema_Projeto.Logica {
    public class Usuario {
        private int id;
        private string login;
        private string senha;
        private int tipo;

        public int Id {
            get { return id; }
            set { id = value; }
        }

        public string Login {
            get { return login; }
            set { login = value; }
        }

        public string Senha {
            get { return senha; }
            set { senha = value; }
        }

        public int Tipo {
            get { return tipo; }
            set { tipo = value; }
        }

        public bool ValidaLogin() {

            ConexaoSQL banco = new ConexaoSQL();
            string query = "SELECT * from Usuario WHERE login = '" + login + "'AND senha = '" + senha + "'";

            try {
                DataTableCollection resultado = banco.Consulta(query);

                if (resultado[0].Rows.Count > 0) {
                    this.tipo = Convert.ToInt32(resultado[0].Rows[0][3]);
                    return true;
                }
            }
            catch (Exception erro) {
                Util.MensagemErro("Ocorreu um erro durante a consulta ao banco de dados: \n\n" + erro.Message);
            }
            return false;
        }

        public bool VerificarExistente() {
            ConexaoSQL banco = new ConexaoSQL();
            string query = "select * from Usuario where login= '" + login + "'";

            DataTableCollection resultado = banco.Consulta(query);

            if (resultado[0].Rows.Count > 0) {
                return true;
            }
            return false;
        }

        public void Gravar() {

            ConexaoSQL banco = new ConexaoSQL();
            string query;

            query = "insert into usuario (login, senha, tipo) values ('" + login + "','" + senha + "'," + tipo + ")";
            banco.ExecutarComando(query);
        }

        public void Atualizar() {
            ConexaoSQL banco = new ConexaoSQL();
            StringBuilder sbQuery = new StringBuilder();

            sbQuery.Append("UPDATE Usuario SET ");
            sbQuery.Append("login='" + login + "', senha='" + senha + "', tipo='" + tipo + "'");
            sbQuery.Append("WHERE id=" + id);

            banco.ExecutarComando(sbQuery.ToString());
           
        }

        public DataTableCollection Pesquisar() {
            ConexaoSQL banco = new ConexaoSQL();

            string query = "select id,login,tipo from Usuario where login like '%" + login + "%'";

            return banco.Consulta(query);
        }

        public void Buscar() {
            ConexaoSQL banco = new ConexaoSQL();

            string query = "select * from Usuario where id= " + id;
            DataTableCollection resultado = banco.Consulta(query);

            this.id = Convert.ToInt32(resultado[0].Rows[0][0]);
            this.login = Convert.ToString(resultado[0].Rows[0][1]);
            this.senha = "";
            this.tipo = Convert.ToInt32(resultado[0].Rows[0][3]);
        }

        public void Excluir() {
            ConexaoSQL banco = new ConexaoSQL();
            string query = "delete from usuario where id=" + id;
            banco.ExecutarComando(query);
        }

    }
}
