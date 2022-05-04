using BlockTime_Tracking.Contexts;
using BlockTime_Tracking.Domains;
using BlockTime_Tracking.Interfaces;
using BlockTime_Tracking.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlockTime_Tracking.Repositories
{
    public class EquipamentoRepository : IEquipamentoRepository
    {
        BlockTrackingContext ctx = new BlockTrackingContext();
        public Equipamento Criar(NoteViewModel noteAgente)
        {
            ZabbixRepository zabbix = new();

            Equipamento equipamento = new();

            var hostZabbix = zabbix.GetHostByName(noteAgente.NomeNotebook);

            equipamento.Lat = noteAgente.Lat;
            equipamento.Lng = noteAgente.Lng;
            equipamento.IdEquipamento = Int32.Parse(hostZabbix.Id);
            equipamento.NomeNotebook = noteAgente.NomeNotebook;
            equipamento.UltimaAtt = DateTime.Now;

            ctx.Equipamentos.Add(equipamento);
            ctx.SaveChanges();

            return equipamento;
        }
    }
}
