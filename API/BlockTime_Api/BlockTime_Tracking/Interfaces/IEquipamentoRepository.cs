﻿using BlockTime_Tracking.Domains;
using BlockTime_Tracking.ViewModels;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlockTime_Tracking.Interfaces
{
    interface IEquipamentoRepository
    {

        Equipamento Criar(NoteViewModel note);
    }
}