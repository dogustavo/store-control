using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SQLite;
namespace Sistema_Projeto.Dados {
    class ConexaoSQL {
        public SQLiteConnection con = new SQLiteConnection("Data Source = Loja.db");

        //Abrir Conexão com BD
        private SQLiteConnection AbrirBanco() {
            con.Open();
            return con;
        }
        //Encerrar Conexão
        public void FecharBanco(SQLiteConnection con) {
            if (con.State == ConnectionState.Open) {
                con.Close();
            }
        }

        //Método para rodar um comando SQL (INSERT, UPDATE)
        public void ExecutarComando(string query) {

            SQLiteConnection con = new SQLiteConnection();

            try {
                con = AbrirBanco();
                SQLiteCommand comando = new SQLiteCommand();
                comando.CommandText = query.ToString();
                comando.CommandType = CommandType.Text;
                comando.Connection = con;
                comando.ExecuteNonQuery();
            }
            catch (Exception) {
                throw;
            }
            finally {
                FecharBanco(con);
            }
        }

        //Método para rodar uma consulta SQL (SELECT - retorna um DataTableCollection):
        public DataTableCollection Consulta(string query) {
            SQLiteConnection con = new SQLiteConnection();

            try {
                con = AbrirBanco();
                SQLiteCommand comando = new SQLiteCommand();
                comando.CommandText = query.ToString();
                comando.CommandType = CommandType.Text;
                comando.Connection = con;
                comando.ExecuteNonQuery();

                SQLiteDataAdapter adapter = new SQLiteDataAdapter();
                DataSet dsDados = new DataSet();
                adapter.SelectCommand = comando;
                adapter.Fill(dsDados, "Dados"); //"Dados" é o nome do indice p da tabela de resultados
                return dsDados.Tables;         //Pode ser utilizado o índice [0] ao invés de ["Dados"] 
            }
            catch (Exception) {
                throw;
            }
            finally {
                FecharBanco(con);
            }
        }


    }
}
