using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using DigitalCar.Dominio.Contrato;
using DigitalCar.Dominio.Entidade;
using DigitalCar.RepositorioADO;

namespace DigitalCar.Aplicacao
{
    public class FuncionarioAplicacao
    {
        //private readonly FuncionarioAplicacaoADO repositorio;
        private readonly IRepositorio<Funcionario> repositorio;
        public FuncionarioAplicacao(IRepositorio<Funcionario>repositorio)
        {
            repositorio = repositorio;
        }

        public void Salvar(Funcionario funcionario)
        {
            repositorio.Salvar(funcionario);
        }

        public void Excluir(Funcionario funcionario)
        {
            repositorio.Excluir(funcionario);
        }

        public IEnumerable<Funcionario> Lista()
        {
            return repositorio.Lista();
        }

        public Funcionario ListaPorId(string id)
        {
            return repositorio.ListaPorId(id);
        }

    }
}
