using BlockTime_Tracking.Contexts;
using BlockTime_Tracking.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlockTime_Tracking.Repositories
{
    public class EmpresaRepository
    {
        BlockTrackingContext ctx = new BlockTrackingContext();

        public Empresa BuscarPorId(int idEmpresa)
        {
            return ctx.Empresas.FirstOrDefault(ab => ab.IdEmpresa == idEmpresa);
        }
    }
}
