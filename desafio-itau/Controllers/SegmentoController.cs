using desafio_itau.DTOs.Cotacao;
using desafio_itau.DTOs.Segmento;
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
    public class SegmentoController : ControllerBase
    {
        private readonly ISegmentoService _segmentoService;
        private readonly ICotacaoService _cotacaoService;
        private readonly IMoedaService _moedaService;

        public SegmentoController(ISegmentoService segmentoService, ICotacaoService cotacaoService, IMoedaService moedaService)
        {
            _segmentoService = segmentoService;
            _cotacaoService = cotacaoService;
            _moedaService = moedaService;
        }

        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<GetSegmentoDTO>>>> Listar()
        {
            var resultado = await _segmentoService.Listar();
            if (resultado.Dados == null)
                return NotFound();

            if (!resultado.Sucesso)
                return Problem(resultado.Mensagem, null, 400);

            return Ok(await _segmentoService.Listar());


        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ServiceResponse<GetSegmentoDTO>>> ObterPorId(Guid id)
        {
            var resultado = await _segmentoService.ObterPorId(id);
            if (resultado.Dados == null)
                return NotFound();

            if (!resultado.Sucesso)
                return Problem(resultado.Mensagem, null, 400);


            return Ok(resultado);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<ServiceResponse<GetSegmentoDTO>>> Atualizar(Guid id, AtualizarSegmentoDTO atualizarSegmentoDTO)
        {
                var segmentoAntigo = await _segmentoService.ObterPorId(id);
                if (segmentoAntigo.Dados == null)
                    return NotFound();

            atualizarSegmentoDTO.Id = id;

            var resultado = await _segmentoService.Atualizar(atualizarSegmentoDTO);

            if (!resultado.Sucesso)
                return Problem(resultado.Mensagem, null, 400);

                return Ok(resultado);
        }

        [HttpGet("{id}/moedas/{moedaId}/cotacoes")]
        public async Task<ActionResult<ServiceResponse<GetCotacaoDTO>>> ObterCotacaoPorSegmentoMoeda(Guid id, Guid moedaId, [FromQuery] decimal quantidade)
        {

            var segmento = await _segmentoService.ObterPorId(id);
            if (segmento.Dados == null)
                return NotFound("Não foi possível recuperar o segmento.");

            var moeda = await _moedaService.ObterPorId(moedaId);
            if (moeda.Dados == null)
                return NotFound("Não foi possível recuperar a moeda.");

            var getCotacaoPorSegmentoMoedaDTO = new GetCotacaoPorSegmentoMoedaDTO();
            getCotacaoPorSegmentoMoedaDTO.GetSegmentoDTO = segmento.Dados;
            getCotacaoPorSegmentoMoedaDTO.GetMoedaDTO = moeda.Dados;
            getCotacaoPorSegmentoMoedaDTO.Quantidade = quantidade;

            var resultado = await _cotacaoService.ObterCotacaoPorSegmentoMoeda(getCotacaoPorSegmentoMoedaDTO);
            if (resultado.Dados == null)
                return Problem("", null, 400);

            if (!resultado.Sucesso)
                return Problem(resultado.Mensagem, null, 400);


            return Ok(resultado);
        }

    }
}
