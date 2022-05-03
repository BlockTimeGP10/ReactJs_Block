using BlockTime_Tracking.Contexts;
using BlockTime_Tracking.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlockTime_Tracking.Repositories
{
    public class EquipamentoRepository
    {
        BlockTrackingContext ctx = new BlockTrackingContext();
        ZabbixRepository zabbix = new ZabbixRepository();
        EmpresaRepository EmpresaMethods = new EmpresaRepository();
        EquipamentoRepository EquipamentoMethods = new EquipamentoRepository();

        public void cadastrar(Equipamento equipConsole)
        {
            var noteZabbix = zabbix.GetHostByName(equipConsole.NomeNotebook).ToString();

            string[] linhas = noteZabbix.Split(",");

        }
    }
}
