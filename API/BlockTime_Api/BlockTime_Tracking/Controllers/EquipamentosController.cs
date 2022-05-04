using BlockTime_Tracking.Interfaces;
using BlockTime_Tracking.Repositories;
using BlockTime_Tracking.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlockTime_Tracking.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class EquipamentosController : ControllerBase
    {
        private IEquipamentoRepository _EquipamentoRepository { get; set; }

        public EquipamentosController()
        {
            _EquipamentoRepository = new EquipamentoRepository();
        }

        //[HttpGet]
        //public IActionResult Login()
        //{
        //    return Ok(_EquipamentoRepository.Login());
        //}

        [HttpPost]
        public IActionResult CriarNote(NoteViewModel noteAgente)
        {
            return Ok(_EquipamentoRepository.Criar(noteAgente));
        }
    }
}
