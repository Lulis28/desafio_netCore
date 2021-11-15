using desafio_itau.DTOs.Moeda;
using desafio_itau.DTOs.Segmento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace desafio_itau.DTOs.Cotacao
{
    public class GetCotacaoPorSegmentoMoedaDTO
    {
        public GetSegmentoDTO GetSegmentoDTO { get; set; }
        public GetMoedaDTO GetMoedaDTO { get; set; }
        public decimal Quantidade { get; set; }
    }
}
