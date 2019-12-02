using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using DigitalCar.Dominio.Entidade;

namespace DigitalCar.RepositorioADO
{
    public class FuncionarioAplicacaoADO
    {

        private bd bd;
        private void Inserir(Funcionario funcionario)
        {
            var strQuery = "";
            strQuery += "INSERT INTO Funcionario (nome, cpf, rg,dtNascimento, email, telefone, celular, rua, turno, funcao, status, numero, bairro, cidade, cep, uf)";
            strQuery += string.Format("VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}', '{13}', '{14}', '{15}')"
                                      , funcionario.Nome, funcionario.Cpf, funcionario.Rg, funcionario.DataNascimento, funcionario.Email
                                      , funcionario.Telefone, funcionario.Celular, funcionario.Rua, funcionario.Turno, funcionario.Funcao
                                      ,funcionario.Status, funcionario.Numero, funcionario.Bairro, funcionario.Cidade, funcionario.Cep, funcionario.UF);


            using (bd = new bd())
            {
                bd.ExecutaComnado(strQuery);
            }
        }

        private void Alterar(Funcionario funcionario)
        {
            var strQuery = "";
            strQuery += "UPDATE Funcionario SET ";
            strQuery += string.Format("nome = '{0}',", funcionario.Nome);
            strQuery += string.Format("cpf = '{0}',", funcionario.Cpf);
            strQuery += string.Format("rg = '{0}',", funcionario.Rg);
            strQuery += string.Format("dtNascimento = '{0}',", funcionario.DataNascimento);
            strQuery += string.Format("email = '{0}',", funcionario.Email);
            strQuery += string.Format("turno = '{0}',", funcionario.Turno);
            strQuery += string.Format("funcao = '{0}',", funcionario.Funcao);
            strQuery += string.Format("status = '{0}',", funcionario.Status);
            strQuery += string.Format("telefone = '{0}',", funcionario.Telefone);
            strQuery += string.Format("celular = '{0}',", funcionario.Celular);
            strQuery += string.Format("cep = '{0}',", funcionario.Cep);
            strQuery += string.Format("uf = '{0}',", funcionario.UF);
            strQuery += string.Format("cidade = '{0}',", funcionario.Cidade);
            strQuery += string.Format("rua = '{0}',", funcionario.Rua);
            strQuery += string.Format("numero = '{0}',", funcionario.Numero);
            strQuery += string.Format("bairro = '{0}' ", funcionario.Bairro);
            strQuery += string.Format("WHERE codigoId = '{0}'", funcionario.Id);

            using (bd = new bd())
            {
                bd.ExecutaComnado(strQuery);
            }
        }

        public void Salvar(Funcionario funcionario)
        {
            if (funcionario.Id > 0)
            {
                Alterar(funcionario);
            }
            else
            {
                Inserir(funcionario);
            }
        }

        public void Excluir(int id)
        {
            using (bd = new bd())
            {
                var strQuery = string.Format("DELETE  FROM Funcionario WHERE codigoId = {0}", id);
                bd.ExecutaComnado(strQuery);
            }
        }

        public List<Funcionario> Lista()
        {
            using (bd = new bd())
            {
                var strQuery = "SELECT * FROM Funcionario";
                var retorno = bd.ExecutaComandoComRetorno(strQuery);
                return ReaderEmLista(retorno);
            }
        }

        public Funcionario ListaPorId(int id)
        {
            using (bd = new bd())
            {
                var strQuery = string.Format("SELECT * FROM Funcionario WHERE CodigoId = {0}", id);
                var retorno = bd.ExecutaComandoComRetorno(strQuery);
                return ReaderEmLista(retorno).FirstOrDefault();
            }
        }

        private List<Funcionario> ReaderEmLista(SqlDataReader reader)
        {
            var funcionario = new List<Funcionario>();
            while (reader.Read())
            {
                var tempoObjeto = new Funcionario()
                {
                    Id = int.Parse(reader["codigoId"].ToString()),
                    Nome = reader["nome"].ToString(),
                    Cpf = reader["cpf"].ToString(),
                    Rg = reader["rg"].ToString(),
                    DataNascimento = DateTime.Parse(reader["dtNascimento"].ToString()),
                    Email = reader["email"].ToString(),
                    Turno = reader["turno"].ToString(),
                    Funcao = reader["funcao"].ToString(),
                    Status = reader["status"].ToString(),
                    Telefone = reader["telefone"].ToString(),
                    Celular = reader["celular"].ToString(),
                    Cep = reader["cep"].ToString(),
                    UF = reader["uf"].ToString(),
                    Cidade = reader["cidade"].ToString(),
                    Rua = reader["rua"].ToString(),
                    Numero = int.Parse(reader["numero"].ToString()),
                    Bairro = reader["bairro"].ToString()
                };

                funcionario.Add(tempoObjeto);
            }
            reader.Close();
            return funcionario;
        }
    }
}
