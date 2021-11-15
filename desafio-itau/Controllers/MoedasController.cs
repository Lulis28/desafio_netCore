using desafio_itau.DTOs.Moeda;
using desafio_itau.Entities;
using desafio_itau.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace desafio_itau.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoedasController : ControllerBase
    {
        private readonly IMoedaService _moedaService;

        public MoedasController(IMoedaService moedaService)
        {
            _moedaService = moedaService;
        }

        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<GetMoedaDTO>>>> Listar()
        {
            return Ok(await _moedaService.Listar());
        }
    }
}
