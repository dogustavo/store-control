using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema_Projeto.Dados;
using System.Data;


namespace Sistema_Projeto.Logica {
    public class Cliente {
        private int idCliente;
        private string nome;
        private string rg;
        private string cpf;
        private string telefone;
        private DateTime datanasc;
        private string sexo;
        private string estadociv;
        private string cidade;
        private string rua;
        private string uf;
        private string bairro;
        private string numero;
        
        public int IdCliente {
            get {
                return idCliente;
            }
            set {
                idCliente = value;
            }
        }
        public string Nome {
            get {
                return nome;
            }

            set {
                nome = value;
            }
        }

        public string Cidade {
            get {
                return cidade;
            }

            set {
                cidade = value;
            }
        }

        public string Rua {
            get {
                return rua;
            }

            set {
                rua = value;
            }
        }

        public string Bairro {
            get {
                return bairro;
            }

            set {
                bairro = value;
            }
        }

        public string Uf {
            get {
                return uf;
            }

            set {
                uf = value;
            }
        }

        public string Estadociv {
            get {
                return estadociv;
            }

            set {
                estadociv = value;
            }
        }

        public string Sexo {
            get {
                return sexo;
            }

            set {
                sexo = value;
            }
        }

        public string Numero {
            get {
                return numero;
            }

            set {
                numero = value;
            }
        }

        public string Rg {
            get {
                return rg;
            }

            set {
                rg = value;
            }
        }

        public string Cpf {
            get {
                return cpf;
            }

            set {
                cpf = value;
            }
        }

        public string Telefone {
            get {
                return telefone;
            }

            set {
                telefone = value;
            }
        }

        public DateTime Datanasc {
            get {
                return datanasc;
            }

            set {
                datanasc = value;
            }
        }

        public bool VerificarExistente() {
            ConexaoSQL banco = new ConexaoSQL();
            string query = "SELECT * FROM cliente WHERE CPF='" + Cpf + "'";

            DataTableCollection resultado = banco.Consulta(query);

            if (resultado[0].Rows.Count > 0) {
                return true;
            }
            return false;
        }

        public void Gravar() {
            ConexaoSQL banco = new ConexaoSQL();
            StringBuilder sbQuery = new StringBuilder();

            sbQuery.Append("INSERT INTO cliente ");
            sbQuery.Append("(nome,cidade,bairro,rua,uf,numero,estadociv,");
            sbQuery.Append("sexo,rg,cpf,telefone,datanasc) ");
            sbQuery.Append("VALUES (");
            sbQuery.Append("'" + nome + "','" + cidade + "','" + bairro);
            sbQuery.Append("','" + rua + "','" + uf + "','" + numero + "','" + estadociv);
            sbQuery.Append("','" + sexo + "','" + rg + "','" + cpf + "','" + telefone + "','" + datanasc + "'");
            sbQuery.Append(")");

            banco.ExecutarComando(sbQuery.ToString());

        }

        public void Atualizar() {
            ConexaoSQL banco = new ConexaoSQL();
            StringBuilder sbQuery = new StringBuilder();

            sbQuery.Append("UPDATE cliente SET ");
            sbQuery.Append("nome='" + nome + "',cidade='" + cidade + "',bairro='" + bairro);
            sbQuery.Append("',rua='" + rua + "',uf='" + uf + "',numero='" + numero + "',estadociv='" + estadociv);
            sbQuery.Append("',sexo='" + sexo + "',rg='" + rg + "',cpf='" + cpf + "',telefone='" + telefone + "',datanasc='" + datanasc.ToString()+ "'");
            sbQuery.Append(" WHERE id = " + idCliente);
            
            banco.ExecutarComando(sbQuery.ToString());
        }

        public DataTableCollection Pesquisar() {
            ConexaoSQL banco = new ConexaoSQL();
            string query = "SELECT * FROM cliente";
            return banco.Consulta(query);
        }

        private void AtribuirCampos(DataTableCollection resultado) {
            DataRow linha = resultado[0].Rows[0];

            idCliente = Convert.ToInt32(linha["idCliente"]);
            nome = linha["nome"].ToString();
            cidade = linha["cidade"].ToString();
            bairro = linha["bairro"].ToString();
            rua = linha["rua"].ToString();
            uf = linha["UF"].ToString();
            Numero = linha["numero"].ToString();
            estadociv = linha["estadociv"].ToString();
            sexo = linha["sexo"].ToString();
            rg = linha["rg"].ToString();
            cpf = linha["cpf"].ToString();
            Telefone = linha["telefone"].ToString();
            datanasc = Convert.ToDateTime(linha["datanasc"].ToString());

        }

        public void Buscar() {
            ConexaoSQL banco = new ConexaoSQL();
            string query = "SELECT * FROM cliente WHERE CPF='" + cpf + "'";
            AtribuirCampos(banco.Consulta(query));
        }
        public void BuscarID() {
            ConexaoSQL banco = new ConexaoSQL();
            string query = "SELECT * FROM cliente WHERE idCliente='" + idCliente + "'";
            AtribuirCampos(banco.Consulta(query));
        }
        public void Excluir() {
            ConexaoSQL banco = new ConexaoSQL();
            string query = "DELETE FROM cliente WHERE idCliente=" + idCliente;
            banco.ExecutarComando(query);
        }

        public DataTableCollection MostrarPasc() {
            ConexaoSQL banco = new ConexaoSQL();
            string query = "SELECT idCliente AS Código,nome AS Nome,cpf AS CPF,rg AS RG,datanasc AS 'Data de Nascimento' from Cliente";
            return banco.Consulta(query);
        }


    }
}
