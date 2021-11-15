using desafio_itau.DTOs.Cotacao;
using desafio_itau.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace desafio_itau.Services.Interfaces
{
    public interface ICotacaoService
    {
        Task<ServiceResponse<GetCotacaoDTO>> ObterCotacaoPorSegmentoMoeda(GetCotacaoPorSegmentoMoedaDTO getCotacaoPorSegmentoMoedaDTO);
    }
}
