using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using DigitalCar.Dominio.Entidade;
using DigitalCar.RepositorioADO;

namespace DigitalCar.Aplicacao
{
    public class FuncionarioAplicacao
    {

        private FuncionarioAplicacaoADO repsitorio;
       
        public void Salvar(Funcionario funcionario)
        {
            repsitorio.Salvar(funcionario);
        }

        public void Excluir(int id)
        {
            repsitorio.Excluir(id);
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

    }
}
