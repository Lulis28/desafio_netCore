using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using desafio_itau.DTOs;
using desafio_itau.DTOs.Cotacao;
using desafio_itau.Entities;
using desafio_itau.Services.Interfaces;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace desafio_itau.Services
{
    public class CotacaoService : ICotacaoService
    {

        public async Task<ServiceResponse<GetCotacaoDTO>> ObterCotacaoPorSegmentoMoeda(GetCotacaoPorSegmentoMoedaDTO getCotacaoPorSegmentoMoedaDTO)
        {
            var serviceResponse = new ServiceResponse<GetCotacaoDTO>();

            var getCotacaoDTO = new GetCotacaoDTO();

            try
            {
                var client = new HttpClient();

                var responseValorMoeda = await client.GetAsync(getCotacaoPorSegmentoMoedaDTO.GetMoedaDTO.WebHook);

                var contentValorMoeda = await responseValorMoeda.Content.ReadAsStringAsync();

                var json = JObject.Parse(contentValorMoeda);

                var jsonConvert = json[getCotacaoPorSegmentoMoedaDTO.GetMoedaDTO.WebHookParameter];

                var valorMoeda = jsonConvert.ToObject<ValorCotacao>();

                var resultado = (getCotacaoPorSegmentoMoedaDTO.Quantidade * valorMoeda.Bid) * (1 + (decimal)getCotacaoPorSegmentoMoedaDTO.GetSegmentoDTO.ValorTaxa);

                getCotacaoDTO.Quantidade = getCotacaoPorSegmentoMoedaDTO.Quantidade;
                getCotacaoDTO.ValorMoeda = valorMoeda.Bid.ToString("C");
                getCotacaoDTO.TaxaSegmento = getCotacaoPorSegmentoMoedaDTO.GetSegmentoDTO.ValorTaxa;
                getCotacaoDTO.TotalEmReais = resultado.ToString("C");

                serviceResponse.Dados = getCotacaoDTO;

                return serviceResponse;


            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
