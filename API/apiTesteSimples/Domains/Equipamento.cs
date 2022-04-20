using System;
using System.Collections.Generic;

#nullable disable

namespace apiTesteSimples.Domains
{
    public partial class Equipamento
    {
        public int IdEquipamentos { get; set; }
        public string Lat { get; set; }
        public string Lng { get; set; }
        public string Mac { get; set; }
        public int? IdEmpresa { get; set; }

        public virtual Empresa IdEmpresaNavigation { get; set; }
    }
}
