using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalCar.RepositorioEF
{
    public class ConfiguracaoEF : DbConfiguration
    {
        public ConfiguracaoEF()
        {
            SetProviderServices(System.Data.Entity.SqlServer.SqlProviderServices.ProviderInvariantName,
                                System.Data.Entity.SqlServer.SqlProviderServices.Instance);
        }
    }
}
