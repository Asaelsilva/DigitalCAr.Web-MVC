using DigitalCar.Dominio.Contrato;
using DigitalCar.Dominio.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalCar.RepositorioEF
{
    public class FuncionarioRepositorioEF : IRepositorio<Funcionario>
    {
        private readonly BD bd;

        public FuncionarioRepositorioEF()
        {
            bd = new BD();
        }
         
        public void Excluir(Funcionario entidade)
        {
            var funcionarioExcluir = bd.funcionario.First(x => x.Id == entidade.Id);
            bd.Set<Funcionario>().Remove(funcionarioExcluir);
            bd.SaveChanges();
        }

        public IEnumerable<Funcionario> Lista()
        {
            return bd.funcionario;
        }

        public Funcionario ListaPorId(string id)
        {
            int idint;
            Int32.TryParse(id, out idint);
            return bd.funcionario.First(x => x.Id == idint);
        }

        public void Salvar(Funcionario entidade)
        {
            if (entidade.Id > 0)
            {
                var funcionarioAlterar = bd.funcionario.First(x => x.Id == entidade.Id);
                
                funcionarioAlterar.Nome = entidade.Nome;
                funcionarioAlterar.Cpf = entidade.Cpf;
                funcionarioAlterar.Rg = entidade.Rg;
                funcionarioAlterar.DataNascimento = entidade.DataNascimento;
                funcionarioAlterar.Email = entidade.Email;
                funcionarioAlterar.Telefone = entidade.Telefone;
                funcionarioAlterar.Celular = entidade.Celular;
                funcionarioAlterar.Rua = entidade.Rua;
                funcionarioAlterar.Turno = entidade.Turno;
                funcionarioAlterar.Funcao = entidade.Funcao;
                funcionarioAlterar.Status = entidade.Status;
                funcionarioAlterar.Numero = entidade.Numero;
                funcionarioAlterar.Bairro = entidade.Bairro;
                funcionarioAlterar.Cidade = entidade.Cidade;
                funcionarioAlterar.Cep = entidade.Cep;
                funcionarioAlterar.UF = entidade.UF;
            }
            else
            {
                bd.funcionario.Add(entidade);
            }
            bd.SaveChanges();
        }
    }
}
