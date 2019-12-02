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
        private readonly FuncionarioAplicacaoADO repositorio;
        public FuncionarioAplicacao()
        {
            repositorio = new FuncionarioAplicacaoADO();
        }

        public void Salvar(Funcionario funcionario)
        {
            repositorio.Salvar(funcionario);
        }

        public void Excluir(int id)
        {
            repositorio.Excluir(id);
        }

        public List<Funcionario> Lista()
        {
            return repositorio.Lista();
        }

        public Funcionario ListaPorId(int id)
        {
            return repositorio.ListaPorId(id);
        }

    }
}
