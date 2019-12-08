using DigitalCar.RepositorioADO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalCar.Aplicacao
{
    public class FuncionarioAplicacaoConstrutor
    {
        public static FuncionarioAplicacao FuncionarioApADO()
        {
            return new FuncionarioAplicacao(new FuncionarioAplicacaoADO());
        }
    }
}
